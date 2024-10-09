using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PhumlaKamnandi.Business.Room;
using PhumlaKamnandi.Data;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace PhumlaKamnandi.Presentation
{
    public partial class ReservationBooking : Form
    {
        #region Properties
        public bool IsGuest;//chech whether creating for a guest or an Agent
       // public bool MoreRooms = false;//Want to ad more rooms? 
        ReservationController rescontroller;
        //  RoomController roomController;
        private Guest guest;
        private BookingAgent agent;
        private GuestController guestController;
        private AgentController agentController;
        private List<Room> roomList;//store thenumber of rooms that are added by the user
        private Room.RoomType roomType;//store the room type of the wanted rooms
        private int number_of_rooms = 0;//store the number of rooms to be created
      //  private int room_to_be_deleted;
        private int guest_num;//store the number of guests that the customer will bring
        private int room_num;//storre the room number that must be removed
        private string resID;//ReservationID
        private bool IsAdding =false;//Store the state whether to add a room or remove
        ReservationDB resDB;
        DateTime checkInDate;
        List<int> list;//store the room numbers in a list
        //  string mode;
        DateTime checkOutDate;
        #endregion
        public ReservationBooking()
        {
            InitializeComponent();
            list = new List<int>();
            rescontroller = new ReservationController();
            roomList = new List<Room>();
            resDB = new ReservationDB();
            agentController = new AgentController();
            guestController = new GuestController();
            resID = ReservationIDAssignment.instance.GenerateReservationID();
        }

        private void ReservationBooking_Load(object sender, EventArgs e)
        {
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GuestRadioButton.Checked)//Guest Radio Button is Checked
            {
                IsGuest = true;

                creditCardLabel.Text = "Credit Card no.";
                expirationDateLabel.Text = "Expiration Date";
                expirationDateLabel.Visible = true;
                ExpirationDateTxtbox.Visible = true;
                ExpirationDateTxtbox.Width = 111;
                cvcTxtBox.Visible = true;
                cvcLabel.Visible = true;
                paymentLabel.Text = "Payment Details";
                guest = new Guest(GuestIDAssignment.AgentInstance.GenerateGuestID(), resID, FirstNametextbox.Text, lastNameTextBox.Text, PhonetextBox.Text, CitytextBox.Text + "," + StatetextBox.Text + "," + ZipCodetextBox.Text, EmailAddresstextBox.Text);


            }
            else if (AgentRadioButton.Checked)//Agent Radio Button is Checked
            {
                IsGuest = false;
                creditCardLabel.Text = "Company Name";
                paymentLabel.Text = "Company Details";
                cvcTxtBox.Visible = false;
                cvcLabel.Visible = false;
                expirationDateLabel.Visible = false;
                ExpirationDateTxtbox.Visible = false;
                //resID = ReservationIDAssignment.instance.GenerateReservationID();
                //get the number of guest properlyx
                /*
                 * I should change the Agent Class to take the reservationID
                 */
                agent = new BookingAgent(AgentIDAssignment.instance.GenerateGuestID(), resID, FirstNametextbox.Text, lastNameTextBox.Text, PhonetextBox.Text, EmailAddresstextBox.Text, streetTextBox.Text+", "+CitytextBox.Text + "," + StatetextBox.Text + "," + ZipCodetextBox.Text, crdTextBox.Text, 2);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            RoomController roomController = null;
            // Check if roomList is initialized and has rooms
            if (roomList == null || roomList.Count == 0)
            {
                MessageBox.Show("No rooms added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;+
            }

            // Check if reservation ID is generated
            if (string.IsNullOrEmpty(resID))
            {
                MessageBox.Show("Reservation ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize RoomController and make reservation based on Guest or Agent
            if (IsGuest)
            {
                // Ensure guest is not null
                if (guest == null)
                {
                    MessageBox.Show("Guest information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                guestController.AddGuest(guest);
                roomController = new RoomController(roomList, resID, guest.GuestID, IsGuest);
                Reservation reser = new Reservation(resID, guest.GuestID, checkInDate, checkOutDate, roomList, guest_num);
                //Add to Database
                resDB.DataSetChange(reser, DB.DBOperation.Add);
                resDB.UpdateDataSource(reser);
                //rescontroller.DataMaintenance(resID, guest.GuestID, checkInDate, checkOutDate, roomList, guest_num, DB.DBOperation.Add);
            }
            else if(IsGuest == false)
            {
                //Check this
                agentController.AddAgent(agent);
                roomController = new RoomController(roomList, resID, agent.AgentID, IsGuest);
                Reservation reser = new Reservation(resID, agent.AgentID, checkInDate, checkOutDate, roomList, guest_num);
                /**
                 * Add into the Database if it is not a guest
                 * 
                 *  roomController = new RoomController(roomList, resID, agent.AgentID, IsGuest);
                 rescontroller.DataMaintenance(resID, agent.AgentID, checkInDate, checkOutDate, roomList, guest_num, DB.DBOperation.Add);
                 */
            }
            /*
             * After adding to the database, display the feedback about that
             * and generate another reservationID
             * */

            // Display success message
            MessageBox.Show("Successfully Booked\n" + "ReservationID: " + resID, "Reservation");
            resID = ReservationIDAssignment.instance.GenerateReservationID();//change the resID after inserting to the db
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clearing all the text box
            Clear();
        }

        private void ReturnHomeButton1_Click(object sender, EventArgs e)
        {
            // Go to the Home Page
            if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
        }
        /**
         * Add button RADIO BUTTON IS CHEcked
         * */

        private void addRoomRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            roomTypeComboBox.DataSource = null;//Reset the combo box
            IsAdding = true;//Adding a room;
            numeric1.Enabled = true;
            roomTypeComboBox.Items.Clear();
            numeric2.Enabled = true;
            numOfRoomsLabel.Visible = true;
            numeric1.Visible = true;
            roomTypeComboBox.Text = "Select";
            roomTypeComboBox.Enabled = true;
            //Display the room types in the combo box
            roomTypeComboBox.DataSource = Enum.GetValues(typeof(RoomType));
            // mode = "Add";//add room mode
            roomTypeLabel.Visible = true;
            roomTypeLabel.Text = "Room Type";
            numOfRoomsLabel.Text = "Number of Rooms";
            roomTypeComboBox.Visible = true;//availabke
            //Guests Number Combo Box
            guestLabel.Visible = true;
            //  adultsNumComboBox.Visible = false;
            //Display the max size of rooms
            numeric2.Enabled = true;
            numeric2.Visible = true;
            //adultsNumComboBox.DataSource = (int)
            addRoomButton.Enabled = true;   
            addRoomButton.Text = "Add Room";
            addRoomButton.ForeColor = Color.Black;
        }

        /**
         * Clicked the Remove Room Raadio Button
         * */
        private void removeRoomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
            roomTypeComboBox.DataSource = null;//Reset the combo box
            roomTypeComboBox.Text = "Remove";
                                    // resListView.Items.Clear();
            IsAdding = false;//Removing a room;
            roomTypeLabel.Text = "Room Number";
            roomTypeComboBox.DataSource = list;
           // roomTypeComboBox.Text = "Select";
            //enable if there is atleast one room
            if (number_of_rooms >= 1)
            {

               //Enable the combobox when there are more than 1 chosen room
                roomTypeComboBox.DataSource = list;//display the available room numbers
                addRoomButton.Enabled = true;
            }
            else if(number_of_rooms == 0)
            {
                
                roomTypeComboBox.Enabled = false;  
                addRoomButton.Enabled = false;
            }

            numOfRoomsLabel.Visible = false;
            guestLabel.Visible = false;
            numeric2.Visible = false;
            numeric1.Visible = false;

           
            addRoomButton.Text = "Remove Room";
            addRoomButton.ForeColor = Color.Red;
        }
        public void Clear()
        {
            crdTextBox.Clear();
            cvcTxtBox.Clear();
            lastNameTextBox.Clear();
            FirstNametextbox.Clear();
            EmailAddresstextBox.Clear();
            streetTextBox.Clear();
            PhonetextBox.Clear();
            CitytextBox.Clear();
            StatetextBox.Clear();
            ZipCodetextBox.Clear();
            ExpirationDateTxtbox.Clear();
        }

        private void addRemRoomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            //Need to check whether a room is being added or removed
            if (IsAdding)//Adding a room
            {
                Room addedRoom = null;

                //Create a number of rooms according to the selected number of rooms
                for (int i = 1; i <= number_of_rooms; i++)
                {
                    resListView.View = View.Details;
                    resListView.Columns.Add("Room", 400);
                    //Add the room in to a list
                    addedRoom = new Room(RoomNumberAssignment.Instance.GenerateRoomNumber(roomType), roomType);
                    if (guest_num > addedRoom.MaxOccupancy)
                    {

                        MessageBox.Show("Max Occupancy is: " + addedRoom.MaxOccupancy, "Error", MessageBoxButtons.OK);
                        //Need to remove the generated RoomNumber from the list
                        RoomNumberAssignment.Instance.RemoveRoomNumber(addedRoom.RoomNumber);
                    }
                    else
                    {
                        list.Add(addedRoom.RoomNumber);
                        //Add the room in the list
                        roomList.Add(addedRoom);
                        //Show the added room on the screen
                        // resListView.Items = roomList;
                        resListView.Items.Clear();
                        foreach (Room room in roomList)
                        {
                            ListViewItem listView = new ListViewItem(room.getRoomDetails());
                            resListView.Items.Add(listView);//adds the item into the resListView

                        }
                    }

                }

                //make the list to be visiblw
                resListView.FullRowSelect = true;
                resListView.Scrollable = true;

                MessageBox.Show("Room(s) Added successfully.", "Room", MessageBoxButtons.OK);
                /*Then here we need to clear the data that is entered
                 * 
                 * */

            }
            else if(IsAdding == false) //Removing a room
            {

                if (room_num >= 0 && room_num < list.Count)
                {

                    // Get the room number to be removed
                    int roomNumberToRemove = list[room_num]; // Assuming list holds int values
                   // Room roomToRemove = null;

                    // Use a foreach loop to find the room object
                    for(int i=0; i<roomList.Count; i++)
                    {
                        if(roomList[i].RoomNumber == roomNumberToRemove)
                        {
                            roomList.RemoveAt(i);
                            MessageBox.Show("Room Number " + roomNumberToRemove + " has been removed.");
                            break;
                        }
                    }
                   
                 
                        //Remove the room from the list and roomList
                        list.Remove(list[room_num]);


                    // Update the roomTypeComboBox

                    roomTypeComboBox.DataSource = null; // Clear current data source
                    if (list.Count > 0)
                    {

                        //   roomTypeComboBox.DataSource = list; // Update data source if there are rooms left
                        roomTypeComboBox.DataSource = list; // Create a new List<int> for DataSource
                        roomTypeComboBox.Enabled = true;
                    }
                    else if (list.Count == 0)
                    {
                        roomTypeComboBox.Enabled = false; // Disable if no rooms left
                    }
                    // Now we need to update the ListView
                    resListView.Items.Clear(); // Clear existing items in ListView
                    foreach (Room room in roomList) // Re-populate the ListView with remaining rooms
                    {
                        ListViewItem listViewItem = new ListViewItem(room.getRoomDetails());
                        resListView.Items.Add(listViewItem);
                    }
                    //notify the user
                    MessageBox.Show("Room list updated successfully.", "Update", MessageBoxButtons.OK);
                }

            }



                 
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Get the value from the roomType combobox according to the action that is being done
             * 
             * */
            if (IsAdding==true)//GET THE ROOM TYPE that is choosen
            {
                roomType = (Room.RoomType)roomTypeComboBox.SelectedIndex;//get the chosen one

            }
            else
                //store the room number to remove
                room_num = (int)roomTypeComboBox.SelectedIndex;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /*
             * The first numericupDown value
             * */
             number_of_rooms = (int)numeric1.Value;
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Store the ChECK in Date
            checkInDate = checkIn.Value;
        }

        private void checkOut_ValueChanged(object sender, EventArgs e)
        {
            //Store the Check out Date
            checkOutDate = checkOut.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Gets the number of guests
             * */
            guest_num = (int)numeric2.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Gets the number of guests
             * */
            guest_num = (int)numeric2.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

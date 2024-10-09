using PhumlaKamnandi.Business;
using PhumlaKamnandi.Data;
using System.Drawing.Printing;
using static PhumlaKamnandi.Business.Room;

namespace PhumlaKamnandi.Presentation;

public partial class ChangeReservationForm : Form
{
    private Reservation reservation;
    private List<int> list;//store the room numbers in a list
    private List<Room> roomList;//store thenumber of rooms that are added by the user
    private bool IsAdding = false;//Store the state whether to add a room or remove
    private int number_of_rooms;
    private DateTime checkInDate;
    private DateTime checkOutDate;
   // public string ID;//chech whether creating for a guest or an Agent
    private int guest_num;
    private int room_num;
    private GuestController guestController;
    private AgentController agentController;
    private ReservationController reservationController;
   
    private Room.RoomType roomType;//store the room type of the wanted rooms

    public ChangeReservationForm(Reservation reservation)
    {
        InitializeComponent();
        this.reservation = reservation;
        checkIn.Value = reservation.CheckInDate;
        checkOut.Value = reservation.CheckOutDate;
        roomList = reservation._Rooms;
        number_of_rooms = list.Count;
        reservationController = new ReservationController();
        agentController = new AgentController();
        guestController = new GuestController();
        guest_num = reservation.NoOfGuests;
        resListView.View = View.Details;
        resListView.Columns.Add("Room", 400);
        resListView.Items.Clear();
        foreach (Room room in roomList)
        {
            list.Add(room.RoomNumber);
            ListViewItem listView = new ListViewItem(room.getRoomDetails());
            resListView.Items.Add(listView);//adds the item into the resListView

        }
        //make the list to be visiblw
        resListView.FullRowSelect = true;
        resListView.Scrollable = true;
        ID.Text = reservation.ID;
        if (ID.ToString().Contains("AGT"))
        {
            nameLabel.Text = agentController.FindAgent(ID.ToString()).CompanyName;
            contactDetailsLabel.Text = agentController.FindAgent(ID.ToString()).ContactDetails;
        }
        else if (ID.ToString().Contains("Gus"))
        {
            nameLabel.Text = guestController.FindGuest(ID.ToString()).GetFullName();
            contactDetailsLabel.Text = agentController.FindAgent(ID.ToString()).ContactDetails;
        }
         
        
    }


    private void ChangeReservationForm_Load(object sender, EventArgs e)
    {

    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        // Go to the Home Page
        if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

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
        else if (number_of_rooms == 0)
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

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

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

    private void label1_Click_1(object sender, EventArgs e)
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
        else if (IsAdding == false) //Removing a room
        {

            if (room_num >= 0 && room_num < list.Count)
            {

                // Get the room number to be removed
                int roomNumberToRemove = list[room_num]; // Assuming list holds int values
                                                         // Room roomToRemove = null;

                // Use a foreach loop to find the room object
                for (int i = 0; i < roomList.Count; i++)
                {
                    if (roomList[i].RoomNumber == roomNumberToRemove)
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

    private void adultsNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        RoomController roomController = null ;
        if (ID.ToString().Contains("Gus"))
        {

            roomController = new RoomController(roomList, reservation.ReservationId, reservation.ID, true);
            Reservation reser = new Reservation(reservation.ReservationId, reservation.ID, checkInDate, checkOutDate, roomList, guest_num);
           
            //Add to Database
            //use a controller
            //rescontroller.DataMaintenance(resID, guest.GuestID, checkInDate, checkOutDate, roomList, guest_num, DB.DBOperation.Add);
        }
        else if (ID.ToString().Contains("AGT"))
        {
           //edit this
           //add to database
            
            roomController = new RoomController(roomList, reservation.ReservationId, reservation.ID, false);
            Reservation reser = new Reservation(reservation.ReservationId, reservation.ID, checkInDate, checkOutDate, roomList, guest_num);
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
        MessageBox.Show("Successfully Changed\n" + "ReservationID: " + reservation.ReservationId, " Reservation");
    }

    private void numeric1_ValueChanged(object sender, EventArgs e)
    {
        /*
            * The first numericupDown value
            * */
        number_of_rooms = (int)numeric1.Value;
    }

    private void numeric2_ValueChanged(object sender, EventArgs e)
    {
        /*
             * Gets the number of guests
             * */
        guest_num = (int)numeric2.Value;
    }

    private void checkInDate_ValueChanged(object sender, EventArgs e)
    {
        //Store the ChECK in Date
        checkInDate = checkIn.Value;
    }

    private void checkOutDate_ValueChanged(object sender, EventArgs e)
    {
        //Store the Check out Date
        checkOutDate = checkOut.Value;
    }

    private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*Get the value from the roomType combobox according to the action that is being done
           * 
           * */
        if (IsAdding == true)//GET THE ROOM TYPE that is choosen
        {
            roomType = (Room.RoomType)roomTypeComboBox.SelectedIndex;//get the chosen one

        }
        else
            //store the room number to remove
            room_num = (int)roomTypeComboBox.SelectedIndex;
       
    }
}
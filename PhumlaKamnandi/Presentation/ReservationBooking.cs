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
namespace PhumlaKamnandi.Presentation
{
    public partial class ReservationBooking : Form
    {
        #region Properties
        public bool IsGuest;//chech whether creating for a guest or an Agent
        public bool MoreRooms = false;//Want to ad more rooms? 
        ReservationController rescontroller;
        RoomController roomController;
        private Guest guest;
        private BookingAgent agent;
        private List<Room> roomList;
        private Room.RoomType roomType;
        private int number_of_rooms = 0;//store the number of rooms to be created
        private int room_to_be_deleted;
        private int guest_num;
        private int room_num;
        private string resID;
        DateTime checkInDate;
        DateTime checkOutDate;
        Dictionary<int, int> dictionary;
        #endregion
        public ReservationBooking()
        {
            InitializeComponent();
            rescontroller = new ReservationController();
            roomList = new List<Room>();
            dictionary = new Dictionary<int, int>();
        }

        private void ReservationBooking_Load(object sender, EventArgs e)
        {

        }

        /*
         * ADD MORE ROOM BUTTON
         * roomController.Add(new Room(roomNumberGenerator))
         * 
         * */


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GuestRadioButton.Checked)//Guest Radio Button is Checked
            {
                IsGuest = true;

                creditCardLabel.Text = "Credit Card no.";
                expirationDateLabel.Text = "Expiration Date";
                ExpirationDateTxtbox.Width = 111;
                cvcTxtBox.Visible = true;
                cvcLabel.Visible = true;
                resID = ReservationIDAssignment.instance.GenerateReservationID();
                guest = new Guest(GuestIDAssignment.AgentInstance.GenerateGuestID(), resID, FirstNametextbox.Text, lastNameTextBox.Text, PhonetextBox.Text, CitytextBox.Text + "," + StatetextBox.Text + "," + ZipCodetextBox.Text, EmailAddresstextBox.Text);


            }
            else if (AgentRadioButton.Checked)//Agent Radio Button is Checked
            {
                IsGuest = false;
                creditCardLabel.Text = "Company Name";
                expirationDateLabel.Text = "Email";
                ExpirationDateTxtbox.Width = 150;
                cvcTxtBox.Visible = false;
                cvcLabel.Visible = false;
                resID = ReservationIDAssignment.instance.GenerateReservationID();
                //get the number of guest properlyx
                /*
                 * I should change the Agent Class to take the reservationID
                 */
                agent = new BookingAgent(FirstNametextbox.Text, lastNameTextBox.Text, PhonetextBox.Text, EmailAddresstextBox.Text, CitytextBox.Text + "," + StatetextBox.Text + "," + ZipCodetextBox.Text, crdTextBox.Text, AgentIDAssignment.instance.GenerateGuestID(), 2);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Create a Room Controller
            if (IsGuest)
            {
                /*Change the room controller IsGuest parameter on the constructor(Duplicate)
                 * 
                 * */
                roomController = new RoomController(roomList, resID, guest.GuestID, IsGuest);
                //Create a reservation
                //   Reservation reservation = new Reservation(resID, guest.GuestID, checkInDate, checkOutDate, roomList, guest_num);
                rescontroller.DataMaintenance(resID, guest.GuestID, checkInDate, checkOutDate, roomList, guest_num, DB.DBOperation.Add);

            }
            else if (!IsGuest)
            {
                roomController = new RoomController(roomList, resID, agent.AgentID,IsGuest);
                //Create a reservation
                //   Reservation reservation = new Reservation(resID, guest.GuestID, checkInDate, checkOutDate, roomList, guest_num);
                rescontroller.DataMaintenance(resID, agent.AgentID, checkInDate, checkOutDate, roomList, guest_num, DB.DBOperation.Add);
            }
            //Add the reservation to the Database/Dataset

            //Display a Message box
            MessageBox.Show("Successfully Booked\n" + "ReservationID: " + resID, "Reservation");
           

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clearing all the text box
            FirstNametextbox.Text = "";
            lastNameTextBox.Text = "";
            PhonetextBox.Text = "";
            CitytextBox.Text = "";
            StatetextBox.Text = "";
            ZipCodetextBox.Text = "";

            ExpirationDateTxtbox.Text = "";
            cvcTxtBox.Text = "";
            ExpirationDateTxtbox.Text = "";
            EmailAddresstextBox.Text = "";
            IDtextBox.Text = "";
        }

        private void ReturnHomeButton1_Click(object sender, EventArgs e)
        {
            // Go to the Home Page
            if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
        }

        private void addRoomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            roomTypeComboBox.Items.Clear();

            roomTypeComboBox.Text = "Select";
            /*
            roomTypeComboBox.Items.Add("Suite");
            roomTypeComboBox.Items.Add("Single");
            roomTypeComboBox.Items.Add("Double");
            roomTypeComboBox.Items.Add("Deluxe");
            */

            //tHE ROOM Type Combo Box
            roomTypeComboBox.DataSource = Enum.GetValues(typeof(RoomType));

            roomTypeLabel.Visible = true;
            roomTypeLabel.Text = "Room Type";
            numOfRoomsLabel.Text = "Number of Rooms";
            roomTypeComboBox.Visible = true;//availabke
            adultsNumLabel.Visible = false;
            adultsNumComboBox.Visible = false;
            addRoomButton.Text = "Add Room";
            addRoomButton.ForeColor = Color.Black;
        }

        private void removeRoomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numOfRoomsLabel.Text = "RoomID";
            roomTypeLabel.Visible = false;
            //Display the number of Rooms to remove if there are added rooms
            if (number_of_rooms == 0)
            {
                roomTypeComboBox.Visible = false;
            }
            else if (number_of_rooms != 0)
            {
                //the room to remove
                numericUpDown1.Enabled = true;
                roomTypeComboBox.Visible = true;
                //populat the combo box with the number or room to delete
                roomTypeComboBox.DataSource = AgentIDAssignment.instance.GetAssignedAgentIDs();

            }

            adultsNumLabel.Visible = false;
            adultsNumComboBox.Visible = false;
            addRoomButton.Text = "Remove Room";
            addRoomButton.ForeColor = Color.Red;
        }

        private void changeGuestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numOfRoomsLabel.Text = "RoomID";
            if (number_of_rooms == 0)
            {
                roomTypeLabel.Visible = false;
                roomTypeComboBox.Visible = false;
            }
            else if (number_of_rooms != 0)
            {
                //the room to change
                numericUpDown1.Enabled = true;
                roomTypeComboBox.Visible = true;
                //populat the combo box with the number or room to delete
                int max = 0;
                foreach (Room room in roomList)
                {
                    if (room.RoomNumber == guest_num)
                    {
                        max = room.MaxOccupancy;
                        //Display the maximum of guests that can be added
                        roomTypeComboBox.DataSource = room.MaxOccupancy;
                    }
                }



            }

            //roomTypeComboBox.Visible = false;
            adultsNumLabel.Visible = false;
            adultsNumComboBox.Visible = false;
            addRoomButton.Text = "Add Guest";
            addRoomButton.ForeColor = Color.Red;
        }

        private void addRemRoomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            Room addedRoom = null;
            if (addRoomButton.Text.Equals("Add Room"))
            {
                //Create a number of rooms according to the selected number of rooms
                for (int i = 0; i < number_of_rooms; i++)
                {
                    //Add the room in to a list
                    addedRoom = new Room(RoomNumberAssignment.Instance.GenerateRoomNumber(roomType), roomType);
                    roomList.Add(addedRoom);
                }
            }
            else if (addRoomButton.Equals("Remove Room"))
            {
                //delete the chosen room
                foreach (Room room in roomList)
                {
                    if (room.RoomNumber == room_to_be_deleted)
                    {
                        //remove from the list
                        roomList.Remove(room);
                    }
                }

            }
            else if (addRoomButton.Equals("Add Guest"))
            {
                // ArrayList<int,int> arrayList = new System.Collections.ArrayList<int, int>()
                dictionary.Add(room_num, guest_num);//add the number of guests according to their room number
            }

        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populate according to the action needed
            if (numOfRoomsLabel.Text.Equals("Number of Rooms"))
            {
                roomType = (Room.RoomType)roomTypeComboBox.SelectedIndex;//get the chosen one

            }

            else if (numOfRoomsLabel.Text.Equals("Add Guest"))
            {
                //store the number of guests selected
                guest_num = (int)roomTypeComboBox.SelectedIndex;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numOfRoomsLabel.Text.Equals("Add Room"))
            {

                //Store the number of rooms to be created
                number_of_rooms = (int)numericUpDown1.Value;
            }
            else
            {
                //get the room num to delete and add guests
                room_num = (int)numericUpDown1.Value;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Store the ChECK in Date
            checkInDate = checkIn.Value;
        }

        private void checkOut_ValueChanged(object sender, EventArgs e)
        {
            //Store the Check out Date
            checkInDate = checkOut.Value;
        }
    }
}

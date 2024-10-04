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
namespace PhumlaKamnandi.Presentation
{
    public partial class ReservationBooking : Form
    {
        #region Properties
        public bool IsGuest;//chech whether creating for a guest or an Agent
        public bool MoreRooms = false;//Want to ad more rooms? 
      
        public RoomNumberAssignment roomNumber_generator;
        ReservationDB res;

        #endregion
        public ReservationBooking()
        {
            InitializeComponent();
            res = new ReservationDB();
            roomNumber_generator = new RoomNumberAssignment();
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
            }
            else if (AgentRadioButton.Checked)//Agent Radio Button is Checked
            {
                IsGuest = false;
                creditCardLabel.Text = "Company Name";
                expirationDateLabel.Text = "Email";
                ExpirationDateTxtbox.Width = 150;
                cvcTxtBox.Visible = false;
                cvcLabel.Visible = false;

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(1, RoomType.Single, OccupancyStatus.Occupied));
            Reservation reservation = new Reservation("R001", "AGT001", new DateTime(2024, 10, 10), new DateTime(2024, 10, 15),rooms, 3);
            res.DataSetChange(reservation, DB.DBOperation.Add);
            res.UpdateDataSource(reservation);

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
            roomTypeComboBox.Items.Add("Suite");
            roomTypeComboBox.Items.Add("Single");
            roomTypeComboBox.Items.Add("Double");
            roomTypeComboBox.Items.Add("Deluxe");


            roomTypeLabel.Visible = true;
            roomTypeLabel.Text = "Room Type";
            numOfRoomsLabel.Text = "Number of Rooms";
            roomTypeComboBox.Visible = true;
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
            roomTypeComboBox.Visible = false;
            adultsNumLabel.Visible = false;
            adultsNumComboBox.Visible = false;
            addRoomButton.Text = "Remove Room";
            addRoomButton.ForeColor = Color.Red;
        }

        private void changeGuestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numOfRoomsLabel.Text = "RoomID";
            roomTypeLabel.Visible = false;
            roomTypeComboBox.Visible = false;
            adultsNumLabel.Visible = false;
            adultsNumComboBox.Visible = false;
            addRoomButton.Text = "Remove Room";
            addRoomButton.ForeColor = Color.Red;
        }
    }
}

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

namespace PhumlaKamnandi.Presentation
{
    public partial class ReservationBooking : Form
    {
        #region Properties
        public bool IsGuest;//chech whether creating for a guest or an Agent
        public bool MoreRooms = false;//Want to ad more rooms? 
        public GuestIDAssignment guestID_generator;
        public GuestController guestController;
        public ReservationIDAssignment reservationID_generator;
        public AgentIDAssignment agentID_generator;

        public RoomController roomController;
        public RoomNumberAssignment roomNumber_generator;

        #endregion
        public ReservationBooking()
        {
            InitializeComponent();
            guestID_generator = new GuestIDAssignment();
            guestController = new GuestController();
            reservationID_generator = new ReservationIDAssignment();
            agentID_generator = new AgentIDAssignment();
            roomController = new RoomController();
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

            }
            else if (AgentRadioButton.Checked)//Agent Radio Button is Checked
            {
                IsGuest = false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MoreRooms)
            {
                //here just pass the roomcontroller, no need to create a new room object
                if (IsGuest)
                {
              //      Guest guest = new Guest(guestID_generator.GenerateGuestID(), FirstNametextbox.Text, LastNameLabel.Text, PhonetextBox.Text, CitytextBox.Text + ", " + StatetextBox.Text + ", " + ZipCodetextBox.Text, EmailAddresstextBox.Text,int.Parse( crdTextBox.Text), ExpirationDateTxtbox.Text, int.Parse(cvcTxtBox.Text));
                    //  Reservation reservation = new Reservation(reservationID_generator.GenerateReservationID(), guest, checkInDate, checkOutDate, noOfGuests, roomController);
                }
                else if (!IsGuest)
                {
                    //Create an Agent Object
                }

            }
            else if (!MoreRooms)
            {
                Room room;//Create the room object here, USE THE ROOMidgENERATOR TO generate the roomID
                          // roomController.AddRoom(); add it in to the thingie
                if (IsGuest)
                {
             //       Guest guest = new Guest(guestID_generator.GenerateGuestID(), FirstNametextbox.Text, LastNameLabel.Text, PhonetextBox.Text, CitytextBox.Text + ", " + StatetextBox.Text + ", " + ZipCodetextBox.Text, EmailAddresstextBox.Text, int.Parse(crdTextBox.Text), ExpirationDateTxtbox.Text, int.Parse(cvcTxtBox.Text));
             //       //  Reservation reservation = new Reservation(reservationID_generator.GenerateReservationID(), guest, checkInDate, checkOutDate, noOfGuests, roomController);
                }
                else if (!IsGuest)
                {
                    //Create an Agent Object
                }

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNametextbox.Text = " ";
            LastNameLabel.Text = " ";
            PhonetextBox.Text = " ";
            CitytextBox.Text = " ";
            StatetextBox.Text = " ";
            ZipCodetextBox.Text = " ";
            CompanyNametextBox2.Text = " ";
            ExpirationDateTxtbox.Text = " ";
            cvcTxtBox.Text = " ";
            ExpirationDateTxtbox.Text = " ";
            Address1TextBox1.Text = " ";
            Address2TextBox.Text = " ";
            EmailAddresstextBox.Text = " ";
            IDtextBox.Text = " ";
        }

        private void ReturnHomeButton1_Click(object sender, EventArgs e)
        {
            // Go to the Home Page
            if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
        }
    }
}

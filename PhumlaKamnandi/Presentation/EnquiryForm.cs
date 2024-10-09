using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhumlaKamnandi.Presentation
{
    public partial class EnquiryForm : Form
    {
        #region Fields
        bool isOpen = false;
        ReservationController reservationController;
        //Reservation res;
        RoomController roomController;
        #endregion
        public EnquiryForm()
        {
            InitializeComponent();
        }

        private void EnquiryForm_Load(object sender, EventArgs e)
        {

        }
        private void search_Click(object sender, EventArgs e)
        {
            if (reservationTextBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Reservation Not Found!\nCreate A New Reservation ?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Go to booking page", "New Booking", MessageBoxButtons.OK);

                }
                else if (result == DialogResult.No)
                {
                    DialogResult res = MessageBox.Show(reservationTextBox.Text + "\nUpdate ?", "Details", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Go to Change an booking Page", "Change booking", MessageBoxButtons.OK);

                    }
                }
                reservationTextBox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Go to the Home Page
            if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            string resID = reservationTextBox.Text;

            // Check if the textbox is empty
            if (string.IsNullOrEmpty(resID))
            {
                MessageBox.Show("Please enter a reservation ID.");
                return;
            }

            // Search for the reservation using the controller
            Reservation res = reservationController.FindReservationById(resID);

            // Check if the reservation was found
            if (res == null)
            {
                MessageBox.Show("Reservation not found.");
                return;
            }

            // Clear previous data in the ListView
            OutputView.Items.Clear();
            OutputView.Columns.Clear();

            // Set up the ListView's appearance and columns
            OutputView.View = View.Details;
            OutputView.FullRowSelect = true;
            OutputView.GridLines = true;

            // Define the columns (assuming your Reservation object has these properties)
            OutputView.Columns.Add("Reservation ID", 100);
            OutputView.Columns.Add("Guest ID/Agent Id", 100); // Add GuestID
            OutputView.Columns.Add("Room ID", 100);  // Add RoomID

            // Create a ListViewItem to display the reservation details
            ListViewItem item = new ListViewItem(res.ID);  // Add ResID as the first column

            // Add the sub-items (other reservation properties)
            item.SubItems.Add(res.ID.ToString());    // Assuming GuestID is a property in the Reservation object
            item.SubItems.Add(res._Rooms.ToString());     // Assuming RoomID is a property in the Reservation object

            // Add the ListViewItem to the ListView
            OutputView.Items.Add(item);
        }

        private void reservationTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = Console.ReadLine();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            reservationTextBox.Text = "";
            // Clear all items in the ListView
            OutputView.Items.Clear();

        }
    }
}

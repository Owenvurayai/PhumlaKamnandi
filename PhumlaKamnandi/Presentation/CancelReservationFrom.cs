using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Presentation
{
    public partial class CancelReservationFrom : Form
    {
        ReservationDB reservationDB;


        public CancelReservationFrom(ReservationDB reservationDB)
        {
            InitializeComponent();
            this.reservationDB = reservationDB;
        }

        private void reservationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            // Go to the Home Page
            if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fetch instruction need to completed for the reservation data to appear on the list View





        }

        private void search_Click(object sender, EventArgs e)
        {
            string id = reservationIDTextBox.Text;
            Reservation reservation = null;
            //Reservation 
            foreach (Reservation r in reservationDB.Reservations)
            {


                if (id.Equals(r.ReservationId))
                {
                    reservation = r;
                    break;
                }
            }

            if (reservation != null)
            {
                MessageBox.Show(reservation.GetReservationDetails());
            }
        }
    }
}

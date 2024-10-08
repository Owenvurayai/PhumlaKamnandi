using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Presentation
{
    public partial class FindReservation : Form
    {
        private Form changeReservationForm;
        public ReservationDB reservationDB;
        public RoomDB roomDB;

        public FindReservation(ReservationDB resBD, RoomDB roomDB)
        {
            InitializeComponent();
            reservationDB = resBD;
            this.roomDB = roomDB;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string id = reservationTextBox.Text;
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
                this.Visible = false; // go to the change reservation form
                // Here we need to query to database and get reservation info
                changeReservationForm = new ChangeReservationForm(this, reservation, roomDB, reservationDB); //
                changeReservationForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

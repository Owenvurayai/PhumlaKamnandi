using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;
using System.Windows.Forms;

namespace PhumlaKamnandi.Presentation
{
    public partial class FindReservation : Form
    {
        private Form changeReservationForm;
        private ReservationController resController;
        private Reservation reservation;

        public FindReservation()
        {
            InitializeComponent();
            resController = new ReservationController();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (resTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a reservation!!!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                reservation = resController.FindReservationById(resTextBox.Text);
                if (reservation == null)
                {
                    MessageBox.Show("Enter a valid ReservationID", "Error", MessageBoxButtons.OK);

                }
                else
                {
                    this.Visible = false;   // go to the change reservation form
                    //start the second page and pass the reservation object to it
                    changeReservationForm = new ChangeReservationForm(reservation);
                    //start the page
                    changeReservationForm.ShowDialog();
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindReservation_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class EnquiryForm : Form
    {
        #region Fields
        bool isOpen=false;
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
    }
}

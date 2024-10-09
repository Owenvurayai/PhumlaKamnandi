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
    public partial class FindReservation : Form
    {
        private Form changeReservationForm;

        public FindReservation()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Visible = false;   // go to the change reservation form
            // Here we need to query to database and get reservation info
            changeReservationForm = new ChangeReservationForm(this);  // 
            changeReservationForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            reservationTextBox.Text = "";
        }
    }
}

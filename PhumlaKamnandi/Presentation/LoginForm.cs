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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm h = new HomeForm();
            h.Show();
            this.Visible = false;
        }

        //cancel button event Handler
        private void button3_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog box with "Yes" and "No" buttons
            DialogResult result = MessageBox.Show("Are you sure you want to exit the app?",
                                                  "Exit Application",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
            // If "No" is clicked, the application will continue running
        }
    }
}

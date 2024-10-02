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
        #region Fields
        //Declare a dictionary to store usernames and passwords.
        Dictionary<string, string> employees = new Dictionary<string, string>
    {
        { "Given", "MHLGIV006" },
        { "Kholisile", "NDZKHO004" },
        { "Siyabonga", "ZNGSIY012" },
         {"Owen","VRYOWE001" }
    };

        bool isOpen=false;
        #endregion
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginSubmitbutton_Click(object sender, EventArgs e)
        {
            // Get user input from the textboxes
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            // Check if the username exists in the dictionary
            if (employees.ContainsKey(enteredUsername))
            {
                // Check if the password matches the one stored in the dictionary
                if (employees[enteredUsername] == enteredPassword)
                {
                    // Successful login
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomeForm h = new HomeForm(this);
                    h.Show();
                    this.Visible = false;

                }
                else
                {
                    // Incorrect password
                    MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Username not found
                MessageBox.Show("Username not found. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        }
    }
}

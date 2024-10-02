﻿namespace PhumlaKamnandi.Presentation
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            submitButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(137, 12, 12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 121);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(241, 33);
            label4.Name = "label4";
            label4.Size = new Size(331, 46);
            label4.TabIndex = 2;
            label4.Text = "Phumlani Kamnandi";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(submitButton);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(118, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 331);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(160, 275);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(76, 209, 55);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(346, 275);
            submitButton.Margin = new Padding(0);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += loginSubmitbutton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(160, 192);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(280, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(160, 133);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(280, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 199);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 136);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(210, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 38);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 689);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button submitButton;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
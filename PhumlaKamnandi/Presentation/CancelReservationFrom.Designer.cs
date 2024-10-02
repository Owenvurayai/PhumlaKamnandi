namespace PhumlaKamnandi.Presentation
{
    partial class CancelReservationFrom
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
            ClearButton = new Button();
            reservationIDTextBox = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            listView1 = new ListView();
            search = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Image = Properties.Resources.icons8_home_24;
            ClearButton.Location = new Point(62, 545);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(151, 36);
            ClearButton.TabIndex = 6;
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += HomeButton_Click;
            // 
            // reservationIDTextBox
            // 
            reservationIDTextBox.Location = new Point(236, 153);
            reservationIDTextBox.Margin = new Padding(3, 4, 3, 4);
            reservationIDTextBox.Name = "reservationIDTextBox";
            reservationIDTextBox.Size = new Size(233, 27);
            reservationIDTextBox.TabIndex = 9;
            reservationIDTextBox.TextChanged += reservationTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 160);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter Reservation ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(137, 12, 12);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 80);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(30, 19);
            label6.Name = "label6";
            label6.Size = new Size(264, 38);
            label6.TabIndex = 3;
            label6.Text = "Cancel Reservation";
            // 
            // listView1
            // 
            listView1.Location = new Point(62, 326);
            listView1.Name = "listView1";
            listView1.Size = new Size(407, 186);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // search
            // 
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Microsoft Sans Serif", 8.25F);
            search.ForeColor = Color.FromArgb(68, 189, 50);
            search.Location = new Point(60, 225);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(409, 34);
            search.TabIndex = 11;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(318, 545);
            button1.Name = "button1";
            button1.Size = new Size(151, 36);
            button1.TabIndex = 13;
            button1.Text = "Cancel Reservation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CancelReservationFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 617);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(search);
            Controls.Add(panel1);
            Controls.Add(reservationIDTextBox);
            Controls.Add(label2);
            Controls.Add(ClearButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(564, 664);
            MinimumSize = new Size(564, 664);
            Name = "CancelReservationFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelReservationFrom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ClearButton;
        private Button returnHomeButton;
        private TextBox reservationIDTextBox;
        private Label label2;
        private Panel panel1;
        private Label label6;
        private ListView listView1;
        private Button search;
        private Button button1;
    }
}
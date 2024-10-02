namespace PhumlaKamnandi.Presentation
{
    partial class FindReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindReservation));
            button1 = new Button();
            ClearButton = new Button();
            panel1 = new Panel();
            label6 = new Label();
            search = new Button();
            reservationTextBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(61, 362);
            button1.Name = "button1";
            button1.Size = new Size(151, 36);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(317, 362);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(151, 36);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(137, 12, 12);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 80);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(30, 19);
            label6.Name = "label6";
            label6.Size = new Size(236, 38);
            label6.TabIndex = 3;
            label6.Text = "Find Reservation";
            // 
            // search
            // 
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Microsoft Sans Serif", 8.25F);
            search.ForeColor = Color.FromArgb(68, 189, 50);
            search.Location = new Point(59, 225);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(409, 34);
            search.TabIndex = 10;
            search.Text = "Find reservation";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // reservationTextBox
            // 
            reservationTextBox.Location = new Point(235, 153);
            reservationTextBox.Margin = new Padding(3, 4, 3, 4);
            reservationTextBox.Name = "reservationTextBox";
            reservationTextBox.Size = new Size(233, 27);
            reservationTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 160);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 9;
            label2.Text = "Enter Reservation ID:";
            // 
            // FindReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 434);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(panel1);
            Controls.Add(search);
            Controls.Add(reservationTextBox);
            Controls.Add(label2);
            Name = "FindReservation";
            Text = "FindReservation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button ClearButton;
        private Panel panel1;
        private Label label6;
        private Button search;
        private TextBox reservationTextBox;
        private Label label2;
    }
}
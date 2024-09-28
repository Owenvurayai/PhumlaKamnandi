namespace PhumlaKamnandi.Presentation
{
    partial class EnquiryForm
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
            label2 = new Label();
            reservationTextBox = new TextBox();
            search = new Button();
            panel1 = new Panel();
            label6 = new Label();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 193);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter Reservation ID:";
            // 
            // reservationTextBox
            // 
            reservationTextBox.Location = new Point(247, 186);
            reservationTextBox.Margin = new Padding(3, 4, 3, 4);
            reservationTextBox.Name = "reservationTextBox";
            reservationTextBox.Size = new Size(233, 27);
            reservationTextBox.TabIndex = 4;
            // 
            // search
            // 
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Microsoft Sans Serif", 8.25F);
            search.ForeColor = Color.FromArgb(68, 189, 50);
            search.Location = new Point(71, 288);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(409, 34);
            search.TabIndex = 4;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(137, 12, 12);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 80);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(30, 19);
            label6.Name = "label6";
            label6.Size = new Size(118, 38);
            label6.TabIndex = 3;
            label6.Text = "Enquiry";
            // 
            // listView1
            // 
            listView1.Location = new Point(73, 389);
            listView1.Name = "listView1";
            listView1.Size = new Size(407, 186);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EnquiryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 617);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(search);
            Controls.Add(reservationTextBox);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnquiryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnquiryForm";
            Load += EnquiryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox reservationTextBox;
        private Button search;
        private Panel panel1;
        private Label label6;
        private ListView listView1;
    }
}
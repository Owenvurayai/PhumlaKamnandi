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
            homeButton = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            reservationTextBox = new TextBox();
            search = new Button();
            SuspendLayout();
            // 
            // homeButton
            // 
            homeButton.BackgroundImage = Properties.Resources.pngegg;
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.Location = new Point(3, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 51);
            homeButton.TabIndex = 0;
            homeButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pngegg__2_;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(536, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 51);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Italic);
            label1.Location = new Point(230, 16);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 2;
            label1.Text = "Phumla Kamnandi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 143);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter Reservation ID:";
            // 
            // reservationTextBox
            // 
            reservationTextBox.Location = new Point(285, 140);
            reservationTextBox.Name = "reservationTextBox";
            reservationTextBox.Size = new Size(163, 23);
            reservationTextBox.TabIndex = 4;
            // 
            // search
            // 
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Microsoft Sans Serif", 8.25F);
            search.Location = new Point(252, 214);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 4;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            // 
            // EnquiryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 316);
            Controls.Add(search);
            Controls.Add(reservationTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(homeButton);
            Name = "EnquiryForm";
            Text = "EnquiryForm";
            Load += EnquiryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button homeButton;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox reservationTextBox;
        private Button search;
    }
}
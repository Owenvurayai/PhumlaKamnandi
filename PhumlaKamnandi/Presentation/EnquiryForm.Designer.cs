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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnquiryForm));
            label2 = new Label();
            reservationTextBox = new TextBox();
            search = new Button();
            panel1 = new Panel();
            label6 = new Label();
            OutputView = new ListView();
            ClearButton = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 120);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter Reservation ID:";
            // 
            // reservationTextBox
            // 
            reservationTextBox.Location = new Point(206, 115);
            reservationTextBox.Name = "reservationTextBox";
            reservationTextBox.Size = new Size(204, 23);
            reservationTextBox.TabIndex = 4;
            reservationTextBox.TextChanged += reservationTextBox_TextChanged;
            // 
            // search
            // 
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Microsoft Sans Serif", 8.25F);
            search.ForeColor = Color.FromArgb(68, 189, 50);
            search.Location = new Point(52, 169);
            search.Name = "search";
            search.Size = new Size(358, 26);
            search.TabIndex = 4;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(137, 12, 12);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 60);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(26, 14);
            label6.Name = "label6";
            label6.Size = new Size(93, 30);
            label6.TabIndex = 3;
            label6.Text = "Enquiry";
            // 
            // OutputView
            // 
            OutputView.Location = new Point(54, 244);
            OutputView.Margin = new Padding(3, 2, 3, 2);
            OutputView.Name = "OutputView";
            OutputView.Size = new Size(357, 140);
            OutputView.TabIndex = 6;
            OutputView.UseCompatibleStateImageBehavior = false;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(278, 412);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(132, 27);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(54, 412);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 27);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EnquiryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 469);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(OutputView);
            Controls.Add(panel1);
            Controls.Add(search);
            Controls.Add(reservationTextBox);
            Controls.Add(label2);
            MaximumSize = new Size(496, 508);
            MinimumSize = new Size(496, 508);
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
        private ListView OutputView;
        private Button ClearButton;
        private Button button1;
    }
}
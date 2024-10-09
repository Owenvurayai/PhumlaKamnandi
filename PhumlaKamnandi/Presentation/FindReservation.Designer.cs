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
            searchBtn = new Button();
            resTextBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(53, 272);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 27);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(277, 272);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(132, 27);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(137, 12, 12);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 60);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(26, 14);
            label6.Name = "label6";
            label6.Size = new Size(185, 30);
            label6.TabIndex = 3;
            label6.Text = "Find Reservation";
            // 
            // searchBtn
            // 
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Microsoft Sans Serif", 8.25F);
            searchBtn.ForeColor = Color.FromArgb(68, 189, 50);
            searchBtn.Location = new Point(52, 169);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(358, 26);
            searchBtn.TabIndex = 10;
            searchBtn.Text = "Find reservation";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += search_Click;
            // 
            // resTextBox
            // 
            resTextBox.Location = new Point(206, 115);
            resTextBox.Name = "resTextBox";
            resTextBox.Size = new Size(204, 23);
            resTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 120);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 9;
            label2.Text = "Enter Reservation ID:";
            // 
            // FindReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 326);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(panel1);
            Controls.Add(searchBtn);
            Controls.Add(resTextBox);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FindReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FindReservation";
            Load += FindReservation_Load;
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
        private Button searchBtn;
        private TextBox resTextBox;
        private Label label2;
    }
}
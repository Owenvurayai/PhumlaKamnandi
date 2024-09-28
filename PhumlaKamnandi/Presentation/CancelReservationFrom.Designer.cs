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
            cancelReservationLabel = new Label();
            ReservationIDLabel = new Label();
            ReservationIDtextbox = new TextBox();
            pictureBox1 = new PictureBox();
            ProfilepictureBox = new PictureBox();
            CancelReservationButton = new Button();
            ClearButton = new Button();
            returnHomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilepictureBox).BeginInit();
            SuspendLayout();
            // 
            // cancelReservationLabel
            // 
            cancelReservationLabel.AutoSize = true;
            cancelReservationLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelReservationLabel.Location = new Point(30, 18);
            cancelReservationLabel.Name = "cancelReservationLabel";
            cancelReservationLabel.Size = new Size(185, 25);
            cancelReservationLabel.TabIndex = 0;
            cancelReservationLabel.Text = "Cancel Reservation ";
            // 
            // ReservationIDLabel
            // 
            ReservationIDLabel.AutoSize = true;
            ReservationIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservationIDLabel.Location = new Point(92, 111);
            ReservationIDLabel.Margin = new Padding(2, 0, 2, 0);
            ReservationIDLabel.Name = "ReservationIDLabel";
            ReservationIDLabel.Size = new Size(123, 15);
            ReservationIDLabel.TabIndex = 1;
            ReservationIDLabel.Text = "Enter Reservation ID";
            // 
            // ReservationIDtextbox
            // 
            ReservationIDtextbox.Location = new Point(235, 103);
            ReservationIDtextbox.Name = "ReservationIDtextbox";
            ReservationIDtextbox.Size = new Size(189, 23);
            ReservationIDtextbox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(248, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ProfilepictureBox
            // 
            ProfilepictureBox.InitialImage = Properties.Resources.pngegg__2_;
            ProfilepictureBox.Location = new Point(665, 12);
            ProfilepictureBox.Name = "ProfilepictureBox";
            ProfilepictureBox.Size = new Size(100, 50);
            ProfilepictureBox.TabIndex = 4;
            ProfilepictureBox.TabStop = false;
            ProfilepictureBox.WaitOnLoad = true;
            // 
            // CancelReservationButton
            // 
            CancelReservationButton.Location = new Point(425, 156);
            CancelReservationButton.Name = "CancelReservationButton";
            CancelReservationButton.Size = new Size(140, 23);
            CancelReservationButton.TabIndex = 5;
            CancelReservationButton.Text = "Cancel  Reservation ";
            CancelReservationButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(319, 156);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // returnHomeButton
            // 
            returnHomeButton.Location = new Point(166, 156);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(112, 23);
            returnHomeButton.TabIndex = 7;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            // 
            // CancelReservationFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 253);
            Controls.Add(returnHomeButton);
            Controls.Add(ClearButton);
            Controls.Add(CancelReservationButton);
            Controls.Add(ProfilepictureBox);
            Controls.Add(pictureBox1);
            Controls.Add(ReservationIDtextbox);
            Controls.Add(ReservationIDLabel);
            Controls.Add(cancelReservationLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CancelReservationFrom";
            Text = "CancelReservationFrom";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cancelReservationLabel;
        private Label ReservationIDLabel;
        private TextBox ReservationIDtextbox;
        private PictureBox pictureBox1;
        private PictureBox ProfilepictureBox;
        private Button CancelReservationButton;
        private Button ClearButton;
        private Button returnHomeButton;
    }
}
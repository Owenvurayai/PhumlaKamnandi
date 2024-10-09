namespace PhumlaKamnandi.Presentation
{
    partial class ReservationBooking
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
            ReturnHomeButton1 = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            pictureBox2 = new PictureBox();
            PersonalDetailsLabel = new Label();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            CityLabel = new Label();
            StateLabel = new Label();
            ZipCodeLabel = new Label();
            PhoneLabel = new Label();
            EmailAddressLabel = new Label();
            ReservationDetailsLabel = new Label();
            FirstNametextbox = new TextBox();
            CitytextBox = new TextBox();
            PhonetextBox = new TextBox();
            lastNameTextBox = new TextBox();
            StatetextBox = new TextBox();
            EmailAddresstextBox = new TextBox();
            ZipCodetextBox = new TextBox();
            streetLabel = new Label();
            streetTextBox = new TextBox();
            GuestRadioButton = new RadioButton();
            AgentRadioButton = new RadioButton();
            label1 = new Label();
            crdTextBox = new TextBox();
            ExpirationDateTxtbox = new TextBox();
            creditCardLabel = new Label();
            expirationDateLabel = new Label();
            cvcTxtBox = new TextBox();
            cvcLabel = new Label();
            addRemRoomPanel = new Panel();
            numeric2 = new NumericUpDown();
            guestLabel = new Label();
            resListView = new ListView();
            removeRoomRadioButton = new RadioButton();
            addRoomRadioButton = new RadioButton();
            addRoomButton = new Button();
            numeric1 = new NumericUpDown();
            numOfRoomsLabel = new Label();
            roomTypeComboBox = new ComboBox();
            roomTypeLabel = new Label();
            paymentLabel = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label2 = new Label();
            checkOut = new DateTimePicker();
            checkIn = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            addRemRoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ReturnHomeButton1
            // 
            ReturnHomeButton1.BackColor = SystemColors.ButtonFace;
            ReturnHomeButton1.ForeColor = Color.Black;
            ReturnHomeButton1.Image = Properties.Resources.icons8_home_24;
            ReturnHomeButton1.Location = new Point(23, 566);
            ReturnHomeButton1.Name = "ReturnHomeButton1";
            ReturnHomeButton1.Size = new Size(109, 23);
            ReturnHomeButton1.TabIndex = 0;
            ReturnHomeButton1.UseVisualStyleBackColor = false;
            ReturnHomeButton1.Click += ReturnHomeButton1_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(242, 566);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(119, 23);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(76, 209, 55);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(913, 566);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(156, 23);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(137, 12, 12);
            pictureBox2.Location = new Point(2, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1233, 66);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PersonalDetailsLabel
            // 
            PersonalDetailsLabel.AutoSize = true;
            PersonalDetailsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonalDetailsLabel.Location = new Point(23, 82);
            PersonalDetailsLabel.Name = "PersonalDetailsLabel";
            PersonalDetailsLabel.Size = new Size(108, 17);
            PersonalDetailsLabel.TabIndex = 8;
            PersonalDetailsLabel.Text = "Personal Details";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(35, 154);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(338, 151);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Last Name";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(35, 222);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 13;
            CityLabel.Text = "City";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(338, 227);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(33, 15);
            StateLabel.TabIndex = 14;
            StateLabel.Text = "State";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(340, 260);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(55, 15);
            ZipCodeLabel.TabIndex = 15;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(35, 255);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(41, 15);
            PhoneLabel.TabIndex = 16;
            PhoneLabel.Text = "Phone";
            // 
            // EmailAddressLabel
            // 
            EmailAddressLabel.AutoSize = true;
            EmailAddressLabel.Location = new Point(338, 187);
            EmailAddressLabel.Name = "EmailAddressLabel";
            EmailAddressLabel.Size = new Size(36, 15);
            EmailAddressLabel.TabIndex = 17;
            EmailAddressLabel.Text = "Email";
            // 
            // ReservationDetailsLabel
            // 
            ReservationDetailsLabel.AutoSize = true;
            ReservationDetailsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservationDetailsLabel.Location = new Point(643, 82);
            ReservationDetailsLabel.Name = "ReservationDetailsLabel";
            ReservationDetailsLabel.Size = new Size(111, 17);
            ReservationDetailsLabel.TabIndex = 18;
            ReservationDetailsLabel.Text = "Room Allocation";
            // 
            // FirstNametextbox
            // 
            FirstNametextbox.Location = new Point(130, 151);
            FirstNametextbox.Name = "FirstNametextbox";
            FirstNametextbox.Size = new Size(153, 23);
            FirstNametextbox.TabIndex = 20;
            // 
            // CitytextBox
            // 
            CitytextBox.Location = new Point(130, 222);
            CitytextBox.Name = "CitytextBox";
            CitytextBox.Size = new Size(152, 23);
            CitytextBox.TabIndex = 22;
            // 
            // PhonetextBox
            // 
            PhonetextBox.Location = new Point(130, 255);
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(152, 23);
            PhonetextBox.TabIndex = 23;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(413, 146);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 24;
            // 
            // StatetextBox
            // 
            StatetextBox.Location = new Point(410, 221);
            StatetextBox.Name = "StatetextBox";
            StatetextBox.Size = new Size(100, 23);
            StatetextBox.TabIndex = 26;
            // 
            // EmailAddresstextBox
            // 
            EmailAddresstextBox.Location = new Point(410, 187);
            EmailAddresstextBox.Name = "EmailAddresstextBox";
            EmailAddresstextBox.Size = new Size(200, 23);
            EmailAddresstextBox.TabIndex = 27;
            // 
            // ZipCodetextBox
            // 
            ZipCodetextBox.Location = new Point(410, 260);
            ZipCodetextBox.Name = "ZipCodetextBox";
            ZipCodetextBox.Size = new Size(98, 23);
            ZipCodetextBox.TabIndex = 28;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(35, 190);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(72, 15);
            streetLabel.TabIndex = 37;
            streetLabel.Text = "Street Name";
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(130, 188);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(153, 23);
            streetTextBox.TabIndex = 38;
            // 
            // GuestRadioButton
            // 
            GuestRadioButton.AutoSize = true;
            GuestRadioButton.Checked = true;
            GuestRadioButton.Location = new Point(38, 113);
            GuestRadioButton.Name = "GuestRadioButton";
            GuestRadioButton.Size = new Size(55, 19);
            GuestRadioButton.TabIndex = 41;
            GuestRadioButton.TabStop = true;
            GuestRadioButton.Text = "Guest";
            GuestRadioButton.UseVisualStyleBackColor = true;
            GuestRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // AgentRadioButton
            // 
            AgentRadioButton.AutoSize = true;
            AgentRadioButton.Location = new Point(192, 112);
            AgentRadioButton.Name = "AgentRadioButton";
            AgentRadioButton.Size = new Size(57, 19);
            AgentRadioButton.TabIndex = 42;
            AgentRadioButton.Text = "Agent";
            AgentRadioButton.UseVisualStyleBackColor = true;
            AgentRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(137, 12, 12);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 45;
            label1.Text = "Reservation Booking";
            // 
            // crdTextBox
            // 
            crdTextBox.Location = new Point(38, 384);
            crdTextBox.Name = "crdTextBox";
            crdTextBox.Size = new Size(246, 23);
            crdTextBox.TabIndex = 48;
            // 
            // ExpirationDateTxtbox
            // 
            ExpirationDateTxtbox.Location = new Point(38, 439);
            ExpirationDateTxtbox.Name = "ExpirationDateTxtbox";
            ExpirationDateTxtbox.Size = new Size(98, 23);
            ExpirationDateTxtbox.TabIndex = 49;
            // 
            // creditCardLabel
            // 
            creditCardLabel.AutoSize = true;
            creditCardLabel.Location = new Point(35, 358);
            creditCardLabel.Name = "creditCardLabel";
            creditCardLabel.Size = new Size(87, 15);
            creditCardLabel.TabIndex = 50;
            creditCardLabel.Text = "Credit Card no.";
            // 
            // expirationDateLabel
            // 
            expirationDateLabel.AutoSize = true;
            expirationDateLabel.Location = new Point(35, 421);
            expirationDateLabel.Name = "expirationDateLabel";
            expirationDateLabel.Size = new Size(87, 15);
            expirationDateLabel.TabIndex = 51;
            expirationDateLabel.Text = "Expiration Date";
            // 
            // cvcTxtBox
            // 
            cvcTxtBox.Location = new Point(195, 439);
            cvcTxtBox.Name = "cvcTxtBox";
            cvcTxtBox.Size = new Size(88, 23);
            cvcTxtBox.TabIndex = 52;
            // 
            // cvcLabel
            // 
            cvcLabel.AutoSize = true;
            cvcLabel.Location = new Point(195, 421);
            cvcLabel.Name = "cvcLabel";
            cvcLabel.Size = new Size(80, 15);
            cvcLabel.TabIndex = 53;
            cvcLabel.Text = "Security Code";
            // 
            // addRemRoomPanel
            // 
            addRemRoomPanel.BackColor = Color.FromArgb(236, 240, 241);
            addRemRoomPanel.Controls.Add(numeric2);
            addRemRoomPanel.Controls.Add(guestLabel);
            addRemRoomPanel.Controls.Add(resListView);
            addRemRoomPanel.Controls.Add(removeRoomRadioButton);
            addRemRoomPanel.Controls.Add(addRoomRadioButton);
            addRemRoomPanel.Controls.Add(addRoomButton);
            addRemRoomPanel.Controls.Add(numeric1);
            addRemRoomPanel.Controls.Add(numOfRoomsLabel);
            addRemRoomPanel.Controls.Add(roomTypeComboBox);
            addRemRoomPanel.Controls.Add(roomTypeLabel);
            addRemRoomPanel.Location = new Point(643, 101);
            addRemRoomPanel.Margin = new Padding(3, 2, 3, 2);
            addRemRoomPanel.Name = "addRemRoomPanel";
            addRemRoomPanel.Size = new Size(564, 392);
            addRemRoomPanel.TabIndex = 54;
            addRemRoomPanel.Paint += addRemRoomPanel_Paint;
            // 
            // numeric2
            // 
            numeric2.BorderStyle = BorderStyle.FixedSingle;
            numeric2.Location = new Point(261, 267);
            numeric2.Margin = new Padding(3, 2, 3, 2);
            numeric2.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numeric2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeric2.Name = "numeric2";
            numeric2.ReadOnly = true;
            numeric2.Size = new Size(263, 23);
            numeric2.TabIndex = 51;
            numeric2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numeric2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // guestLabel
            // 
            guestLabel.AutoSize = true;
            guestLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            guestLabel.Location = new Point(10, 266);
            guestLabel.Name = "guestLabel";
            guestLabel.Size = new Size(52, 20);
            guestLabel.TabIndex = 49;
            guestLabel.Text = "Adults";
            guestLabel.Visible = false;
            // 
            // resListView
            // 
            resListView.Location = new Point(10, 64);
            resListView.Margin = new Padding(3, 2, 3, 2);
            resListView.Name = "resListView";
            resListView.Size = new Size(537, 92);
            resListView.TabIndex = 46;
            resListView.UseCompatibleStateImageBehavior = false;
            // 
            // removeRoomRadioButton
            // 
            removeRoomRadioButton.AutoSize = true;
            removeRoomRadioButton.Location = new Point(203, 11);
            removeRoomRadioButton.Margin = new Padding(3, 2, 3, 2);
            removeRoomRadioButton.Name = "removeRoomRadioButton";
            removeRoomRadioButton.Size = new Size(103, 19);
            removeRoomRadioButton.TabIndex = 48;
            removeRoomRadioButton.Text = "Remove Room";
            removeRoomRadioButton.UseVisualStyleBackColor = true;
            removeRoomRadioButton.CheckedChanged += removeRoomRadioButton_CheckedChanged;
            // 
            // addRoomRadioButton
            // 
            addRoomRadioButton.AutoSize = true;
            addRoomRadioButton.Location = new Point(10, 12);
            addRoomRadioButton.Margin = new Padding(3, 2, 3, 2);
            addRoomRadioButton.Name = "addRoomRadioButton";
            addRoomRadioButton.Size = new Size(79, 19);
            addRoomRadioButton.TabIndex = 47;
            addRoomRadioButton.Text = "Add room";
            addRoomRadioButton.UseVisualStyleBackColor = true;
            addRoomRadioButton.CheckedChanged += addRoomRadioButton_CheckedChanged;
            // 
            // addRoomButton
            // 
            addRoomButton.Location = new Point(10, 322);
            addRoomButton.Margin = new Padding(3, 2, 3, 2);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(133, 28);
            addRoomButton.TabIndex = 46;
            addRoomButton.Text = "Add Room";
            addRoomButton.UseVisualStyleBackColor = true;
            addRoomButton.Click += addRoomButton_Click;
            // 
            // numeric1
            // 
            numeric1.BorderStyle = BorderStyle.FixedSingle;
            numeric1.Location = new Point(261, 179);
            numeric1.Margin = new Padding(3, 2, 3, 2);
            numeric1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numeric1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeric1.Name = "numeric1";
            numeric1.ReadOnly = true;
            numeric1.Size = new Size(263, 23);
            numeric1.TabIndex = 45;
            numeric1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numeric1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numOfRoomsLabel
            // 
            numOfRoomsLabel.AutoSize = true;
            numOfRoomsLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            numOfRoomsLabel.Location = new Point(10, 178);
            numOfRoomsLabel.Name = "numOfRoomsLabel";
            numOfRoomsLabel.Size = new Size(134, 20);
            numOfRoomsLabel.TabIndex = 44;
            numOfRoomsLabel.Text = "Number of Rooms";
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.BackColor = Color.FromArgb(231, 76, 60);
            roomTypeComboBox.FlatStyle = FlatStyle.Flat;
            roomTypeComboBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeComboBox.ForeColor = Color.White;
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.ItemHeight = 19;
            roomTypeComboBox.Location = new Point(261, 223);
            roomTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            roomTypeComboBox.MinimumSize = new Size(287, 0);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(287, 27);
            roomTypeComboBox.TabIndex = 43;
            roomTypeComboBox.Text = "Select";
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            roomTypeLabel.Location = new Point(10, 224);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(85, 20);
            roomTypeLabel.TabIndex = 42;
            roomTypeLabel.Text = "Room Type";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentLabel.Location = new Point(35, 317);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(109, 17);
            paymentLabel.TabIndex = 55;
            paymentLabel.Text = "Payment Details";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 240, 241);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(checkOut);
            panel3.Controls.Add(checkIn);
            panel3.Location = new Point(340, 317);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 172);
            panel3.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label11.Location = new Point(29, 113);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 51;
            label11.Text = "Check-out Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(26, 15);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 50;
            label2.Text = "Check-in Date";
            // 
            // checkOut
            // 
            checkOut.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOut.Location = new Point(32, 137);
            checkOut.Margin = new Padding(3, 2, 3, 2);
            checkOut.Name = "checkOut";
            checkOut.Size = new Size(222, 23);
            checkOut.TabIndex = 49;
            checkOut.ValueChanged += checkOut_ValueChanged;
            // 
            // checkIn
            // 
            checkIn.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkIn.Location = new Point(29, 44);
            checkIn.Margin = new Padding(3, 2, 3, 2);
            checkIn.Name = "checkIn";
            checkIn.Size = new Size(217, 23);
            checkIn.TabIndex = 48;
            checkIn.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ReservationBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 636);
            Controls.Add(panel3);
            Controls.Add(paymentLabel);
            Controls.Add(addRemRoomPanel);
            Controls.Add(cvcLabel);
            Controls.Add(cvcTxtBox);
            Controls.Add(expirationDateLabel);
            Controls.Add(creditCardLabel);
            Controls.Add(ExpirationDateTxtbox);
            Controls.Add(crdTextBox);
            Controls.Add(label1);
            Controls.Add(AgentRadioButton);
            Controls.Add(GuestRadioButton);
            Controls.Add(streetTextBox);
            Controls.Add(streetLabel);
            Controls.Add(ZipCodetextBox);
            Controls.Add(EmailAddresstextBox);
            Controls.Add(StatetextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(PhonetextBox);
            Controls.Add(CitytextBox);
            Controls.Add(FirstNametextbox);
            Controls.Add(ReservationDetailsLabel);
            Controls.Add(EmailAddressLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(ZipCodeLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(PersonalDetailsLabel);
            Controls.Add(pictureBox2);
            Controls.Add(SubmitButton);
            Controls.Add(ClearButton);
            Controls.Add(ReturnHomeButton1);
            Name = "ReservationBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservationBooking";
            Load += ReservationBooking_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            addRemRoomPanel.ResumeLayout(false);
            addRemRoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnHomeButton1;
        private Button ClearButton;
        private Button SubmitButton;
        private PictureBox pictureBox2;
        private Label PersonalDetailsLabel;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label CityLabel;
        private Label StateLabel;
        private Label ZipCodeLabel;
        private Label PhoneLabel;
        private Label EmailAddressLabel;
        private Label ReservationDetailsLabel;
        private TextBox FirstNametextbox;
        private TextBox CitytextBox;
        private TextBox PhonetextBox;
        private TextBox lastNameTextBox;
        private TextBox StatetextBox;
        private TextBox EmailAddresstextBox;
        private TextBox ZipCodetextBox;
        private Label streetLabel;
        private TextBox streetTextBox;
        private RadioButton GuestRadioButton;
        private RadioButton AgentRadioButton;
        private Label label1;
        private TextBox crdTextBox;
        private TextBox ExpirationDateTxtbox;
        private Label creditCardLabel;
        private Label expirationDateLabel;
        private TextBox cvcTxtBox;
        private Label cvcLabel;
        private Panel addRemRoomPanel;
        private Label guestLabel;
        private ListView resListView;
        private RadioButton removeRoomRadioButton;
        private RadioButton addRoomRadioButton;
        private Button addRoomButton;
        private NumericUpDown numeric1;
        private Label numOfRoomsLabel;
        private ComboBox roomTypeComboBox;
        private Label roomTypeLabel;
        private Label label3;
        private Panel panel3;
        private Label label11;
        private Label label2;
        private DateTimePicker checkOut;
        private DateTimePicker checkIn;
        private NumericUpDown numeric2;
        private Label paymentLabel;
    }
}
namespace PhumlaKamnandi.Presentation;

partial class ChangeReservationForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeReservationForm));
        panel1 = new Panel();
        label6 = new Label();
        panel2 = new Panel();
        ID = new Label();
        contactDetailsLabel = new Label();
        nameLabel = new Label();
        pictureBox1 = new PictureBox();
        cancelButton = new Button();
        submitButton = new Button();
        returnHomeButton = new Button();
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
        panel3 = new Panel();
        label11 = new Label();
        label2 = new Label();
        checkOut = new DateTimePicker();
        checkIn = new DateTimePicker();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        addRemRoomPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numeric2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numeric1).BeginInit();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(137, 12, 12);
        panel1.Controls.Add(label6);
        panel1.Location = new Point(1, 1);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1146, 95);
        panel1.TabIndex = 0;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.ForeColor = SystemColors.ButtonHighlight;
        label6.Location = new Point(26, 30);
        label6.Name = "label6";
        label6.Size = new Size(241, 32);
        label6.TabIndex = 3;
        label6.Text = "Change Reservation";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(60, 99, 130);
        panel2.Controls.Add(ID);
        panel2.Controls.Add(contactDetailsLabel);
        panel2.Controls.Add(nameLabel);
        panel2.Controls.Add(pictureBox1);
        panel2.Location = new Point(894, 96);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(253, 521);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        // 
        // ID
        // 
        ID.AutoSize = true;
        ID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ID.ForeColor = Color.White;
        ID.Location = new Point(35, 186);
        ID.Name = "ID";
        ID.Size = new Size(93, 19);
        ID.TabIndex = 21;
        ID.Text = "refID: 100256";
        // 
        // contactDetailsLabel
        // 
        contactDetailsLabel.AutoSize = true;
        contactDetailsLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        contactDetailsLabel.ForeColor = Color.White;
        contactDetailsLabel.Location = new Point(35, 162);
        contactDetailsLabel.Name = "contactDetailsLabel";
        contactDetailsLabel.Size = new Size(41, 19);
        contactDetailsLabel.TabIndex = 18;
        contactDetailsLabel.Text = "[Sex]";
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        nameLabel.ForeColor = Color.FromArgb(224, 224, 224);
        nameLabel.Location = new Point(35, 136);
        nameLabel.Name = "nameLabel";
        nameLabel.RightToLeft = RightToLeft.Yes;
        nameLabel.Size = new Size(48, 19);
        nameLabel.TabIndex = 17;
        nameLabel.Text = "fname";
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.FromArgb(60, 99, 130);
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(94, 56);
        pictureBox1.Margin = new Padding(3, 2, 3, 2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(54, 42);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(458, 560);
        cancelButton.Margin = new Padding(3, 2, 3, 2);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(133, 28);
        cancelButton.TabIndex = 15;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // submitButton
        // 
        submitButton.BackColor = Color.FromArgb(76, 209, 55);
        submitButton.ForeColor = Color.White;
        submitButton.Location = new Point(702, 560);
        submitButton.Margin = new Padding(0);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(133, 28);
        submitButton.TabIndex = 16;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = false;
        submitButton.Click += submitButton_Click;
        // 
        // returnHomeButton
        // 
        returnHomeButton.Image = (Image)resources.GetObject("returnHomeButton.Image");
        returnHomeButton.Location = new Point(38, 560);
        returnHomeButton.Margin = new Padding(3, 2, 3, 2);
        returnHomeButton.Name = "returnHomeButton";
        returnHomeButton.Size = new Size(132, 27);
        returnHomeButton.TabIndex = 32;
        returnHomeButton.UseVisualStyleBackColor = true;
        returnHomeButton.Click += button3_Click_1;
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
        addRemRoomPanel.Location = new Point(27, 141);
        addRemRoomPanel.Margin = new Padding(3, 2, 3, 2);
        addRemRoomPanel.Name = "addRemRoomPanel";
        addRemRoomPanel.Size = new Size(564, 392);
        addRemRoomPanel.TabIndex = 41;
        addRemRoomPanel.Paint += panel3_Paint;
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
        numeric2.TabIndex = 50;
        numeric2.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numeric2.ValueChanged += numeric2_ValueChanged;
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
        guestLabel.Click += label1_Click_1;
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
        numeric1.ValueChanged += numeric1_ValueChanged;
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
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(236, 240, 241);
        panel3.Controls.Add(label11);
        panel3.Controls.Add(label2);
        panel3.Controls.Add(checkOut);
        panel3.Controls.Add(checkIn);
        panel3.Location = new Point(609, 141);
        panel3.Margin = new Padding(3, 2, 3, 2);
        panel3.Name = "panel3";
        panel3.Size = new Size(259, 172);
        panel3.TabIndex = 51;
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
        checkOut.ValueChanged += checkOutDate_ValueChanged;
        // 
        // checkIn
        // 
        checkIn.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        checkIn.Location = new Point(29, 44);
        checkIn.Margin = new Padding(3, 2, 3, 2);
        checkIn.Name = "checkIn";
        checkIn.Size = new Size(217, 23);
        checkIn.TabIndex = 48;
        checkIn.ValueChanged += checkInDate_ValueChanged;
        // 
        // ChangeReservationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1144, 614);
        Controls.Add(panel3);
        Controls.Add(addRemRoomPanel);
        Controls.Add(returnHomeButton);
        Controls.Add(submitButton);
        Controls.Add(cancelButton);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 2, 3, 2);
        Name = "ChangeReservationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Change Reservation";
        TopMost = true;
        Load += ChangeReservationForm_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        addRemRoomPanel.ResumeLayout(false);
        addRemRoomPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numeric2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numeric1).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label6;
    private Button cancelButton;
    private Button submitButton;
    private Label nameLabel;
    private PictureBox pictureBox1;
    private Label ID;
    private DateTimePicker dateTimePicker2;
    private Button returnHomeButton;
    private Panel addRemRoomPanel;
    private ListView resListView;
    private RadioButton removeRoomRadioButton;
    private RadioButton addRoomRadioButton;
    private Button addRoomButton;
    private NumericUpDown numeric1;
    private Label numOfRoomsLabel;
    private ComboBox roomTypeComboBox;
    private Label roomTypeLabel;
    private Label guestLabel;
    private Panel panel3;
    private Label label11;
    private Label label2;
    private DateTimePicker checkOut;
    private DateTimePicker checkIn;
    private NumericUpDown numeric2;
    private Label contactDetailsLabel;
}

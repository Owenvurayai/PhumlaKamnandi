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
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label5 = new Label();
        pictureBox1 = new PictureBox();
        cancelButton = new Button();
        submitButton = new Button();
        returnHomeButton = new Button();
        addRemRoomPanel = new Panel();
        changeGuestRadioButton = new RadioButton();
        adultsNumComboBox = new ComboBox();
        adultsNumLabel = new Label();
        listView1 = new ListView();
        removeRoomRadioButton = new RadioButton();
        addRoomRadioButton = new RadioButton();
        addRoomButton = new Button();
        numericUpDown1 = new NumericUpDown();
        numOfRoomsLabel = new Label();
        roomTypeComboBox = new ComboBox();
        roomTypeLabel = new Label();
        panel3 = new Panel();
        label11 = new Label();
        label2 = new Label();
        dateTimePicker5 = new DateTimePicker();
        dateTimePicker1 = new DateTimePicker();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        addRemRoomPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
        panel1.Size = new Size(1310, 127);
        panel1.TabIndex = 0;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.ForeColor = SystemColors.ButtonHighlight;
        label6.Location = new Point(30, 40);
        label6.Name = "label6";
        label6.Size = new Size(298, 41);
        label6.TabIndex = 3;
        label6.Text = "Change Reservation";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(60, 99, 130);
        panel2.Controls.Add(label10);
        panel2.Controls.Add(label9);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(pictureBox1);
        panel2.Location = new Point(1022, 128);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(289, 695);
        panel2.TabIndex = 1;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label10.ForeColor = Color.White;
        label10.Location = new Point(40, 327);
        label10.Name = "label10";
        label10.Size = new Size(109, 23);
        label10.TabIndex = 21;
        label10.Text = "refID: 100256";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label9.ForeColor = Color.White;
        label9.Location = new Point(40, 286);
        label9.Name = "label9";
        label9.Size = new Size(39, 23);
        label9.TabIndex = 20;
        label9.Text = "[ID]";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label8.ForeColor = Color.White;
        label8.Location = new Point(40, 251);
        label8.Name = "label8";
        label8.Size = new Size(52, 23);
        label8.TabIndex = 19;
        label8.Text = "[Age]";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label7.ForeColor = Color.White;
        label7.Location = new Point(40, 216);
        label7.Name = "label7";
        label7.Size = new Size(49, 23);
        label7.TabIndex = 18;
        label7.Text = "[Sex]";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(224, 224, 224);
        label5.Location = new Point(40, 181);
        label5.Name = "label5";
        label5.RightToLeft = RightToLeft.Yes;
        label5.Size = new Size(153, 23);
        label5.TabIndex = 17;
        label5.Text = "[Name] [Surname]";
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.FromArgb(60, 99, 130);
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(107, 75);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(62, 56);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(524, 747);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(152, 37);
        cancelButton.TabIndex = 15;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // submitButton
        // 
        submitButton.BackColor = Color.FromArgb(76, 209, 55);
        submitButton.ForeColor = Color.White;
        submitButton.Location = new Point(802, 747);
        submitButton.Margin = new Padding(0);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(152, 37);
        submitButton.TabIndex = 16;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = false;
        // 
        // returnHomeButton
        // 
        returnHomeButton.Image = (Image)resources.GetObject("returnHomeButton.Image");
        returnHomeButton.Location = new Point(43, 747);
        returnHomeButton.Name = "returnHomeButton";
        returnHomeButton.Size = new Size(151, 36);
        returnHomeButton.TabIndex = 32;
        returnHomeButton.UseVisualStyleBackColor = true;
        returnHomeButton.Click += button3_Click_1;
        // 
        // addRemRoomPanel
        // 
        addRemRoomPanel.BackColor = Color.FromArgb(236, 240, 241);
        addRemRoomPanel.Controls.Add(changeGuestRadioButton);
        addRemRoomPanel.Controls.Add(adultsNumComboBox);
        addRemRoomPanel.Controls.Add(adultsNumLabel);
        addRemRoomPanel.Controls.Add(listView1);
        addRemRoomPanel.Controls.Add(removeRoomRadioButton);
        addRemRoomPanel.Controls.Add(addRoomRadioButton);
        addRemRoomPanel.Controls.Add(addRoomButton);
        addRemRoomPanel.Controls.Add(numericUpDown1);
        addRemRoomPanel.Controls.Add(numOfRoomsLabel);
        addRemRoomPanel.Controls.Add(roomTypeComboBox);
        addRemRoomPanel.Controls.Add(roomTypeLabel);
        addRemRoomPanel.Location = new Point(31, 188);
        addRemRoomPanel.Name = "addRemRoomPanel";
        addRemRoomPanel.Size = new Size(645, 522);
        addRemRoomPanel.TabIndex = 41;
        addRemRoomPanel.Paint += panel3_Paint;
        // 
        // changeGuestRadioButton
        // 
        changeGuestRadioButton.AutoSize = true;
        changeGuestRadioButton.Location = new Point(476, 16);
        changeGuestRadioButton.Name = "changeGuestRadioButton";
        changeGuestRadioButton.Size = new Size(149, 24);
        changeGuestRadioButton.TabIndex = 51;
        changeGuestRadioButton.Text = "Number of Guests";
        changeGuestRadioButton.UseVisualStyleBackColor = true;
        changeGuestRadioButton.CheckedChanged += changeGuestRadioButton_CheckedChanged;
        // 
        // adultsNumComboBox
        // 
        adultsNumComboBox.BackColor = Color.FromArgb(231, 76, 60);
        adultsNumComboBox.FlatStyle = FlatStyle.Flat;
        adultsNumComboBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        adultsNumComboBox.ForeColor = Color.White;
        adultsNumComboBox.FormattingEnabled = true;
        adultsNumComboBox.ItemHeight = 23;
        adultsNumComboBox.Location = new Point(298, 354);
        adultsNumComboBox.MinimumSize = new Size(327, 0);
        adultsNumComboBox.Name = "adultsNumComboBox";
        adultsNumComboBox.Size = new Size(327, 31);
        adultsNumComboBox.TabIndex = 50;
        adultsNumComboBox.Text = "Select";
        adultsNumComboBox.Visible = false;
        adultsNumComboBox.SelectedIndexChanged += adultsNumComboBox_SelectedIndexChanged;
        // 
        // adultsNumLabel
        // 
        adultsNumLabel.AutoSize = true;
        adultsNumLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        adultsNumLabel.Location = new Point(12, 355);
        adultsNumLabel.Name = "adultsNumLabel";
        adultsNumLabel.Size = new Size(66, 25);
        adultsNumLabel.TabIndex = 49;
        adultsNumLabel.Text = "Adults";
        adultsNumLabel.Visible = false;
        adultsNumLabel.Click += label1_Click_1;
        // 
        // listView1
        // 
        listView1.Location = new Point(12, 86);
        listView1.Name = "listView1";
        listView1.Size = new Size(613, 121);
        listView1.TabIndex = 46;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // removeRoomRadioButton
        // 
        removeRoomRadioButton.AutoSize = true;
        removeRoomRadioButton.Location = new Point(232, 15);
        removeRoomRadioButton.Name = "removeRoomRadioButton";
        removeRoomRadioButton.Size = new Size(128, 24);
        removeRoomRadioButton.TabIndex = 48;
        removeRoomRadioButton.Text = "Remove Room";
        removeRoomRadioButton.UseVisualStyleBackColor = true;
        removeRoomRadioButton.CheckedChanged += removeRoomRadioButton_CheckedChanged;
        // 
        // addRoomRadioButton
        // 
        addRoomRadioButton.AutoSize = true;
        addRoomRadioButton.Location = new Point(12, 16);
        addRoomRadioButton.Name = "addRoomRadioButton";
        addRoomRadioButton.Size = new Size(98, 24);
        addRoomRadioButton.TabIndex = 47;
        addRoomRadioButton.Text = "Add room";
        addRoomRadioButton.UseVisualStyleBackColor = true;
        addRoomRadioButton.CheckedChanged += addRoomRadioButton_CheckedChanged;
        // 
        // addRoomButton
        // 
        addRoomButton.Location = new Point(12, 429);
        addRoomButton.Name = "addRoomButton";
        addRoomButton.Size = new Size(152, 37);
        addRoomButton.TabIndex = 46;
        addRoomButton.Text = "Add Room";
        addRoomButton.UseVisualStyleBackColor = true;
        addRoomButton.Click += addRoomButton_Click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
        numericUpDown1.Location = new Point(298, 239);
        numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.ReadOnly = true;
        numericUpDown1.Size = new Size(301, 27);
        numericUpDown1.TabIndex = 45;
        numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numOfRoomsLabel
        // 
        numOfRoomsLabel.AutoSize = true;
        numOfRoomsLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        numOfRoomsLabel.Location = new Point(12, 237);
        numOfRoomsLabel.Name = "numOfRoomsLabel";
        numOfRoomsLabel.Size = new Size(165, 25);
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
        roomTypeComboBox.ItemHeight = 23;
        roomTypeComboBox.Location = new Point(298, 297);
        roomTypeComboBox.MinimumSize = new Size(327, 0);
        roomTypeComboBox.Name = "roomTypeComboBox";
        roomTypeComboBox.Size = new Size(327, 31);
        roomTypeComboBox.TabIndex = 43;
        roomTypeComboBox.Text = "Select";
        // 
        // roomTypeLabel
        // 
        roomTypeLabel.AutoSize = true;
        roomTypeLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        roomTypeLabel.Location = new Point(12, 298);
        roomTypeLabel.Name = "roomTypeLabel";
        roomTypeLabel.Size = new Size(105, 25);
        roomTypeLabel.TabIndex = 42;
        roomTypeLabel.Text = "Room Type";
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(236, 240, 241);
        panel3.Controls.Add(label11);
        panel3.Controls.Add(label2);
        panel3.Controls.Add(dateTimePicker5);
        panel3.Controls.Add(dateTimePicker1);
        panel3.Location = new Point(696, 188);
        panel3.Name = "panel3";
        panel3.Size = new Size(296, 230);
        panel3.TabIndex = 51;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label11.Location = new Point(33, 151);
        label11.Name = "label11";
        label11.Size = new Size(139, 25);
        label11.TabIndex = 51;
        label11.Text = "Check-out Date";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label2.Location = new Point(30, 20);
        label2.Name = "label2";
        label2.Size = new Size(126, 25);
        label2.TabIndex = 50;
        label2.Text = "Check-in Date";
        // 
        // dateTimePicker5
        // 
        dateTimePicker5.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker5.Location = new Point(36, 183);
        dateTimePicker5.Name = "dateTimePicker5";
        dateTimePicker5.Size = new Size(253, 27);
        dateTimePicker5.TabIndex = 49;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.Location = new Point(33, 58);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(247, 27);
        dateTimePicker1.TabIndex = 48;
        // 
        // ChangeReservationForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1308, 819);
        Controls.Add(panel3);
        Controls.Add(addRemRoomPanel);
        Controls.Add(returnHomeButton);
        Controls.Add(submitButton);
        Controls.Add(cancelButton);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
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
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
    private Label label5;
    private PictureBox pictureBox1;
    private Label label7;
    private Label label10;
    private Label label9;
    private Label label8;
    private DateTimePicker dateTimePicker2;
    private Button returnHomeButton;
    private Panel addRemRoomPanel;
    private ListView listView1;
    private RadioButton removeRoomRadioButton;
    private RadioButton addRoomRadioButton;
    private Button addRoomButton;
    private NumericUpDown numericUpDown1;
    private Label numOfRoomsLabel;
    private ComboBox roomTypeComboBox;
    private Label roomTypeLabel;
    private ComboBox adultsNumComboBox;
    private Label adultsNumLabel;
    private Panel panel3;
    private Label label11;
    private Label label2;
    private DateTimePicker dateTimePicker5;
    private DateTimePicker dateTimePicker1;
    private RadioButton changeGuestRadioButton;
}

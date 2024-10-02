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
        label1 = new Label();
        richTextBox1 = new RichTextBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        button1 = new Button();
        button2 = new Button();
        dateTimePicker1 = new DateTimePicker();
        numericUpDown1 = new NumericUpDown();
        label11 = new Label();
        dateTimePicker5 = new DateTimePicker();
        label12 = new Label();
        button3 = new Button();
        comboBox1 = new ComboBox();
        comboBox2 = new ComboBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
        label6.Click += label6_Click;
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
        panel2.Location = new Point(1000, 128);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(311, 695);
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
        pictureBox1.Size = new Size(86, 80);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label1.Location = new Point(31, 205);
        label1.Name = "label1";
        label1.Size = new Size(165, 25);
        label1.TabIndex = 2;
        label1.Text = "Number of Rooms";
        label1.Click += label1_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.BackColor = SystemColors.HighlightText;
        richTextBox1.Location = new Point(317, 561);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(637, 136);
        richTextBox1.TabIndex = 7;
        richTextBox1.Text = "";
        richTextBox1.TextChanged += richTextBox1_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label2.Location = new Point(31, 274);
        label2.Name = "label2";
        label2.Size = new Size(126, 25);
        label2.TabIndex = 12;
        label2.Text = "Check-in Date";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label3.Location = new Point(31, 547);
        label3.Name = "label3";
        label3.Size = new Size(182, 25);
        label3.TabIndex = 14;
        label3.Text = "Add Special Request";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label4.Location = new Point(31, 399);
        label4.Name = "label4";
        label4.Size = new Size(105, 25);
        label4.TabIndex = 13;
        label4.Text = "Room Type";
        label4.Click += label4_Click;
        // 
        // button1
        // 
        button1.Location = new Point(495, 748);
        button1.Name = "button1";
        button1.Size = new Size(152, 37);
        button1.TabIndex = 15;
        button1.Text = "Cancel";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(76, 209, 55);
        button2.ForeColor = Color.White;
        button2.Location = new Point(802, 747);
        button2.Margin = new Padding(0);
        button2.Name = "button2";
        button2.Size = new Size(152, 37);
        button2.TabIndex = 16;
        button2.Text = "Submit";
        button2.UseVisualStyleBackColor = false;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.Location = new Point(317, 272);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(301, 27);
        dateTimePicker1.TabIndex = 19;
        // 
        // numericUpDown1
        // 
        numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
        numericUpDown1.Location = new Point(317, 203);
        numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.ReadOnly = true;
        numericUpDown1.Size = new Size(439, 27);
        numericUpDown1.TabIndex = 22;
        numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label11.Location = new Point(31, 328);
        label11.Name = "label11";
        label11.Size = new Size(139, 25);
        label11.TabIndex = 26;
        label11.Text = "Check-out Date";
        // 
        // dateTimePicker5
        // 
        dateTimePicker5.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker5.Location = new Point(317, 327);
        dateTimePicker5.Name = "dateTimePicker5";
        dateTimePicker5.Size = new Size(301, 27);
        dateTimePicker5.TabIndex = 28;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
        label12.Location = new Point(31, 468);
        label12.Name = "label12";
        label12.Size = new Size(94, 25);
        label12.TabIndex = 31;
        label12.Text = "Meal Plan";
        // 
        // button3
        // 
        button3.Image = (Image)resources.GetObject("button3.Image");
        button3.Location = new Point(317, 748);
        button3.Name = "button3";
        button3.Size = new Size(151, 36);
        button3.TabIndex = 32;
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click_1;
        // 
        // comboBox1
        // 
        comboBox1.BackColor = Color.FromArgb(231, 76, 60);
        comboBox1.FlatStyle = FlatStyle.Flat;
        comboBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        comboBox1.ForeColor = Color.White;
        comboBox1.FormattingEnabled = true;
        comboBox1.ItemHeight = 23;
        comboBox1.Items.AddRange(new object[] { "Delux", "Suite" });
        comboBox1.Location = new Point(317, 468);
        comboBox1.MinimumSize = new Size(327, 0);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(327, 31);
        comboBox1.TabIndex = 33;
        comboBox1.Text = "Select";
        // 
        // comboBox2
        // 
        comboBox2.BackColor = Color.FromArgb(231, 76, 60);
        comboBox2.FlatStyle = FlatStyle.Flat;
        comboBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        comboBox2.ForeColor = Color.White;
        comboBox2.FormattingEnabled = true;
        comboBox2.ItemHeight = 23;
        comboBox2.Items.AddRange(new object[] { "Delux", "Suite" });
        comboBox2.Location = new Point(317, 406);
        comboBox2.MinimumSize = new Size(327, 0);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(327, 31);
        comboBox2.TabIndex = 34;
        comboBox2.Text = "Select";
        // 
        // ChangeReservationForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1308, 819);
        Controls.Add(comboBox2);
        Controls.Add(comboBox1);
        Controls.Add(button3);
        Controls.Add(label12);
        Controls.Add(dateTimePicker5);
        Controls.Add(label11);
        Controls.Add(numericUpDown1);
        Controls.Add(dateTimePicker1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label3);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(richTextBox1);
        Controls.Add(label1);
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
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label1;
    private RichTextBox richTextBox1;
    private Label label6;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button button1;
    private Button button2;
    private Label label5;
    private PictureBox pictureBox1;
    private Label label7;
    private Label label10;
    private Label label9;
    private Label label8;
    private DateTimePicker dateTimePicker1;
    private NumericUpDown numericUpDown1;
    private DateTimePicker dateTimePicker2;
    private Label label11;
    private DateTimePicker dateTimePicker5;
    private Label label12;
    private Button button3;
    private ComboBox comboBox1;
    private ComboBox comboBox2;
}

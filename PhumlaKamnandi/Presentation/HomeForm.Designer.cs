namespace PhumlaKamnandi.Presentation;

partial class HomeForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        panel2 = new Panel();
        linkLabel5 = new LinkLabel();
        linkLabel1 = new LinkLabel();
        linkLabel4 = new LinkLabel();
        linkLabel3 = new LinkLabel();
        linkLabel2 = new LinkLabel();
        listView1 = new ListView();
        label6 = new Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(137, 12, 12);
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(-3, -2);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1311, 123);
        panel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(448, 23);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(87, 65);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(541, 42);
        label1.Name = "label1";
        label1.Size = new Size(331, 46);
        label1.TabIndex = 0;
        label1.Text = "Phumlani Kamnandi";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(60, 99, 130);
        panel2.Controls.Add(linkLabel5);
        panel2.Controls.Add(linkLabel1);
        panel2.Controls.Add(linkLabel4);
        panel2.Controls.Add(linkLabel3);
        panel2.Controls.Add(linkLabel2);
        panel2.Location = new Point(-3, 121);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(285, 717);
        panel2.TabIndex = 1;
        // 
        // linkLabel5
        // 
        linkLabel5.AutoSize = true;
        linkLabel5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel5.LinkBehavior = LinkBehavior.NeverUnderline;
        linkLabel5.LinkColor = Color.White;
        linkLabel5.Location = new Point(47, 322);
        linkLabel5.Name = "linkLabel5";
        linkLabel5.Size = new Size(162, 28);
        linkLabel5.TabIndex = 11;
        linkLabel5.TabStop = true;
        linkLabel5.Text = "Generate Report";
        linkLabel5.LinkClicked += linkLabel5_LinkClicked;
        linkLabel5.MouseLeave += linkLabel5_MouseLeave;
        linkLabel5.MouseHover += linkLabel5_MouseHover;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
        linkLabel1.LinkColor = Color.White;
        linkLabel1.Location = new Point(47, 42);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(174, 28);
        linkLabel1.TabIndex = 4;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Make Reservation";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        linkLabel1.MouseLeave += linkLabel1_MouseLeave;
        linkLabel1.MouseHover += linkLabel1_MouseHover;
        // 
        // linkLabel4
        // 
        linkLabel4.AutoSize = true;
        linkLabel4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
        linkLabel4.LinkColor = Color.White;
        linkLabel4.Location = new Point(47, 252);
        linkLabel4.Name = "linkLabel4";
        linkLabel4.Size = new Size(193, 28);
        linkLabel4.TabIndex = 10;
        linkLabel4.TabStop = true;
        linkLabel4.Text = "Change Reservation";
        linkLabel4.LinkClicked += linkLabel4_LinkClicked;
        linkLabel4.MouseLeave += linkLabel4_MouseLeave;
        linkLabel4.MouseHover += linkLabel4_MouseHover;
        // 
        // linkLabel3
        // 
        linkLabel3.AutoSize = true;
        linkLabel3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
        linkLabel3.LinkColor = Color.White;
        linkLabel3.Location = new Point(47, 182);
        linkLabel3.Name = "linkLabel3";
        linkLabel3.Size = new Size(183, 28);
        linkLabel3.TabIndex = 9;
        linkLabel3.TabStop = true;
        linkLabel3.Text = "Cancel Reservation";
        linkLabel3.LinkClicked += linkLabel3_LinkClicked;
        linkLabel3.MouseLeave += linkLabel3_MouseLeave;
        linkLabel3.MouseHover += linkLabel3_MouseHover;
        // 
        // linkLabel2
        // 
        linkLabel2.AutoSize = true;
        linkLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel2.LinkArea = new LinkArea(0, 20);
        linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
        linkLabel2.LinkColor = Color.White;
        linkLabel2.Location = new Point(47, 112);
        linkLabel2.Name = "linkLabel2";
        linkLabel2.Size = new Size(135, 33);
        linkLabel2.TabIndex = 8;
        linkLabel2.TabStop = true;
        linkLabel2.Text = "Make Enquiry";
        linkLabel2.UseCompatibleTextRendering = true;
        linkLabel2.LinkClicked += linkLabel2_LinkClicked;
        linkLabel2.MouseLeave += linkLabel2_MouseLeave;
        linkLabel2.MouseHover += linkLabel2_MouseHover;
        // 
        // listView1
        // 
        listView1.Location = new Point(386, 229);
        listView1.Name = "listView1";
        listView1.Size = new Size(792, 424);
        listView1.TabIndex = 2;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(686, 201);
        label6.Name = "label6";
        label6.Size = new Size(168, 25);
        label6.TabIndex = 3;
        label6.Text = "Expected Check-in";
        // 
        // HomeForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1308, 819);
        Controls.Add(label6);
        Controls.Add(listView1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "HomeForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Home";
        FormClosing += HomeForm_Closing;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private PictureBox pictureBox1;
    private Label label1;
    private Panel panel2;
    private ListView listView1;
    private Label label6;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel5;
    private LinkLabel linkLabel4;
    private LinkLabel linkLabel3;
    private LinkLabel linkLabel2;
}

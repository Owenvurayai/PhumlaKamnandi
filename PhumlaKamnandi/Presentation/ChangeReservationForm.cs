namespace PhumlaKamnandi.Presentation;

public partial class ChangeReservationForm : Form
{
    bool expand;
    roomType roomtypeValue;
    enum roomType { option1, option2, option3, notSelected }

    public ChangeReservationForm()
    {
        InitializeComponent();
        expand = false;
        roomtypeValue = roomType.notSelected;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }



    private void SelectBtn1_Click_1(object sender, EventArgs e)
    {

    }

    private void roomType1_Click(object sender, EventArgs e)
    {

    }

    private void roomType2_Click(object sender, EventArgs e)
    {


    }

    private void roomType3_Click(object sender, EventArgs e)
    {

    }

    private void label12_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        MessageBox.Show("The data entered will be discarded", "Quit");


        this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void ChangeReservationForm_Load(object sender, EventArgs e)
    {

    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        // Go to the Home Page
        if (MessageBox.Show("If you exit now, the data will be discarded", "Go to Homepage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { this.Close(); }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void removeRoomRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        numOfRoomsLabel.Text = "RoomID";
        roomLabel.Visible = false;
        roomTypeComboBox.Visible = false;
        addRoomButton.Text = "Remove";
        addRoomButton.ForeColor = Color.Red;
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void addRoomRadioButton_CheckedChanged(object sender, EventArgs e)
    {
       numOfRoomsLabel.Text = "Number of Rooms";
       roomLabel.Visible = true;
       roomTypeComboBox.Visible = true;
       addRoomButton.Text = "Add Room";
       addRoomButton.ForeColor = Color.Black;
    }
}

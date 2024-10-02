namespace PhumlaKamnandi.Presentation;

public partial class ChangeReservationForm : Form
{
    bool expand;
    roomType roomtypeValue;
    enum roomType { option1, option2, option3, notSelected }
    private FindReservation findReservation;

    public ChangeReservationForm(FindReservation findReservation)
    {
        InitializeComponent();
        expand = false;
        roomtypeValue = roomType.notSelected;
        this.findReservation = findReservation;
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
        //findReservation.Close();
        //this.Close();

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
        roomTypeLabel.Visible = false;
        roomTypeComboBox.Visible = false;
        adultsNumLabel.Visible = false;
        adultsNumComboBox.Visible = false;
        addRoomButton.Text = "Remove";
        addRoomButton.ForeColor = Color.Red;
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void addRoomRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        numOfRoomsLabel.Text = "Number of Rooms";
        roomTypeLabel.Visible = true;
        roomTypeComboBox.Visible = true;
        adultsNumLabel.Visible = false;
        adultsNumComboBox.Visible = false;
        addRoomButton.Text = "Add Room";
        addRoomButton.ForeColor = Color.Black;
    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void changeGuestRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        numOfRoomsLabel.Text = "RoomID";
        roomTypeLabel.Visible = true;
        roomTypeComboBox.Visible = true;
        roomTypeLabel.Text = "Children";

        adultsNumLabel.Visible=true;
        adultsNumComboBox.Visible = true;
        addRoomButton.Text = "modify";
        addRoomButton.ForeColor = Color.Green;
    }
}

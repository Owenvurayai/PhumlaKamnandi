namespace PhumlaKamnandi.Presentation;

public partial class ChangeReservationForm : Form
{
    private FindReservation findReservation;

    public ChangeReservationForm(FindReservation findReservation)
    {
        InitializeComponent();
        this.findReservation = findReservation;
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
        numericUpDown1.Enabled = false;
        numOfRoomsLabel.Text = "RoomID";
        roomTypeLabel.Visible = false;
        roomTypeComboBox.Visible = false;
        adultsNumLabel.Visible = false;
        adultsNumComboBox.Visible = false;
        addRoomButton.Text = "Remove Room";
        addRoomButton.ForeColor = Color.Red;
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void addRoomRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        numericUpDown1.Enabled = true;
        roomTypeComboBox.Items.Clear();
        roomTypeComboBox.Text = "Select";
        roomTypeComboBox.Items.Add("Suite");
        roomTypeComboBox.Items.Add("Single");
        roomTypeComboBox.Items.Add("Double");
        roomTypeComboBox.Items.Add("Deluxe");


        roomTypeLabel.Visible = true;
        roomTypeLabel.Text = "Room Type";
        numOfRoomsLabel.Text = "Number of Rooms";
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
        numericUpDown1.Enabled = false;
        roomTypeComboBox.Items.Clear();
        roomTypeComboBox.Items.Add("1");
        roomTypeComboBox.Items.Add("2");
        roomTypeComboBox.Items.Add("3");
        roomTypeComboBox.Items.Add("4");
        roomTypeComboBox.SelectedIndex = 0;     //currently

        adultsNumComboBox.Items.Clear();
        adultsNumComboBox.Items.Add("1");
        adultsNumComboBox.Items.Add("2");
        adultsNumComboBox.Items.Add("3");
        adultsNumComboBox.Items.Add("4");
        adultsNumComboBox.SelectedIndex = 0;  //currently
        numOfRoomsLabel.Text = "RoomID";
        roomTypeLabel.Visible = true;
        roomTypeComboBox.Visible = true;
        roomTypeLabel.Text = "Children";

        adultsNumLabel.Visible = true;
        adultsNumComboBox.Visible = true;
        addRoomButton.Text = "Modify";
        addRoomButton.ForeColor = Color.Green;
    }

    private void addRoomButton_Click(object sender, EventArgs e)
    {
        // Add the room to the database
        string operation = addRoomButton.Text;

        if (operation.Equals("Add Room"))
        {


        }
        else if (operation.Equals("Remove Room"))
        {


        }
        else if (operation.Equals("Modify"))
        {



        }
    }

    private void adultsNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void submitButton_Click(object sender, EventArgs e)
    {

    }
}

using PhumlaKamnandi.Business;
using PhumlaKamnandi.Data;
using System.Collections.ObjectModel;

namespace PhumlaKamnandi.Presentation;

public partial class ChangeReservationForm : Form
{
    private FindReservation findReservation;
    private Reservation reservation;
    public RoomDB roomDB;

    public ChangeReservationForm(FindReservation findReservation, Reservation reservation, RoomDB roomDB)
    {
        InitializeComponent();
        this.findReservation = findReservation;
        this.reservation = reservation;
        this.roomDB=roomDB;
        label10.Text = reservation.ReservationId;
        
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

            int i = 10;

            bool roomsAvailable=true;
            int noRoomsAvailable=0;
            Collection<Room> desiredRooms = new Collection<Room>();
            Collection<int> oper = new Collection<int>();  // Store the add or edit operation for the rooms 

            for (int numRooms = 0; numRooms < numericUpDown1.Value; numRooms++)
            {
                int[] roomID = roomDB.RoomIdAllocation(Room.GetRoomType(roomTypeComboBox.Text));

                // All rooms of this type are occupied
                if (roomID[0] == -1)
                { break; roomsAvailable = false; }

                //Create a new room and add it to collection
                Room r = new Room(roomID[0], Room.GetRoomType(roomTypeComboBox.Text), Room.OccupancyStatus.Occupied);
                desiredRooms.Add(r);
                noRoomsAvailable++;
                oper.Add(roomID[1]);
                //roomDB.DataSetChange(r, DB.DBOperation.Add);
                //roomDB.UpdateDataSource(r);
                roomDB.Add2Rooms(r);
                reservation.AddRoom(r);
              
            }
            if (roomsAvailable) {
                for (int numRooms = 0; numRooms < desiredRooms.Count; numRooms++) {
                    if (oper[numRooms] == 0)
                    {
                        roomDB.DataSetChange(desiredRooms.ElementAt(numRooms), DB.DBOperation.Add);
                        roomDB.UpdateDataSource(desiredRooms.ElementAt(numRooms));
                    }
                    else {
                        roomDB.DataSetChange(desiredRooms.ElementAt(numRooms), DB.DBOperation.Edit);
                        roomDB.UpdateDataSource(desiredRooms.ElementAt(numRooms));
                    }
                }
            }
            else
            {
                MessageBox.Show("Only " + noRoomsAvailable + " of this type are available.");
                for (int numRooms = 0; numRooms < desiredRooms.Count; numRooms++)
                {
                    
                    reservation.RemoveRoom(desiredRooms.ElementAt(numRooms));
                    roomDB.RemoveRoom(desiredRooms.ElementAt(numRooms));


                }

                }

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

    private void submitButton_Click(object sender, EventArgs e)
    {
        findReservation.reservationDB.DataSetChange(reservation, DB.DBOperation.Edit);
        findReservation.reservationDB.UpdateDataSource(reservation);
    }
}

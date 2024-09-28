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
        if (!expand)
        {
            roomMenuContainer.Height += 54 * 3;
            expand = true;
        }
        else { roomMenuContainer.Height = 54; expand = false; }
    }

    private void roomType1_Click(object sender, EventArgs e)
    {
        if (expand)
        {

            SelectBtn1.Text = roomType1.Text;
            roomtypeValue = roomType.option1;
            roomMenuContainer.Height = 54;
            expand = false;
        }
    }

    private void roomType2_Click(object sender, EventArgs e)
    {

        if (expand)
        {

            SelectBtn1.Text = roomType2.Text;
            roomtypeValue = roomType.option2;
            roomMenuContainer.Height = 54;
            expand = false;
        }
    }

    private void roomType3_Click(object sender, EventArgs e)
    {

        if (expand)
        {

            SelectBtn1.Text = roomType3.Text;
            roomtypeValue = roomType.option3;
            roomMenuContainer.Height = 54;
            expand = false;
        }
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
}

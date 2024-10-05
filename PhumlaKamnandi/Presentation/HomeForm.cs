using System.Reflection.Emit;
using System.Windows.Forms;

using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Presentation;


public partial class HomeForm : Form
{
    Form findReservationForm;
    Form cancelReservationForm;
    Form makeReservationForm;
    Form enquiryForm;
    LoginForm loginForm;
    ReservationDB reservationDB;
    RoomDB roomDB;

    public HomeForm(LoginForm loginForm)
    {
        this.loginForm = loginForm;
        this.reservationDB = new ReservationDB();
        roomDB = new RoomDB();
        InitializeComponent();
    }



    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        makeReservationForm = new ReservationBooking();
        makeReservationForm.ShowDialog();




    }

    public void responsiveLabelHover(LinkLabel l)
    {
        float currentSize = l.Font.Size;
        currentSize = 13.0F;
        l.Font = new Font(l.Font.Name, currentSize,
         l.Font.Style, l.Font.Unit);
        l.Location = new Point(67, l.Location.Y);
    }
    public void responsiveLabelLeave(LinkLabel l)
    {
        float currentSize = l.Font.Size;
        currentSize = 12.0F;
        l.Font = new Font(l.Font.Name, currentSize,
         l.Font.Style, l.Font.Unit);
        l.Location = new Point(47, l.Location.Y);
    }
    private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {


        findReservationForm = new FindReservation(reservationDB,roomDB);
        findReservationForm.ShowDialog();
        //this.Visible = false;


    }

    private void linkLabel4_MouseHover(object sender, EventArgs e)
    {
        responsiveLabelHover(linkLabel4);

    }

    private void linkLabel4_MouseLeave(object sender, EventArgs e)
    {
        responsiveLabelLeave(linkLabel4);
    }

    private void linkLabel5_MouseHover(object sender, EventArgs e)
    {
        responsiveLabelHover(linkLabel5);

    }

    private void linkLabel5_MouseLeave(object sender, EventArgs e)
    {
        responsiveLabelLeave(linkLabel5);
    }

    private void linkLabel1_MouseHover(object sender, EventArgs e)
    {
        responsiveLabelHover(linkLabel1);
    }

    private void linkLabel1_MouseLeave(object sender, EventArgs e)
    {
        responsiveLabelLeave(linkLabel1);
    }

    private void linkLabel2_MouseHover(object sender, EventArgs e)
    {
        responsiveLabelHover(linkLabel2);
    }

    private void linkLabel2_MouseLeave(object sender, EventArgs e)
    {
        responsiveLabelLeave(linkLabel2);
    }

    private void linkLabel3_MouseHover(object sender, EventArgs e)
    {
        responsiveLabelHover(linkLabel3);
    }

    private void linkLabel3_MouseLeave(object sender, EventArgs e)
    {
        responsiveLabelLeave(linkLabel3);
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        enquiryForm = new EnquiryForm(reservationDB);
        enquiryForm.ShowDialog();
        //this.Visible = false;

    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        cancelReservationForm = new CancelReservationFrom(reservationDB);
        cancelReservationForm.ShowDialog();
        //this.Visible = false;

    }

    private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        // we still need to do something about this
    }

    private void HomeForm_Closing(object sender, EventArgs e)
    {
        loginForm.Close();
       

    }
}

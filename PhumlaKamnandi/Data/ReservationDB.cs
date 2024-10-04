using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;
using PhumlaKamnandi.Presentation;

namespace PhumlaKamnandi.Data
{
    internal class ReservationDB:DB
    {
        /**
         * Update the methods of adding a reservation of an Agent to take in a ReservationID
         * */
        #region Data members
        private Collection<Reservation> reservations;
        private RoomController roomController;
        private string table1 = "GuestReservation";
        private string sqlLocal1 = "SELECT * FROM GuestReservation";
        private string table2 = "AgentReservation";
        private string sqlLocal2 = "SELECT * FROM AgentReservation";
        private string table3 = "GuestReservationRooms";
        private string sqlLocal3 = "SELECT * FROM GuestReservationRooms";
        private string table4 = "Room";
        private string sqlLocal4 = "SELECT * FROM Room";
        private string table5 = "Guest";
        private string sqlLocal5 = "SELECT * FROM Guest";
        private string table6 = "Agent";
        private string sqlLocal6 = "SELECT * FROM Agent";
        private string table7 = "Staff";
        private string sqlLoca7 = "SELECT * FROM Staff";
        private string table8 = "Account";
        private string sqlLocal8 = "SELECT * FROM Account";
      
        public Collection<Reservation> Reservations
        {
            get { return reservations; }
        }
        #endregion

        #region Constructors
        public ReservationDB(): base()
        {
            reservations = new Collection<Reservation>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);
            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);
        }


        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Reservation reservation = null;
            List<Room> tempRoom = new List<Room>();
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {

                    string resid = Convert.ToString(myRow["ResID"]).TrimEnd();

                    // Iterationg over the agent/guestRoom table finding the res
                    foreach (DataRow myGuestAgentRow in dsMain.Tables[table+"Room"].Rows)
                    {
                        if (!(myGuestAgentRow.RowState == DataRowState.Deleted)) {
                            
                            if (resid.Equals(Convert.ToString(myGuestAgentRow["ResID"])))
                            {
                                string roomid = Convert.ToString(myGuestAgentRow["RoomID"]);
                                
                                
                                foreach (DataRow roomRow in dsMain.Tables["Room"].Rows)
                                {
                                    if (!(roomRow.RowState == DataRowState.Deleted))
                                    {

                                        if (roomid.Equals(Convert.ToString(roomRow["RoomID"]))) {

                                            string roomtype = Convert.ToString(roomRow["Roomid"]);
                                            Room r= null;

                                            if (roomtype.Equals("Single")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Single, Room.getStatus(Convert.ToString(myGuestAgentRow["RoomType"]))); }
                                            if (roomtype.Equals("Double")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Double, Room.getStatus(Convert.ToString(myGuestAgentRow["RoomType"]))); }
                                            if (roomtype.Equals("Deluxe")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Deluxe, Room.getStatus(Convert.ToString(myGuestAgentRow["RoomType"]))); }
                                            if (roomtype.Equals("Suite")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Suite, Room.getStatus(Convert.ToString(myGuestAgentRow["RoomType"]))); }

                                            tempRoom.Add(r);
                                            
                                        }


                                    }
                                    }
                            }


                        }
                           
                        


                    }
                        if (table == "GuestReservation")
                    {

                        reservation = new Reservation(Convert.ToString(myRow["ResID"]).TrimEnd(),  Convert.ToString(myRow["GuestID"]).TrimEnd(),  Convert.ToDateTime(myRow["CheckInDate"]), Convert.ToDateTime(myRow["CheckOutDate"]),tempRoom,0);
                    }
                  
                    
                  
                }
            }
        }


        #endregion

        #region GuestReservationCRUDMethods
        public void CreateGuestReservation(string ResID, string guestID, DateTime checkIn, DateTime checkOut, int noOfGuests, decimal totalAmount)
        {
            string command = "INSERT INTO GuestReservation (ReservationID, GuestID, CheckInDate, CheckOutDate, NoOfGuests, TotalAmount) VALUES (@ReservationID, @GuestID, @CheckInDate, @CheckOutDate,@NoOfGuests, @TotalAmount)";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", ResID);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@NoOfGuests", noOfGuests);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();

          // Reservations.Add(new Reservation(ResID,guestID,checkIn,checkOut,noOfGuests,totalAmount));
        }

        public DataTable ReadGuestReservation(string guestID)
        {
            string command = "SELECT * FROM GuestReservation WHERE GuestID = @GuestID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateGuestReservation(string reservationID, DateTime checkIn, DateTime checkOut, int noOfGuests, decimal totalAmount)
        {
            string command = "UPDATE GuestReservation SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, NoOfGuests=@NoOfGuests, TotalAmount = @TotalAmount WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@NoOfGuests", noOfGuests);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }

        public void DeleteGuestReservation(string reservationID)
        {
            string command = "DELETE FROM GuestReservation WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }
        #endregion

        #region AgentReservationTable
        public void CreateAgentReservation(string reservationID, string agentID, DateTime checkIn, DateTime checkOut, int noOfGuests, decimal totalAmount)
        {
            string command = "INSERT INTO AgentReservation (ReservationID, AgentID, CheckInDate, CheckOutDate, NoOfGuests, TotalAmount) VALUES (@Reservation, @AgentID, @CheckInDate, @CheckOutDate, @NoOfGuests, @TotalAmount)";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@NoOfGuests", noOfGuests);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }

        public DataTable ReadAgentReservation(string agentID)
        {
            string command = "SELECT * FROM AgentReservation WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateAgentReservation(string reservationID, DateTime checkIn, DateTime checkOut, int noOfGuests, decimal totalAmount)
        {
            string command = "UPDATE AgentReservation SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, NoOfGuests = @NoOfGuests, TotalAmount = @TotalAmount WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@NoOfGuests", noOfGuests);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }

        public void DeleteAgentReservation(string reservationID)
        {
            string command = "DELETE FROM AgentReservation WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }
        #endregion

        #region GuestReservationRoom
        public void CreateGuestReservationRoom(string ResID, string guestID, int roomID)
        {
            string command = "INSERT INTO GuestReservationRoom (ReservationID, GuestID, RoomID) VALUES (@ReservationID, @GuestID, @RoomID)";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", ResID);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }

        public DataTable ReadGuestReservationRoom(string guestID)
        {
            string command = "SELECT * FROM GuestReservationRoom WHERE GuestID = @GuestID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateGuestReservationRoom(string reservationID, string guestID, int roomID)
        {
            string command = "UPDATE GuestReservationRoom SET GuestID = @GuestID, RoomID = @RoomID WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);

            cnMain.Open();

            cnMain.Close();
        }

        public void DeleteGuestReservationRoom(string reservationID)
        {
            string command = "DELETE FROM GuestReservationRoom WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            cnMain.Open();

            cnMain.Close();
        }
        #endregion

        #region AgentReservationRoom
        public void CreateAgentReservationRoom(string reservationID, string agentID, int roomID)
        {
            string command = "INSERT INTO AgentReservationRoom (ReservationID, AgentID, RoomID)";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }

        public DataTable ReadAgentReservationRoom(string agentID)
        {
            string command = "SELECT * FROM AgentReservationRoom WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateAgentReservationRoom(string reservationID, string agentID, int roomID)
        {
            string command = "UPDATE AgentReservationRoom SET AgentID = @AgentID, RoomID = @RoomID WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }

        public void DeleteAgentReservationRoom(string reservationID)
        {
            string command = "DELETE FROM AgentReservationRoom WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, cnMain);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            cnMain.Open();
            sqlCommand.ExecuteNonQuery();
            cnMain.Close();
        }
        #endregion

    }
}

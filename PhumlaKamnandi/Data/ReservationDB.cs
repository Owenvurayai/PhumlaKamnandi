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

namespace PhumlaKamnandi.Data
{
    internal class ReservationDB:DB
    {
        /**
         * Update the methods of adding a reservation of an Agent to take in a ReservationID
         * */
        #region Data members
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        private Collection<Reservation> reservations;
        private string table1 = "Reservation";
        private string sqlLocal1 = "SELECT * FROM Reservation";
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
        }
        #endregion

        #region GuestReservationCRUDMethods
        public void CreateGuestReservation(string ResID, string guestID, int roomID)
        {
            string command = "INSERT INTO GuestReservationRoom (ReservationID, GuestID, RoomID) VALUES (@ReservationID, @GuestID, @RoomID)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", ResID);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadGuestReservationRoom(string guestID)
        {
            string command = "SELECT * FROM GuestReservationRoom WHERE GuestID = @GuestID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateGuestReservationRoom(string reservationID, string guestID, int roomID)
        {
            string command = "UPDATE GuestReservationRoom SET GuestID = @GuestID, RoomID = @RoomID WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);

            sqlConnection.Open();

            sqlConnection.Close();
        }

        public void DeleteGuestReservationRoom(string reservationID)
        {
            string command = "DELETE FROM GuestReservationRoom WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            sqlConnection.Open();

            sqlConnection.Close();
        }
        #endregion

        #region AgentReservationRoom
        public void CreateAgentReservationRoom(string reservationID, string agentID, int roomID)
        {
            string command = "INSERT INTO AgentReservationRoom (ReservationID, AgentID, RoomID)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadAgentReservationRoom(string agentID)
        {
            string command = "SELECT * FROM AgentReservationRoom WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateAgentReservationRoom(string reservationID, string agentID, int roomID)
        {
            string command = "UPDATE AgentReservationRoom SET AgentID = @AgentID, RoomID = @RoomID WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteAgentReservationRoom(string reservationID)
        {
            string command = "DELETE FROM AgentReservationRoom WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion

    }
}

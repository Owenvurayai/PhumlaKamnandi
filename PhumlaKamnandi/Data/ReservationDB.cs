using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Data
{
    internal class ReservationDB
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public ReservationDB(): base()
        {
        
        }

        #region GuestReservationCRUDMethods
        public void CreateGuestReservation(string ResID, string guestID, DateTime checkIn, DateTime checkOut, decimal totalAmount)
        {
            string command = "INSERT INTO GuestReservation (GuestID, CheckInDate, CheckOutDate, TotalAmount) VALUES (@GuestID, @CheckInDate, @CheckOutDate, @TotalAmount)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadGuestReservation(string guestID)
        {
            string command = "SELECT * FROM GuestReservation WHERE GuestID = @GuestID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateGuestReservation(string reservationID, DateTime checkIn, DateTime checkOut, double totalAmount)
        {
            string command = "UPDATE GuestReservation SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, TotalAmount = @TotalAmount WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            sqlConnection.Open();

            sqlConnection.Close();
        }

        public void DeleteGuestReservation(string reservationID)
        {
            string command = "DELETE FROM GuestReservation WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            sqlConnection.Open();

            sqlConnection.Close();
        }
        #endregion

        #region AgentReservationTable
        public void CreateAgentReservation(string agentID, DateTime checkIn, DateTime checkOut, int noOfGuests, double totalAmount)
        {
            string command = "INSERT INTO AgentReservation (AgentID, CheckInDate, CheckOutDate, NoOfGuests, TotalAmount) VALUES (@AgentID, @CheckInDate, @CheckOutDate, @NoOfGuests, @TotalAmount)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@NoOfGuests", noOfGuests);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadAgentReservation(string agentID)
        {
            string command = "SELECT * FROM AgentReservation WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateAgentReservation(string reservationID, DateTime checkIn, DateTime checkOut, int noOfGuests, double totalAmount)
        {
            string command = "UPDATE AgentReservation SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, NoOfGuests = @NoOfGuests, TotalAmount = @TotalAmount WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@CheckInDate", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOutDate", checkOut);
            sqlCommand.Parameters.AddWithValue("@NoOfGuests", noOfGuests);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteAgentReservation(string reservationID)
        {
            string command = "DELETE FROM AgentReservation WHERE ReservationID = @ReservationID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion

        #region Room
        public void CreateRoom(int roomID, double ratePerNight, Room.RoomType roomType)
        {
            string command = "INSERT INTO Room (RoomID, RatePerNight, RoomType) VALUES (@RoomID, @RatePerNight, @RoomType)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            sqlCommand.Parameters.AddWithValue("@RatePerNight", ratePerNight);
            sqlCommand.Parameters.AddWithValue("@RoomType", roomType);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadRoom(int roomID)
        {
            string command = "SELECT * FROM Room WHERE RoomID = @RoomID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateRoom(int roomID, double ratePerNight, Room.RoomType roomType)
        {
            string command = "UPDATE Room SET RatePerNight = @RatePerNight, RoomType = @RoomType WHERE RoomID = @RoomID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            sqlCommand.Parameters.AddWithValue("@RatePerNight", ratePerNight);
            sqlCommand.Parameters.AddWithValue("@RoomType", roomType);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}

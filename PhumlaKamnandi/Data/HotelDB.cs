using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Data
{
    internal class HotelDB
    {
        public HotelDB() { }
        #region GuestTable
/*        public void CreateGuest(string guestID, string reservationID, string name, string email, string address, DateTime dateOfBirth, string phoneNo)
        {
            string command = "INSERT INTO Guest (GuestID, ReservationID, Name, Email, Address, DateOfBirth, PhoneNo) VALUES (@GuestID, @ReservationID, @Name, @Email, @Address, @DateOfBirth, @PhoneNo)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@ReservationID", reservationID);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            sqlCommand.Parameters.AddWithValue("@PhoneNo", phoneNo);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadGuest(string guestID)
        {
            string command = "SELECT * FROM Guest WHERE GuestID = @GuestID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateGuest(string guestID, string name, string email, string address, DateTime dateOfBirth, string phoneNo)
        {
            string command = "UPDATE Guest SET Name = @Name, Email = @Email, Address = @Address, DateOfBirth = @DateOfBirth, PhoneNo = @PhoneNo WHERE GuestID = @GuestID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@GuestID", guestID);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            sqlCommand.Parameters.AddWithValue("@PhoneNo", phoneNo);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }*/

        #endregion

        #region RoomTable
/*        public void CreateRoom(string roomID, double ratePerNight, string roomType)
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

        public DataTable ReadRoom(string roomID)
        {
            string command = "SELECT * FROM Room WHERE RoomID = @RoomID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateRoom(string roomID, double ratePerNight, string roomType)
        {
            string command = "UPDATE Room SET RatePerNight = @RatePerNight, RoomType = @RoomType WHERE RoomID = @RoomID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            sqlCommand.Parameters.AddWithValue("@RatePerNight", ratePerNight);
            sqlCommand.Parameters.AddWithValue("@RoomType", roomType);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }*/

        #endregion

        #region StaffTable
/*        public void CreateStaff(string staffID, string name, string email, string position)
        {
            string command = "INSERT INTO Staff (StaffID, Name, Email, Position) VALUES (@StaffID, @Name, @Email, @Position)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StaffID", staffID);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Position", position);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadStaff(string staffID)
        {
            string command = "SELECT * FROM Staff WHERE StaffID = @StaffID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StaffID", staffID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateStaff(string staffID, string name, string email, string position)
        {
            string command = "UPDATE Staff SET Name = @Name, Email = @Email, Position = @Position WHERE StaffID = @StaffID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StaffID", staffID);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Position", position);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }*/

        #endregion
        #region AgentTable
        /*public void CreateAgent(string agentID, string companyName, string name, string email)
        {
            string command = "INSERT INTO Agent (AgentID, CompanyName, Name, Email) VALUES (@AgentID, @CompanyName, @Name, @Email)";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@CompanyName", companyName);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Email", email);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable ReadAgent(string agentID)
        {
            string command = "SELECT * FROM Agent WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void UpdateAgent(string agentID, string companyName, string name, string email)
        {
            string command = "UPDATE Agent SET CompanyName = @CompanyName, Name = @Name, Email = @Email WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);
            sqlCommand.Parameters.AddWithValue("@CompanyName", companyName);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Email", email);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteAgent(string agentID)
        {
            string command = "DELETE FROM Agent WHERE AgentID = @AgentID";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@AgentID", agentID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
*/
        #endregion
    }
}

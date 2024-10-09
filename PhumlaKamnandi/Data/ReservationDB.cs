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
    public class ReservationDB : DB
    {
        /**
         * Update the methods of adding a reservation of an Agent to take in a ReservationID
         * */
        #region Data members
        private Collection<Reservation> reservations;
        // private RoomController roomController;
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
        private string table9 = "AgentReservationRoom";
        private string sqlLocal9 = "SELECT * FROM AgentReservationRoom";

        public Collection<Reservation> Reservations
        {
            get { return reservations; }
        }
        #endregion

        #region Constructors
        public ReservationDB() : base()
        {
            reservations = new Collection<Reservation>();

            FillDataSet(sqlLocal3, table3);
            //Add2Collection(table3);
            FillDataSet(sqlLocal9, table9);
            //Add2Collection(table9);
            FillDataSet(sqlLocal4, table4);
            //Add2Collection(table4);

            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);

        }

        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Reservation reservation = null;
            List<Room> tempRoom = new List<Room>();
            string roomTable = table;

            if (roomTable.Equals("AgentReservation"))
            {
                roomTable += "Room";
            }
            else
            {
                roomTable += "Rooms";
            }
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {

                    string resid = Convert.ToString(myRow["ResID"]).TrimEnd();

                    // Iterationg over the agent/guestRoom table finding the res
                    foreach (DataRow myGuestAgentRow in dsMain.Tables[roomTable].Rows)
                    {
                        if (!(myGuestAgentRow.RowState == DataRowState.Deleted))
                        {

                            if (resid.Equals(Convert.ToString(myGuestAgentRow["ResID"])))
                            {
                                string roomid = Convert.ToString(myGuestAgentRow["RoomID"]);


                                foreach (DataRow roomRow in dsMain.Tables["Room"].Rows)
                                {
                                    if (!(roomRow.RowState == DataRowState.Deleted))
                                    {

                                        if (roomid.Equals(Convert.ToString(roomRow["RoomID"])))
                                        {

                                            string roomtype = Convert.ToString(roomRow["RoomType"]);
                                            Room r = null;

                                            if (roomtype.Equals("Single")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Single); }
                                            if (roomtype.Equals("Double")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Double); }
                                            if (roomtype.Equals("Deluxe")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Deluxe); }
                                            if (roomtype.Equals("Suite")) { r = new Room(Convert.ToInt16(roomid), Room.RoomType.Suite); }

                                            tempRoom.Add(r);

                                        }


                                    }
                                }
                            }


                        }




                    }

                    if (table.Equals("GuestReservation"))
                    {

                        reservation = new Reservation(Convert.ToString(myRow["ResID"]).TrimEnd(), Convert.ToString(myRow["GuestID"]).TrimEnd(), Convert.ToDateTime(myRow["CheckIn"]), Convert.ToDateTime(myRow["CheckOut"]), tempRoom, 0);

                        reservations.Add(reservation);

                    }
                    else
                    {
                        reservation = new Reservation(Convert.ToString(myRow["ResID"]).TrimEnd(), Convert.ToString(myRow["AgentID"]).TrimEnd(), Convert.ToDateTime(myRow["CheckIn"]), Convert.ToDateTime(myRow["CheckOut"]), tempRoom, 0);

                        reservations.Add(reservation);
                    }




                }
            }
        }


        public void FillRow(DataRow aRow, Reservation resv)
        {

            aRow["ResID"] = resv.ReservationId;

            if (resv.ID.Contains("AGT"))
            {
                aRow["AgentID"] = resv.ID;
            }
            else
            {
                aRow["GuestID"] = resv.ID;
            }

            aRow["CheckIn"] = resv.CheckInDate;
            aRow["CheckOut"] = resv.CheckOutDate;
            aRow["TotalAmount"] = resv.CalculateTotalStayCost();
            aRow["Status"] = resv.Status;



        }



        #endregion

        #region Database Operations CRUD
        //Find the index of the row in dataset
        public int FindRow(Reservation resv, string table)
        {

            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState == DataRowState.Deleted)
                {
                    continue;
                }
                else
                {

                    if (resv.ReservationId == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ResID"]))
                    {
                        rowIndex = returnValue;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }

        // Modifies the Local Dataset
        public void DataSetChange(Reservation resv, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable;

            if (resv.ID.Contains("AGT"))
            {
                dataTable = table2;
            }
            else
            {
                dataTable = table1;
            }


            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, resv);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(resv, dataTable)];
                    FillRow(aRow, resv);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

            }

        }

        #endregion

        #region Build Parameters, Create Commands & Update database

        private void Create_INSERT_Command(Reservation resv)
        {
            //Create the command that must be used to insert values into the Books table..
            if (resv.ID.Contains("AGT"))
            {
                daMain.InsertCommand = new SqlCommand("INSERT into AgentReservation (ResID, AgentID, CheckIn, CheckOut,TotalAmount, Status) VALUES (@ResID, @AgentID, @CheckIn, @CheckOut,@TotalAmount, @Status)", cnMain);

            }
            else
            {
                daMain.InsertCommand = new SqlCommand("INSERT into GuestReservation (ResID, GuestID,CheckIn, CheckOut, TotalAmount, Status ) VALUES (@ResID, @GuestID, @CheckIn, @CheckOut,@TotalAmount, @Status)", cnMain);
            }


            Build_INSERT_Parameters(resv);
        }

        private void Build_INSERT_Parameters(Reservation resv)
        {

            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("ResID", SqlDbType.NVarChar, 15, "ResID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("Original_ResID", SqlDbType.NVarChar, 15, "ResID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            if (resv.ID.Contains("AGT"))
            {
                if (!daMain.InsertCommand.Parameters.Contains("AgentID"))
                {

                    param = new SqlParameter("@AgentID", SqlDbType.NVarChar, 10, "AgentID");//check the original
                    param.SourceVersion = DataRowVersion.Original;
                    daMain.InsertCommand.Parameters.Add(param);

                    param = new SqlParameter("@Original_AgentID", SqlDbType.NVarChar, 10, "AgentID");//check the original
                    param.SourceVersion = DataRowVersion.Original;
                    daMain.InsertCommand.Parameters.Add(param);
                }
            }
            else
            {
                if (!daMain.InsertCommand.Parameters.Contains("GuestID"))
                {
                    param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");//check the original
                    param.SourceVersion = DataRowVersion.Original;
                    daMain.InsertCommand.Parameters.Add(param);

                    param = new SqlParameter("@Original_GuestID", SqlDbType.NVarChar, 10, "GuestID");//check the original
                    param.SourceVersion = DataRowVersion.Original;
                    daMain.InsertCommand.Parameters.Add(param);
                }

            }
            if (!daMain.InsertCommand.Parameters.Contains("CheckIn"))
            {

                param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 15, "CheckIn");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);
            }
            if (!daMain.InsertCommand.Parameters.Contains("CheckOut"))
            {

                param = new SqlParameter("@CheckOut", SqlDbType.DateTime, 15, "CheckOut");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);
            }
            if (!daMain.InsertCommand.Parameters.Contains("TotalAmount"))
            {

                param = new SqlParameter("@TotalAmount", SqlDbType.Decimal, 15, "TotalAmount");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

            }
            if (!daMain.InsertCommand.Parameters.Contains("Status"))
            {

                param = new SqlParameter("@Status", SqlDbType.NVarChar, 15, "Status");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);
            }

            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }



        public bool UpdateDataSource(Reservation resv)
        {
            bool success = true;
            Create_INSERT_Command(resv);
            Create_UPDATE_Command(resv);
            if (resv.ID.Contains("AGT"))
            {
                success = UpdateDataSource(sqlLocal2, table2);

            }
            else
            {
                success = UpdateDataSource(sqlLocal1, table1);
            }


            return success;
        }



        private void Create_UPDATE_Command(Reservation resv)
        {
            if (resv.ID.Contains("AGT"))
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE AgentReservation SET ResID=@Original_ResID, AgentID=@Original_AgentID, CheckIn=@CheckIn, CheckOut=@CheckOut, TotalAmount=@TotalAmount, Status=@Status  " + "WHERE ResID = @Original_ResID", cnMain);

            }
            else
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE GuestReservation SET ResID=@Original_ResID, AgentID=@Original_GuestID,CheckIn=@CheckIn, CheckOut=@CheckOut, TotalAmount=@TotalAmount, Status=@Status  " + "WHERE ResID = @Original_ResID", cnMain);
            }




            Build_INSERT_Parameters(resv);
        }







    }
}
#endregion

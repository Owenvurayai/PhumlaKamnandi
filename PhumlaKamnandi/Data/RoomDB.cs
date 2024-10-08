using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Data
{
    public class RoomDB : DB
    {
        private string table4 = "Room";
        private string sqlLocal4 = "SELECT * FROM Room";
        private Collection<Room> rooms;
        private IEnumerable<Room> OrderedRooms;
        public Collection<Room> Rooms
        {
            get { return rooms; }
        }

        public RoomDB()
            : base()
        {
            rooms = new Collection<Room>();
            FillDataSet(sqlLocal4, table4);
            Add2Collection(table4);
        }

        public void Add2Rooms(Room room)
        {
            rooms.Add(room);
            OrderedRooms = rooms.OrderBy(room => room.RoomNumber);
        }

        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
            OrderedRooms = rooms.OrderBy(room => room.RoomNumber);
        }

        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                rooms.Add(
                    new Room(
                        Convert.ToInt16(myRow["RoomID"]),
                        Room.GetRoomType(Convert.ToString(myRow["RoomType"])),
                        Room.OccupancyStatus.Occupied
                    )
                );
            }
            OrderedRooms = rooms.OrderBy(room => room.RoomNumber);
        }

        // The assuption is that we have a Room database
        public int[] RoomIdAllocation(Room.RoomType rtype)
        {
            Room room = null;
            int roomID1 = -1;
            int roomID2 = -1;

            // Find an entry that is not in the database
            mainLoop2:
            for (int roomNum = 1; roomNum < 401; roomNum++)
            {
                //returns a room object that does not have roomNumber


                switch (rtype)
                {
                    case Room.RoomType.Single:
                        if (roomNum < 100 && !OrderedRooms.Any(r => r.RoomNumber == roomNum))
                            roomID1 = roomNum;
                        break;
                    case Room.RoomType.Double:
                        if (
                            (roomNum >= 100 && roomNum < 200)
                            && !OrderedRooms.Any(r => r.RoomNumber == roomNum)
                        )
                            roomID1 = roomNum;
                        break;
                    case Room.RoomType.Deluxe:
                        if (
                            (roomNum >= 200 && roomNum < 300)
                            && !OrderedRooms.Any(r => r.RoomNumber == roomNum)
                        )
                            roomID1 = roomNum;
                        break;
                    case Room.RoomType.Suite:
                        if (
                            (roomNum >= 300 && roomNum < 400)
                            && !OrderedRooms.Any(r => r.RoomNumber == roomNum)
                        )
                            roomID1 = roomNum;
                        break;
                }
                if (roomID1 != -1)
                    break;
            }

            mainLoop:
            foreach (Room r in OrderedRooms)
            {
                room = r;
                bool exit = false;
                switch (rtype)
                {
                    case Room.RoomType.Single:
                        if (room.occupancyStatus == Room.OccupancyStatus.Availaible)
                            exit = true;
                        break;
                    case Room.RoomType.Double:
                        if (room.occupancyStatus == Room.OccupancyStatus.Availaible)
                            exit = true;
                        break;
                    case Room.RoomType.Deluxe:
                        if (room.occupancyStatus == Room.OccupancyStatus.Availaible)
                            exit = true;
                        break;
                    case Room.RoomType.Suite:
                        if (room.occupancyStatus == Room.OccupancyStatus.Availaible)
                            exit = true;
                        break;

                    default:
                        break;
                }

                if (exit)
                {
                    roomID2 = room.RoomNumber;
                    break;
                }
            }

            //Both not r1 and r2 not negative
            if (roomID2 < roomID1 && (roomID1 != -1 && roomID2 != -1))
            {
                return [roomID2, 1];
            }
            else if (roomID2 >= roomID1 && (roomID1 != -1 && roomID2 != -1))
            {
                return [roomID1, 0];
            }
            else if (roomID1 == -1 && roomID2 != -1)
                return [roomID2, 1];
            else if (roomID2 == -1 && roomID1 != -1)
                return [roomID1, 0];

            return [-1, -1];
        }

        public void FillRow(DataRow aRow, Room r)
        {
            aRow["RoomID"] = r.RoomNumber;
            aRow["RatePerNight"] = r.RatePerNight;
            aRow["RoomType"] = Convert.ToString(r.roomType);
            aRow["Status"] = Convert.ToString(r.occupancyStatus);
        }

        #region Database Operations CRUD
        //Find the index of the row in dataset
        public int FindRow(Room r, string table)
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
                    if (
                        r.RoomNumber
                        == Convert.ToInt16(dsMain.Tables[table].Rows[rowIndex]["RoomID"])
                    )
                    {
                        rowIndex = returnValue;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        public void DataSetChange(Room r, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table4].NewRow();
                    FillRow(aRow, r);
                    dsMain.Tables[table4].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table4].Rows[FindRow(r, table4)];
                    FillRow(aRow, r);
                    //Add to the dataset
                    dsMain.Tables[table4].Rows.Add(aRow);
                    break;
            }
        }

        public bool UpdateDataSource(Room r)
        {
            bool success = true;
            Create_INSERT_Command(r);
            Create_UPDATE_Command(r);

            success = UpdateDataSource(sqlLocal4, table4);
            return success;
        }

        private void Create_INSERT_Command(Room r)
        {
            //Create the command that must be used to insert values into the Books table..

            daMain.InsertCommand = new SqlCommand(
                "INSERT into Room (RoomID, RatePerNight, RoomType, Status) VALUES (@RoomID, @RatePerNight, @RoomType, @Status)",
                cnMain
            );

            Build_INSERT_Parameters(r);
        }

        private void Create_UPDATE_Command(Room r)
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Room SET RatePerNight=@RatePerNight, RoomType=@RoomType, Status=@Status  "
                    + "WHERE RoomID = @Original_RoomID",
                cnMain
            );

            Build_INSERT_Parameters(r);
        }

        private void Build_INSERT_Parameters(Room r)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
           
           
                param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 7, "RoomID"); //check the original
                param.SourceVersion = DataRowVersion.Original;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Original_RoomID", SqlDbType.NVarChar, 7, "RoomID"); //check the original
                param.SourceVersion = DataRowVersion.Original;
                daMain.InsertCommand.Parameters.Add(param);
            

                param = new SqlParameter("@RatePerNight", SqlDbType.Decimal, 15, "RatePerNight");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

         

                param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 15, "RoomType");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);
         
                param = new SqlParameter("@Status", SqlDbType.NVarChar, 15, "Status");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);
       

            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }
    }
}

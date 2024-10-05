using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    public class RoomController
    {
       
        private RoomDB roomDB;
        private List<Room> newRooms;
        private String resID;
        private string ID;
        private Collection<Room> rooms;
        private ReservationController reservationController;
        private List<Room> oldRooms;
        private bool IsGuest;
        // Constructor
      
        private void Initialize()
        {
            roomDB = new RoomDB();
            rooms = roomDB.Rooms;
        }
        public RoomController( List<Room> rooms, string resID, string ID, bool IsGuest)
        {
            Initialize();
            this.newRooms = rooms;//Rooms that are updated
            this.IsGuest = IsGuest;
            this.resID = resID;
            reservationController = new ReservationController();
            this.ID = ID;
            GetOldRooms();
        }
        //get the initial booked rooms
        private void GetOldRooms()
        { 
           Reservation reservation = reservationController.FindReservationById(resID);
           oldRooms = reservation.BookedRooms();//returns the initial booked rooms

        }
        public void UpdateRooms()
        {
            foreach (Room newroom in newRooms)
            {
                //check every room if it is new
                foreach (Room oldroom in oldRooms)
                {
                    if (newroom.RoomNumber == oldroom.RoomNumber)
                    {
                        //nothing to change here
                        continue;
                    }
                    else
                    {
                        //A new room is added
                        //add it into the database
                        //but first check whether what type of a Agent/Guest
                        //SInce we are not deleting the rervation room
                        //we want to make the old room available
                        oldroom.occupancyStatus = Room.OccupancyStatus.Availaible;
                        RoomNumberAssignment.Instance.RemoveRoomNumber(oldroom.RoomNumber);
                        newroom.occupancyStatus = Room.OccupancyStatus.Occupied;
                        /*
                         * Make changes in to the database
                         * */
                        roomDB.DataSetChange(oldroom, DB.DBOperation.Edit);
                        roomDB.DataSetChange(newroom, DB.DBOperation.Add);
                        //update the changes
                        roomDB.UpdateDataSource(oldroom);
                        roomDB.UpdateDataSource(newroom);

                    }
                }
            }
        }
     
        //method to change the status of the room when the reservaation is cancelled
        public void RemoveRooms()
        {
            foreach(Room room in newRooms)
            {
                room.occupancyStatus = Room.OccupancyStatus.Availaible;
                /*
                 * Make changes into the database 
                 * */
                roomDB.DataSetChange(room, DB.DBOperation.Edit);
                roomDB.UpdateDataSource(room);
            }
        }
        

        // Method to find a room by room number
        public Room FindRoomByNumber(int roomNumber)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNumber)
                    return room;
            }
            return null;
        }

      
        

        //Return all the occupied rooms
        public Collection<Room> GetAllOccupiedRooms()
        {
           return rooms;
        }

        //returns total costs of all booked rooms (currently booked rooms)
        public decimal getTotalCost()
        {
            decimal totalCost = 0;
            foreach(Room room in newRooms)
            {
                totalCost += room.RatePerNight;
            }
            return totalCost;
        }


        //get the rates using a room number
        public decimal getRatePerNight(int roomNumber)
        {
            Room room = FindRoomByNumber(roomNumber);
            return room.RatePerNight;
        }

        public string getRoomDetails(int roomNumber)
        {
            Room room = FindRoomByNumber(roomNumber);
            if (room != null)
                return room.getRoomDetails();
            else
                  return "Not found!!!";
        }


        //get all booked rooms details
       public string getAllRoomDetails()
        {
            string results = " ";
            foreach (Room room in rooms)
            {
               results +=room.getRoomDetails();
            }
            return results;
        }
        
    }
}
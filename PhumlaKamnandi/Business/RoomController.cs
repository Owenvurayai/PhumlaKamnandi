using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class RoomController
    {
        // List of Reservations
        private List<Room> rooms;//store the occupied rooms

        // Constructor
        public RoomController()
        {
            rooms = new List<Room>();
        }

        // Method to add a room
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        // Method to find a room by room number
        public Room FindRoomByNumber(int roomNumber)
        {

            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    return room;
                }
            }
            return null;
        }

        // Method to update a room's availability
        public void UpdateRoomAvailability(int roomNumber, string newOccupancyStatus)
        {
            Room room = FindRoomByNumber(roomNumber);
            if(room != null)
              room.UpdateOccupancyStatus(newOccupancyStatus);//Updates the room's availability
        
        }

        public List<Room> GetAllRooms()
        {
            return rooms;
        }

        //returns total costs of all booked rooms
        public decimal getTotalCost()
        {
            decimal totalCost = 0;
            foreach(Room room in rooms)
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

        public void ReplaceExtras(int roomNumber, string otherExtras)
        {
            Room room = FindRoomByNumber(roomNumber);
            if(room != null)
                room.ReplaceExtras(otherExtras);
            
        }

        public void AddNewExtras(int roomNumber, string otherExtras)
        {
            Room room = FindRoomByNumber(roomNumber);
            if (room != null)
                room.AddMoreExtras(otherExtras);

        }

        public string getRoomDetails(int roomNumber)
        {
            Room room = FindRoomByNumber(roomNumber);
            if (room != null)
                return room.getRoomDetails();
            else
                  return "Not found!!!";
        }

        //Method to remove rooms
        public void removeRoom(Room room)
        {
            rooms.Remove(room);
        }

        public string getRoomNumbers()
        {
            string numbers = "";
            
            foreach (Room room in rooms)
            {
                if(rooms.Capacity >1)
                   numbers += room.RoomNumber + ", ";//comma because they are many
                else 
                     numbers += room.RoomNumber;//only 1
            }
            return numbers;
        }

     //   public string getAllRoomDetails()  Not sure about this one
    }
}
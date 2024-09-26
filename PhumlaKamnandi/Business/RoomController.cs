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
        private List<Room> rooms;

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
        public void UpdateRoomAvailability(int roomNumber, String update)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    room.OccupancyStatus = update;//Updates the room's availability

                }
            }
        }
       
    }
}
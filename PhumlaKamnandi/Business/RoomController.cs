using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;
using PhumlaKamnandi.Business;
using static PhumlaKamnandi.Business.Room;
using System.Collections.ObjectModel;

namespace PhumlaKamnandi.Business
{
    public class RoomController
    {
        private HotelDB hotelDB;
        // List of Reservations
        private Collection<Room> rooms;//store the occupied rooms

        // Constructor
        public RoomController()
        {
            hotelDB = new HotelDB();
            rooms = hotelDB.AllRooms;//gets the occupied rooms in the database
        }

        //Add the room in the database
        public void AddRoom(Room room)
        {
            
            //Add the room in the database
            hotelDB.CreateRoom(room.RoomNumber, room.RoomNumber, room.roomType);
            rooms.Add(room);//add in the list too
         
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

        // Method to update a room's availability
        public void UpdateRoomAvailability(int roomNumber, string newOccupancyStatus)
        {
            Room room = FindRoomByNumber(roomNumber);
            if(room != null)
              room.occupancyStatus=Room.getStatus(newOccupancyStatus);//Updates the room's availability
            hotelDB.UpdateRoom(room.RoomNumber, room.RatePerNight, room.roomType);//Updates the availability in the database
        }

        //DO not know about this one, but created another one with return type of string
        public Collection<Room> GetAllRooms()
        {
            return rooms;//all the rooms in the database
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
            hotelDB.DeleteRoom(room.RoomNumber);//remove the room in the database
            rooms.Remove(room);//remove the room in a list
        }


        //Should I keep this one
        public string getRoomNumbers()
        {
            string numbers = "";
            
            foreach (Room room in rooms)
            {
                if(rooms.Count >1)
                   numbers += room.RoomNumber + ", ";//comma because they are many
                else 
                     numbers += room.RoomNumber;//only 1
            }
            return numbers;
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
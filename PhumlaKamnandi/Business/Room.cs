using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Room
    {
        #region properties
        // Properties of the Room class
        public int RoomID { get; private set; }
        public string RoomType { get; private set; }
        public string OccupancyStatus { get; set; }
        public string BedType { get; private set; }
        public decimal RatePerNight { get; private set; }
        public string Extras { get; set; }
        #endregion


        #region constructor
        public Room(int roomID, string occupancyStatus = "Available", string extras = "")
        {
            RoomID = roomID;
            OccupancyStatus = occupancyStatus;
            Extras = extras;

            // Assign room type and bed type based on room number
            AssignRoomTypeAndBed(roomID);
        }
        public Room() {
            RoomID = 0;
            OccupancyStatus = "";
            Extras = "";
        }
        #endregion 
        // Method to assign room type and bed type based on the room number
        private void AssignRoomTypeAndBed(int roomNo)
        {
            if (roomNo >= 1 && roomNo <= 10)
            {
                RoomType = "Single";
                BedType = "Single Bed";
                RatePerNight = 100; // Example rate for single room
            }
            else if (roomNo >= 11 && roomNo <= 20)
            {
                RoomType = "Double";
                BedType = "Double Bed";
                RatePerNight = 150; // Example rate for double room
            }
            else if (roomNo >= 21 && roomNo <= 30)
            {
                RoomType = "Queen";
                BedType = "Queen Bed";
                RatePerNight = 200; // Example rate for queen room
            }
            else if (roomNo >= 31 && roomNo <= 40)
            {
                RoomType = "King";
                BedType = "King Bed";
                RatePerNight = 250; // Example rate for king room
            }
            else if (roomNo >= 41 && roomNo <= 50)
            {
                RoomType = "Triple";
                BedType = "Triple Bed";
                RatePerNight = 300; // Example rate for triple room
            }
            else
            {
                throw new ArgumentException("Invalid room number.");
            }
        }

        // Method to print room details
        public void PrintRoomDetails()
        {
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Bed Type: {BedType}");
            Console.WriteLine($"Occupancy Status: {OccupancyStatus}");
            Console.WriteLine($"Rate Per Night: {RatePerNight}");
            Console.WriteLine($"Extras: {Extras}");
        }

        // Method to update occupancy status
        public void UpdateOccupancyStatus(string newStatus)
        {
            OccupancyStatus = newStatus;
            Console.WriteLine($"Room {RoomID} occupancy status updated to {OccupancyStatus}.");
        }

        // Method to add extras to the room
        public void AddExtras(string additionalExtras)
        {
            Extras += ", " + additionalExtras;
            Console.WriteLine($"Extras for room {RoomID} updated to: {Extras}");
        }
    }
}

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Room
    {

       
        #region properties
        // Properties of the Room class
        public int RoomNumber { get; private set; }
        public RoomType roomType { get; private set; }
        public string OccupancyStatus { get; set; }//Availability
        public decimal RatePerNight { get; private set; }
        public string Extras { get; set; }
        #endregion

        #region RoomTypes
        public enum RoomType
        {
            Single = 0, Double = 1, Suite = 2, Deluxe = 3
        }




        #endregion
        #region constructor
        public Room(int roomNum, RoomType roomtype, string extras)
        {
           // RoomID = roomID;
            RoomNumber = roomNum;
            OccupancyStatus = "Available";
            Extras = extras;
            roomType = roomtype;
            AssignRates();//Assign the rates
         
            
        }
        public Room() {
            RoomNumber = 0;//There is no room Zero in the Hotel
            OccupancyStatus = "";
            Extras = "";
        }
        #endregion 


        /*
         * We assign rates per night according to the room type
         * */
        private void AssignRates()
        {

            //You gents can change the prices
            switch (roomType)
            {
                case RoomType.Single:
                    RatePerNight = 100;
                    break;
                case RoomType.Double:
                    RatePerNight = 250;
                    break;
                case RoomType.Suite:
                    RatePerNight = 500;
                    break;
                case RoomType.Deluxe:
                    RatePerNight = 600;
                    break;
                default:
                    RatePerNight = 0;//no room type choosen
                    break;
               
            }
        }


        // Method to print room details
        public void PrintRoomDetails()
        {
            Console.WriteLine($"Room Type: {roomType.ToString()}");//check this
            Console.WriteLine($"Occupancy Status: {OccupancyStatus}");
            Console.WriteLine($"Rate Per Night: {RatePerNight}");
            Console.WriteLine($"Extras: {Extras}");
        }

        // Method to update occupancy status
        public void UpdateOccupancyStatus(string newStatus)
        {
            OccupancyStatus = newStatus;
            Console.WriteLine($"Room {RoomNumber} occupancy status updated to {OccupancyStatus}.");
        }

        // Method to add extras to the room
        public void AddExtras(string additionalExtras)
        {
            Extras += ", " + additionalExtras;
            Console.WriteLine($"Extras for room {RoomNumber} updated to: {Extras}");
        }
    }
}

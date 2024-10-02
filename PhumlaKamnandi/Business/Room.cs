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
        //public string Extras { get; set; }
        public int MaxOccupancy { get; private set; }//maximum number of people that can stay in the room
        #endregion

        #region RoomTypes
        public enum RoomType
        {
            Single = 0, Double = 1, Suite = 2, Deluxe = 3
        }




        #endregion
        #region constructor
        public Room(int roomNum, RoomType roomtype)
        {
            // RoomID = roomID;
            RoomNumber = roomNum;
            OccupancyStatus = "Available";
          //  Extras = extras;
            roomType = roomtype;
            AssignRates();//Assign the rates


        }
        public Room()
        {
            RoomNumber = 0;//There is no room Zero in the Hotel
            OccupancyStatus = "";
            //Extras = "";
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
                    MaxOccupancy = 2;
                    RatePerNight = 100;
                    break;
                case RoomType.Double:
                    MaxOccupancy = 4;
                    RatePerNight = 250;
                    break;
                case RoomType.Suite:
                    MaxOccupancy = 8;
                    RatePerNight = 500;
                    break;
                case RoomType.Deluxe:
                    MaxOccupancy = 12;//check this
                    RatePerNight = 600;
                    break;
                default:
                    RatePerNight = 0;//no room type choosen
                    MaxOccupancy = 0;//default one
                    break;

            }
        }


        // Method to get room details
        public string getRoomDetails()
        {
            string results = $"RoomNumber: {RoomNumber}, Room Type: {roomType.ToString()}\nOccupancy Status: {OccupancyStatus}\nRate Per Night: {RatePerNight}\n MaxOccupancy: {MaxOccupancy}\n";
            return results;
        }

        // Method to update occupancy status
        public void UpdateOccupancyStatus(string newStatus)
        {
            OccupancyStatus = newStatus;
            //   Console.WriteLine($"Room {RoomNumber} occupancy status updated to {OccupancyStatus}.");
        }

        /*

        // Method to add extras to the room
        public void AddMoreExtras(string additionalExtras)
        {
            Extras += " " + additionalExtras;
            //   Console.WriteLine($"Extras for room {RoomNumber} updated to: {Extras}");
        }

        //Method to change Extras
        public void ReplaceExtras(string newExtras)
        {
            Extras = newExtras;
        }*/
    }
}

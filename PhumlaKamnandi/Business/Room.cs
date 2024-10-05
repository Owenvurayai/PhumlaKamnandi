 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhumlaKamnandi.Business
{
    public class Room
    {


        #region properties
        // Properties of the Room class
        public int RoomNumber { get; private set; }
        public RoomType roomType { get; private set; }
        public OccupancyStatus occupancyStatus { get; set; }//Availability
        public decimal RatePerNight { get; private set; }
        //public string Extras { get; set; }
        public int MaxOccupancy { get; private set; }//maximum number of people that can stay in the room
        #endregion

        #region RoomTypes
        public enum RoomType
        {
            Single = 0, Double = 1, Suite = 2, Deluxe = 3
        }
        public enum OccupancyStatus
        {
            Availaible,Occupied
        }


        public static RoomType GetRoomType(string roomTypeStr)
        {
            if (RoomType.Single.ToString().Equals(roomTypeStr)) return RoomType.Single;
            else if (RoomType.Double.ToString().Equals(roomTypeStr)) return RoomType.Double;
            else if (RoomType.Suite.ToString().Equals(roomTypeStr)) return RoomType.Suite;
            return RoomType.Deluxe;
        }

        #endregion
        #region constructor
        public Room(int roomNumber, RoomType roomtype,OccupancyStatus occupancyStatus)
        {
            RoomNumber = roomNumber;
            this.occupancyStatus=occupancyStatus;
            roomType = roomtype;
            AssignRates();//Assign the rates


        }
     
        public static OccupancyStatus getStatus(string status)
        {
            if (OccupancyStatus.Availaible.ToString().Equals(status)) return OccupancyStatus.Availaible;
            return OccupancyStatus.Occupied;
        }
        #endregion 


        /*
         * We assign rates per night according to the room type
         * */
        private void AssignRates()
        {
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
                    MaxOccupancy = 12;
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
            string results = $"RoomNumber: {RoomNumber}, Room Type: {roomType.ToString()}\nOccupancy Status: {occupancyStatus}\nRate Per Night: {RatePerNight}\n MaxOccupancy: {MaxOccupancy}\n";
            return results;
        }

        

       
    }
}

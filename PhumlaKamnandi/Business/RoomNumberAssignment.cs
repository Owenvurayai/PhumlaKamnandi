using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PhumlaKamnandi.Business.Room;

namespace PhumlaKamnandi.Business
{
    public class RoomNumberAssignment
    {
        private ArrayList assignedRooms = new ArrayList();//Store the Assigned Rooms
        private Random random = new Random();//use it to generate a room number

        public int AssignRoom(RoomType roomType)
        {
            int roomNumber;
            do
            {
                roomNumber = GenerateRoomNumber(roomType);//generate a roomnumber according to the room type
            } while (assignedRooms.Contains(roomNumber)); // check if the generated room number is in the List of the Assigned Rooms

            assignedRooms.Add(roomNumber); // Assign the room number
            return roomNumber;
        }

        private int GenerateRoomNumber(RoomType roomType)//generate a room number according to the room type
        {
            // Logic to generate room numbers based on room type
            switch (roomType)
            {
                //Single Rooms Start at Room Number 1 - 100
                case RoomType.Single:
                    return random.Next(1, 100);
                //Double Rooms Start at Room Number 101 - 200
                case RoomType.Double:
                    return random.Next(200, 300);
                //Suite Rooms Start at Room Number 201 - 300
                case RoomType.Suite:
                    return random.Next(300, 400);
                //Deluxe Rooms Start at Room Number 301 - 400
                case RoomType.Deluxe:
                    return random.Next(400, 500);
                default://throw an error if the entered room type is not 1 of the above 4 types
                    throw new ArgumentException("Room Type does not exist!!");
            }
        }
    }
}
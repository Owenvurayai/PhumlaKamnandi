using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{

    public  class Reservation {
    #region Fields, Getters and Setters


    private string reservationID;
    private string id;
    private DateTime checkoutDate;
    private DateTime checkinDate;
    private decimal totalAmount;
    private int noOfGuests;
    private ReservationStatus status;
    List<Room> rooms;

    public string ReservationId { get { return reservationID; } set { reservationID = value; } }
    //public string GuestType { get; set; }  // Could be 'Guest' or 'Agent'
    public string ID { get { return id; } set { id = value; } }  // The Guest object associated with the reservation
    public int NoOfGuests { get { return noOfGuests; } set { noOfGuests = value; } }
    public ReservationStatus Status  { get { return status; } set { status = value; } }
    public DateTime CheckInDate { get { return checkinDate; } set {checkinDate = value; } }
    public DateTime CheckOutDate { get { return checkoutDate; } set { checkoutDate = value; } }
    public List<Room> _Rooms { get { return rooms; } set { rooms = value; } }



        public enum ReservationStatus
        {
            Booked,
            Cancelled,
            Completed
        }

        #endregion

        #region Constructor
        // Constructor for Guest reservations
        public Reservation(string reservationId, string ID, DateTime checkInDate, DateTime checkOutDate, List<Room> rooms, int noOfGuest)
    {
        ReservationId = reservationId;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        NoOfGuests = noOfGuests;
        _Rooms  = rooms;
        Status = ReservationStatus.Booked;
         totalAmount= CalculateTotalStayCost();
            this.ID = ID;
    }

  
    #endregion

    #region Methods
    // A method to calculate the duration of stay
    public int GetStayDuration() //returns the number of days
    {
        return (CheckOutDate - CheckInDate).Days;
    }

    //Calcualte the total cost of stay
    public decimal CalculateTotalStayCost()
        {
            int numOfNights = GetStayDuration();//in days

            
            decimal rates = 0;
            foreach(Room room in _Rooms)
            {
                rates += room.RatePerNight;
            }
           decimal totalStayCost = rates * numOfNights;
            return totalStayCost;
        }

     
    // A method to display reservation details

     
    public string GetReservationDetails()
    {
            String allRoomNum= "";
            foreach (Room room in _Rooms)
            {
                allRoomNum += Convert.ToString(room.RoomNumber)+" ";
            }
            if (ID.Contains("Gue"))
        {
            return $"Reservation ID: {ReservationId}, Guest ID: {ID}, Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}, Guests: {NoOfGuests}, Rooms: {allRoomNum}\n";
        }
        else
        {
            return $"Reservation ID: {ReservationId}, Agent ID: {ID}, Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}, Guests: {NoOfGuests}, Rooms: {allRoomNum}\n";
        }
       
    } 
    
         //updating the reservation dates 
        public void UpdateDates(DateTime newCheckInDate, DateTime newCheckOutDate)
        {
            // Check if the new dates are valid (for example, check-in must be before check-out)
            if (newCheckInDate >= newCheckOutDate)
            {
                throw new ArgumentException("Check-in date must be before check-out date.");
            }

            CheckInDate = newCheckInDate;
            CheckOutDate = newCheckOutDate;

            //Console.WriteLine($"Reservation dates updated to Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}.");
        }
        // updating the number of guests in the reservation 
        public void UpdateNoOfGuests(int newNoOfGuests)
        {
            if (newNoOfGuests <= 0)
            {
                throw new ArgumentException("Number of guests must be greater than zero.");
            }

            NoOfGuests = newNoOfGuests;
        }
       

        //AddING More rooms to the reservations
        public void AddRoom(Room room)
        {
            _Rooms.Add(room);
        }

        //Remove a rooom from the reservation
        public void RemoveRoom(Room room)
        {
            _Rooms.Remove(room);
        }
       
        public void RescheduleReservation(DateTime newCheckInDate, DateTime newCheckOutDate)
        {
            // This could call the UpdateDates method internally with additional business logic.
            UpdateDates(newCheckInDate, newCheckOutDate);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public  class Reservation {
    #region Properties
    public string ReservationId { get; set; }
    public string GuestType { get; set; }  // Could be 'Guest' or 'Agent'
    public string GuestID { get; set; }  // The Guest object associated with the reservation
    public string AgentID { get; set; }  // The Agent object associated with the reservation
   

    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
   public RoomController RoomController { get; set; }//simple management of the rooms
    public int NoOfGuests { get; set; }
  public ReservationStatus Status { get; private set; }  // New property to track reservation status

        public enum ReservationStatus
        {
            Booked,
            Cancelled,
            Completed
        }

        #endregion

        #region Constructor
        // Constructor for Guest reservations
        public Reservation(string reservationId, string ID, DateTime checkInDate, DateTime checkOutDate, int noOfGuests, RoomController roomsController)
    {
        ReservationId = reservationId;
        
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        NoOfGuests = noOfGuests;
        RoomController = roomsController;
           Status = ReservationStatus.Booked;
            if (ID.Contains("AGT"))
            {
                //  Agent reservation
                GuestType = "Agent";
                AgentID = ID;
            }
            else if (ID.Contains("Gus"))
            {
                //  Guest reservation
                GuestType = "Guest";
                GuestID = ID;
            }
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
            decimal totalStayCost = RoomController.getTotalCost() * numOfNights;
            return totalStayCost;
        }

     
    // A method to display reservation details
    public string GetReservationDetails()
    {

        if (GuestType == "Guest")
        {
            return $"Reservation ID: {ReservationId}, Guest ID: {GuestID}, Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}, Guests: {NoOfGuests}, Rooms: {RoomController.getRoomNumbers()}\n";
        }
        else if (GuestType == "Agent")
        {
            return $"Reservation ID: {ReservationId}, Agent ID: {AgentID}, Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}, Guests: {NoOfGuests}, Rooms: {RoomController.getRoomNumbers()}\n";
        }
        else
        {
            return "Invalid reservation type";
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
            RoomController.AddRoom(room);
        }

        //Remove a rooom from the reservation
        public void RemoveRoom(Room room)
        {
            RoomController.removeRoom(room);
        }
       
        public void RescheduleReservation(DateTime newCheckInDate, DateTime newCheckOutDate)
        {
            // This could call the UpdateDates method internally with additional business logic.
            UpdateDates(newCheckInDate, newCheckOutDate);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public  class Reservation {
    #region Properties
    public int ReservationId { get; set; }
    public string GuestType { get; set; }  // Could be 'Guest' or 'Agent'
    public Guest Guest { get; set; }  // The Guest object associated with the reservation
    public BookingAgent Agent { get; set; }  // The Agent object associated with the reservation
    public int HotelID { get; set; }
        /*string dateString = "7/10/1974 7:10:24 AM";
         DateTime parsedDate = DateTime.Parse(dateString); // Parses the string to a DateTime object
         
        DateTime specificDateTime = new DateTime(2024, 3, 16, 10, 30, 0); // March 16, 2024 at 10:30 AM

         */
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }


    public int NoOfGuests { get; set; }
    public List<int> NoOfRooms { get; set; } // List of room numbers for the reservation
    public string Extras { get; set; } // Any additional services or extras requested
    #endregion

    #region Constructor
    // Constructor for Guest reservations
    public Reservation(int reservationId, Guest guest, int hotelID, DateTime checkInDate, DateTime checkOutDate, int noOfGuests, List<int> noOfRooms, string extras)
    {
        ReservationId = reservationId;
        GuestType = "Guest";
        Guest = guest;
        HotelID = hotelID;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        NoOfGuests = noOfGuests;
        NoOfRooms = noOfRooms;
        Extras = extras;
    }

    // Constructor for Agent reservations
    public Reservation(int reservationId, BookingAgent agent, int hotelID, DateTime checkInDate, DateTime checkOutDate, int noOfGuests, List<int> noOfRooms, string extras)
    {
        ReservationId = reservationId;
        GuestType = "Agent";
        Agent = agent;
        HotelID = hotelID;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        NoOfGuests = noOfGuests;
        NoOfRooms = noOfRooms;
        Extras = extras;
    }
    #endregion

    #region Methods
    // A method to calculate the duration of stay
    public int GetStayDuration()
    {
        return (CheckOutDate - CheckInDate).Days;
    }

     
    // A method to display reservation details
    public string GetReservationDetails()
    {
        if (GuestType == "Guest")
        {
            return $"Reservation ID: {ReservationId}, Guest: {Guest.GetFullName()}, Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}, Guests: {NoOfGuests}, Rooms: {string.Join(", ", NoOfRooms)}, Extras: {Extras}";
        }
        else if (GuestType == "Agent")
        {
            return $"Reservation ID: {ReservationId}, Booking Agent: {Agent.GetFullName()}, Check-in: {CheckInDate.ToShortDateString()}, Check-out: {CheckOutDate.ToShortDateString()}, Guests: {NoOfGuests}, Rooms: {string.Join(", ", NoOfRooms)}, Extras: {Extras}";
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
            //Console.WriteLine($"Number of guests updated to {NoOfGuests}.");
        }
        //updating the number of rooms 
        public void UpdateRooms(List<int> newRooms)
        {
            if (newRooms == null || newRooms.Count == 0)
            {
                throw new ArgumentException("You must select at least one room.");
            }

            NoOfRooms = newRooms;
           // Console.WriteLine($"Rooms updated to: {string.Join(", ", NoOfRooms)}.");
        }
        //update extras
        public void UpdateExtras(string newExtras)
        {
            Extras = newExtras;
            //Console.WriteLine($"Extras updated to: {Extras}");
        }
        /*This method allows updating information for the guest or agent associated with the reservation.
         * For example, if a guest's details change, you can update the object linked to the reservation.
         */
        public void UpdateGuestInfo(Guest updatedGuest)
        {
            Guest = updatedGuest;
            //Console.WriteLine($"Guest information updated for reservation ID: {ReservationId}.");
        }

        public void UpdateAgentInfo(BookingAgent updatedAgent)
        {
            Agent = updatedAgent;
           // Console.WriteLine($"Agent information updated for reservation ID: {ReservationId}.");
        }

        public void RescheduleReservation(DateTime newCheckInDate, DateTime newCheckOutDate)
        {
            // This could call the UpdateDates method internally with additional business logic.
            UpdateDates(newCheckInDate, newCheckOutDate);
        }
        #endregion
    }
}

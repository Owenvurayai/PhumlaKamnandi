using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class ReservationController
    {
        // List of Reservations
        private List<Reservation> reservations;

        // Constructor
        public ReservationController()
        {
            reservations = new List<Reservation>();
        }

        #region Methods
        #region Duplicate of the Reservation class
        /*  // Method to create a reservation
          public Reservation CreateReservation(int reservationId, Guest guest, List<Room> rooms, DateTime checkInDate, DateTime checkOutDate, int noOfGuests, string extras = "")
          {
              // Check if guest already has a reservation
              Reservation existingReservation = FindReservationByGuestId(guest.GuestID);
              if (existingReservation != null)
              {
                  Console.WriteLine($"Guest {guest.Name} already has a reservation.");
                  return null;
              }

              // Create a new reservation
              Reservation newReservation = new Reservation(reservationId, guest.GuestID, rooms, checkInDate, checkOutDate, noOfGuests, extras);
              reservations.Add(newReservation);

              Console.WriteLine("Reservation created successfully.");
              return newReservation;
          }
        */
        #endregion
        #region Add a Reservation into a List
        public void Add2List(Reservation res)
        {
            reservations.Add(res);//adds it into a List
        }
        #endregion
        // Method to update a reservation
        public bool UpdateReservation(int reservationId, List<Room> newRooms, DateTime newCheckInDate, DateTime newCheckOutDate, string newExtras)
        {
            Reservation reservation = FindReservationById(reservationId);

            if (reservation == null)
            {
                Console.WriteLine("Reservation not found.");
                return false;
            }

            // Update reservation details
            reservation.NoOfRooms = newRooms;
            reservation.CheckInDate = newCheckInDate;
            reservation.CheckOutDate = newCheckOutDate;
            reservation.Extras = newExtras;

            //Console.WriteLine("Reservation updated successfully.");
            return true;
        }

        // Method to cancel a reservation
        public bool CancelReservation(int reservationId)
        {
            Reservation reservation = FindReservationById(reservationId);

            if (reservation == null)
            {
                Console.WriteLine("Reservation not found.");
                return false;
            }

            reservations.Remove(reservation);
           // Console.WriteLine("Reservation canceled successfully.");
            return true;
        }

        // Method to retrieve reservation details
        public Reservation FindReservationById(int reservationId)
        {
            /*
             * r => r.ReservationId - it takes each element in the list referrred as r and check its ResevationId
             * */
            return reservations.Find(r => r.ReservationId == reservationId);
        }

        // Method to find reservation by guest ID
        public Reservation FindReservationByGuestId(int guestId)
        {
            return reservations.Find(r => r.GuestID == guestId);
        }

        // Method to display all reservations
        public void DisplayAllReservations()
        {
            if (reservations.Count == 0)
            {
                Console.WriteLine("No reservations found.");
            }

            foreach (var reservation in reservations)
            {
                reservation.GetReservationDetails();
            }
        }

        #endregion
    }
}

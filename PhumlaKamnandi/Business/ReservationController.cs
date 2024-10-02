using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    public class ReservationController
    {
        // List of Reservations
        private Collection<Reservation> reservations;
        private HotelDB hotelDB;
        private ReservationDB reservationDB;

        // Constructor
        public ReservationController()
        {
            reservations = reservationDB.All;
            hotelDB = new HotelDB();
            reservationDB = new ReservationDB();
        }

        #region Methods
        #region Add a Reservation into a List
        public void Add2List(Reservation res, bool IsGuest)
        {
            if (IsGuest)//If it is a Guest
            {
                //add to the database
                reservationDB.CreateGuestReservation(res.ReservationId, res.Guest.GuestID, res.CheckInDate, res.CheckOutDate, res.CalculateTotalStayCost());
                reservations.Add(res);//adds it into a List
            }
            else//An Agent
            {
                //add to the database
              //  reservationDB.CreateAgentReservation(res.ReservationId, res.Agent.AgentID, res.CheckInDate, res.CheckOutDate, res.CalculateTotalStayCost());
                reservations.Add(res);//adds it into a List
            }
           
        }


        public void Remove2List(Reservation res, bool IsGuest)
        {
            if (IsGuest)
            {

            }
            else
            {

            }
            //Delete then Reservation from the database
            
            reservations.Remove(res);
        }
        #endregion
        // Method to update a reservation
        public bool UpdateReservation(string reservationId, RoomController newRooms, DateTime newCheckInDate, DateTime newCheckOutDate)
        {
            Reservation reservation = FindReservationById(reservationId);

            if (reservation == null)
            {
                //Console.WriteLine("Reservation not found.");
                return false;
            }

            // Update reservation details
            reservation.UpdateDates(newCheckInDate, newCheckOutDate);
            reservation.RoomController = newRooms;

            //Console.WriteLine("Reservation updated successfully.");
            return true;
        }

        // Method to cancel a reservation
        public bool CancelReservationByResID(string reservationId)
        {
            Reservation reservation = FindReservationById(reservationId);

            if (reservation == null)
            {
               // Console.WriteLine("Reservation not found.");
                return false;
            }

            reservations.Remove(reservation);
           // Console.WriteLine("Reservation canceled successfully.");
            return true;
        }

        // Method to retrieve reservation details
        public Reservation FindReservationById(string reservationId)
        {
            /*
             * r => r.ReservationId - it takes each element in the list referrred as r and check its ResevationId
             * */
            return reservations.Find(r => r.ReservationId == reservationId);
        }
        
        /*
         * Check this out
        // Method to find reservation by guest ID
        public Reservation FindReservationByGuestId(string guestId)
        {

        */

        /*
         * check this too
        // Method to display all reservations
        public void DisplayAllReservations()
        {
            if (reservations.Count == 0)
            {
               // Console.WriteLine("No reservations found.");
            }

            foreach (var reservation in reservations)
            {
                reservation.GetReservationDetails();
            }
        }
        */
        #endregion
    }
}

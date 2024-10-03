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
       // private HotelDB hotelDB;
        private ReservationDB reservationDB;

        // Constructor
        public ReservationController()
        {
            reservations = reservationDB.Reservations;
          //  hotelDB = new HotelDB();
            reservationDB = new ReservationDB();
        }

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
                 reservationDB.CreateAgentReservation(res.ReservationId, res.Agent.AgentID, res.CheckInDate, res.CheckOutDate, res.NoOfGuests,res.CalculateTotalStayCost());
                reservations.Add(res);//adds it into a List
            }

        }
    }
}
        

   
    


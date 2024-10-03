using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
        private GuestController guestController;
        private RoomController roomController;
        //private A
       private AgentController agentController;
        

        // Constructor
        public ReservationController()
        {
            reservations = reservationDB.Reservations;
            hotelDB = new HotelDB();
            reservationDB = new ReservationDB();
            guestController = new GuestController();
            roomController = new RoomController();
            agentController = new AgentController();
        }

      
        public void Add2List(Reservation res, bool IsGuest)
        {
            if (IsGuest)//If it is a Guest
            {
                //add to the database
                reservationDB.CreateGuestReservation(res.ReservationId, res.GuestID, res.CheckInDate, res.CheckOutDate,res.NoOfGuests, res.CalculateTotalStayCost());
                reservations.Add(res);//adds it into a List
            }
            else//An Agent
            {
                //add to the database
                 reservationDB.CreateAgentReservation(res.ReservationId, res.AgentID, res.CheckInDate, res.CheckOutDate, res.NoOfGuests,res.CalculateTotalStayCost());
                reservations.Add(res);//adds it into a List
            }

        }

       
       public void Remove2List(Reservation res, bool IsGuest)
       {
           if (IsGuest)
           {
                //remove from the database
                reservationDB.DeleteGuestReservation(res.ReservationId);
                //delete from the collection
                reservations.Remove(res);
           }
           else
           {
                //remove from the database
                reservationDB.DeleteAgentReservation(res.ReservationId);
                //delete from the collection
                reservations.Remove(res);
            }
       }
      
       // Method to update a reservation
       public bool UpdateReservation(Reservation res, bool IsGuest)
       {
           int Index = reservations.IndexOf(res);
            if (IsGuest)
            {
                reservationDB.UpdateGuestReservation(res.ReservationId, res.CheckInDate, res.CheckOutDate, res.NoOfGuests, res.CalculateTotalStayCost());
                reservations[Index] = res;
            }
            else if (IsGuest == false)
            {
                reservationDB.UpdateAgentReservation(res.ReservationId, res.CheckInDate, res.CheckOutDate, res.NoOfGuests, res.CalculateTotalStayCost());
                reservations[Index] = res;
            }
           return true;
       }

       // Method to cancel a reservation
       public bool CancelReservationByResID(string reservationId, bool IsGuest)
       {
           Reservation reservation = FindReservationById(reservationId);

            if(reservation!=null)
            {
                if(IsGuest)
                {
                    //Delete the reservation in the GuestReservationTable
                    reservations.Remove(reservation);
                    reservationDB.DeleteGuestReservation(reservationId);
                    //Delete the data of the guest in the Guest Table
                    Guest guest = guestController.FindGuest(reservation.GuestID);
                    guestController.RemoveGuest(guest);
                    //Remove the Room 
                    reservationDB.DeleteGuestReservation(reservationId);


                    return true;
                }
                else if (IsGuest == false)
                {
                    //Delete the reservation in the AgentReservationTable
                    reservations.Remove(reservation);
                    reservationDB.DeleteAgentReservation(reservationId);
                    //Delete the data of the guest in the Agent Table
                    BookingAgent agent = agentController.FindAgent(reservation.AgentID);
                    agentController.RemoveAgent(agent);
                    //Delete the room in the Room Table
                    reservationDB.DeleteAgentReservation(reservationId);
                    return true;
                }
            }
          
           return false;
       }
        //method
        public Collection<Reservation> GetReservations()
        {
            return reservations;
        }


        // Method to retrieve reservation details
        public Reservation FindReservationById(string reservationId)
        {
            foreach (Reservation res in reservations)
            {
                if (res.ReservationId == reservationId)
                {
                    return res;
                }
            }
            return null;


        }

        // Method to get all reservations
        public string DisplayAllReservations()
        {
            string results = "";
            foreach (var reservation in reservations)
            {
                results += reservation.GetReservationDetails();
            }
            return results;
        }

    }
}
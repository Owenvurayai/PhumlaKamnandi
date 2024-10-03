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
       

        // Constructor
        public ReservationController()
        {
            reservations = reservationDB.Reservations;
            hotelDB = new HotelDB();
            reservationDB = new ReservationDB();
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
                reservationDB.UpdateGuestReservation(res.ReservationId, res.CheckInDate, res.CheckOutDate,res.NoOfGuests,res.CalculateTotalStayCost());
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
           Reservation reservation = FindReservationById(reservationId, IsGuest);

            if(reservation!=null)
            {
                if(IsGuest)
                {
                    reservations.Remove(reservation);
                    reservationDB.DeleteGuestReservation(reservationId);
                    return true;
                }
                else if (IsGuest == false)
                {
                    reservations.Remove(reservation);
                    reservationDB.DeleteAgentReservation(reservationId);
                    return true;
                }
            }
          
           return false;
       }



        // Method to retrieve reservation details
        public Reservation FindReservationById(string reservationId, bool IsGuest)
        {
            DataTable dataTable=null;
            Reservation reservation=null;
            if (IsGuest)//Guest
            {
                dataTable = reservationDB.ReadGuestReservation(reservationId);
                //Create a Reservation object from the table data
                DataRow row = dataTable.Rows[0];
                RoomController roomController = new RoomController();
                reservation = new Reservation(reservationId, Convert.ToString(row["GuestID"]), DateTime.Parse(Convert.ToString(row["CheckInDate"])), DateTime.Parse(Convert.ToString(row["CheckOutDate"])),int.Parse(Convert.ToString(row["NoOfGuests"])), roomController);

            }
            else//Agent 
            {
                dataTable = reservationDB.ReadAgentReservation(reservationId);
                //Create a Reservation object from the table data
                DataRow row = dataTable.Rows[0];
                RoomController roomController = new RoomController();
                reservation = new Reservation(reservationId, Convert.ToString(row["GuestID"]), DateTime.Parse(Convert.ToString(row["CheckInDate"])), DateTime.Parse(Convert.ToString(row["CheckOutDate"])), int.Parse(Convert.ToString(row["NoOfGuests"])), roomController);

            }
            return reservation;
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
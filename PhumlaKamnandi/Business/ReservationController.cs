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
        private ReservationDB resDB;
        private RoomController roomController;

        // Constructor
        public ReservationController()
        {
            reservations = resDB.Reservations;
            resDB = new ReservationDB();
        }
        #region Updating into the DB
        public void DataMaintenance(string reservationID, string ID, DateTime checkInDate, DateTime checkOutDate, List<Room> rooms, int noOfGuest, DB.DBOperation dBOperation)
        {
           
            //Create a reservation object
          //  string reservationID = ReservationIDAssignment.instance.GenerateReservationID();
            Reservation reservation = new Reservation(reservationID, ID, checkInDate, checkOutDate, rooms, noOfGuest);

            

            //Store the index of the Reservation that must be Added/Changed/Deleted
            int index = 0;
            //Need to know which Table we are supposed to work with between
            //Agent and A guEST
            //Use DataSetChange in the DB
            resDB.DataSetChange(reservation, dBOperation);
            //Check which operation is being done
            switch (dBOperation)
            {
                //Create a Reservation
                case DB.DBOperation.Add:
                    if (reservation.ID.Contains("AGT"))
                    {
                        
                        //Add the Reservation to the Reservation Table
                        resDB.DataSetChange(reservation, dBOperation);
                        //pushing the changes in to the database
                        resDB.UpdateDataSource(reservation);
                        reservations.Add(reservation);
                        //Change in the Room Table
                        roomController = new RoomController(rooms, reservationID, ID, false);
                        roomController.UpdateRooms();
                        //Deal with the changes into the database

                    }
                    else
                    {
                        //Add the Reservation to the Reservation Table
                        resDB.DataSetChange(reservation, dBOperation);
                        //pushing the changes in to the database
                        resDB.UpdateDataSource(reservation);
                        reservations.Add(reservation);
                        //Change in the Room Table
                        roomController = new RoomController( rooms, reservationID, ID, true);
                        //Deals with the Room changes(Room DB)
                        roomController.UpdateRooms();
                    }
                    break;
                case DB.DBOperation.Edit:
                    if (reservation.ID.Contains("AGT"))
                    {
                        //Add the Reservation to the Reservation Table
                        resDB.DataSetChange(reservation, dBOperation);
                        //pushing the changes in to the database
                        resDB.UpdateDataSource(reservation);
                        index = FindIndex(reservationID);
                        reservations[index] = reservation;
                        //Change in the Room Table
                        roomController = new RoomController( rooms, reservationID, ID, true);
                        //Deals with the Room changes
                        roomController.UpdateRooms();
                    }
                    else
                    {
                        //Add the Reservation to the Reservation Table
                        resDB.DataSetChange(reservation, dBOperation);
                        //pushing the changes in to the database
                        resDB.UpdateDataSource(reservation);
                        index = FindIndex(reservationID);
                        reservations[index] = reservation;
                        //Change in the Room Table
                        roomController = new RoomController(rooms, reservationID, ID, true);
                        //Deals with the Room changes
                        roomController.UpdateRooms();
                    }

                    break;

                case DB.DBOperation.Delete:
                    //We update, we do not delete, we change the status
                    if (reservation.ID.Contains("AGT"))
                    {
                        //Add the Reservation to the Reservation Table
                        reservation = ChangeStatus(reservation.ReservationId);
                        resDB.DataSetChange(reservation, dBOperation);
                        //pushing the changes in to the database
                        resDB.UpdateDataSource(reservation);
                        index = FindIndex(reservationID);
                        reservations.Remove(reservations[index]);
                        //Change in the Room Table
                        roomController = new RoomController(rooms, reservationID, ID, true);
                        //Deals with the Room changes
                        roomController.RemoveRooms();

                    }
                    else
                    {
                        //Add the Reservation to the Reservation Table
                        reservation = ChangeStatus(reservation.ReservationId);
                        resDB.DataSetChange(reservation, dBOperation);
                        //pushing the changes in to the database
                        resDB.UpdateDataSource(reservation);
                        index = FindIndex(reservationID);
                        reservations.Remove(reservations[index]);
                        //Change in the Room Table
                        roomController = new RoomController(rooms, reservationID, ID, true);
                        //Deals with the Room changes
                        roomController.RemoveRooms();
                    }
                    ReservationIDAssignment.instance.RemoveRes(reservationID);//Deletes the generated reservationID from the ArrayList
                    break;
            

            }
        }

      
        #endregion

        public Reservation ChangeStatus(string resID)
        {
            Reservation reservation = FindReservationById(resID);
            reservation.Status = Reservation.ReservationStatus.Cancelled;
            return reservation;
        }


        //method
        public Collection<Reservation> AllReservations()
        {
            return reservations;
        }

        public string DisplayReservation(string res)
        {
            Reservation reservation = FindReservationById(res);
            return reservation.GetReservationDetails();
        }

        // Method to retrieve reservation details
        public Reservation FindReservationById(string reservationId)
        {
            int index = 0;
            //Check if the first Reservation matched with the one that is wanted
            bool found = (reservations[index].ReservationId == reservationId);
            //We will iterate through all the Reservation Collection
            int count = reservations.Count;
            //iterate while the wanted one is not found
            //Keep on checking while it is not found and there are still elements in the collection
            while(!(found) && (index < reservations.Count - 1))
            {
                index++;
                found= (reservations[index].ReservationId==reservationId);
            }
            return reservations[index];

        }

        //Find the index of the Rersevation in the collection that must be changed
        public int FindIndex(string resID)
        {
            int counter = 0;
            //Check if the first resID in the Collection matches the one that is needed
            bool found = (resID == reservations[counter].ReservationId);
            //Iterate over the collection
            while(!found && (counter < reservations.Count - 1))
            {
                counter++;  
                found = (resID== reservations[counter].ReservationId);

            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
     

    }
}
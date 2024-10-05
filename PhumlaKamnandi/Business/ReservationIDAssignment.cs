using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class ReservationIDAssignment
    {
        // The static instance of the class
        private static readonly ReservationIDAssignment Instance = new ReservationIDAssignment();

        private int counter = 1;//Icnrement this number to make the ID unique
        private ArrayList assignedReservationIDs = new ArrayList();//Store the number of generated IDs

        // Private constructor to prevent instantiation
        private ReservationIDAssignment() { }


        // Public static property to access the instance
        public static ReservationIDAssignment instance
        {
            get
            {
                return Instance;
            }
        }
        public string GenerateReservationID()
        {
            string reservationID = "ReS" + counter++;//resID= ReS1, ReS2, etc...
            assignedReservationIDs.Add(reservationID);//add the generated ID into the List
            return reservationID;
        }

        public void RemoveRes(string resID)
        {
            assignedReservationIDs.Remove(resID);
        }
    }
}

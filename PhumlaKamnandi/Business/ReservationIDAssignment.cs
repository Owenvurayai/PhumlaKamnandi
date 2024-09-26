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
        private int counter = 1;//Icnrement this number to make the ID unique
        private ArrayList assignedReservationIDs = new ArrayList();//Store the number of generated IDs

        public string GenerateReservationID()
        {
            string reservationID = "ReS" + counter++;//resID= ReS1, ReS2, etc...
            assignedReservationIDs.Add(reservationID);//add the generated ID into the List
            return reservationID;
        }
    }
}

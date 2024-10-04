using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    public class AgentReservationRoomController
    {
        private ReservationDB reservationDB;
        private Collection<Room> rooms;

        public AgentReservationRoomController()
        {
            reservationDB = new ReservationDB();
            
        }


    }
}

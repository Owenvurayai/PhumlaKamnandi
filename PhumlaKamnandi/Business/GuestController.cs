using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    public class GuestController
    {
        List<Guest> guests;
        public GuestController()
        {
            guests = new List<Guest>(); 
        }

        public void AddGuest(Guest guest)
        {
            guests.Add(guest);
        }

        public List<Guest> GetGuests()
        {
           return guests;
        }

        public Guest FindGuest(string id)
        {
            foreach (Guest guest in guests)
            {
                if(guest.GuestID.Equals(id))
                    return guest;
            }
            return null;
        }

        public void UpdatePaymentDetails(string id, int creditCardNo, string SecurityCode, int CVC)
        {
            Guest guest = FindGuest(id);
            guest.UpdatePaymentDetails(creditCardNo, SecurityCode, CVC);    
        }

        public void UpdateEmail(string id, string newEmail)
        {
            Guest guest = FindGuest(id);
            guest.UpdateEmail(newEmail);
        }

        public string getGuestDetails(string id)
        {
            Guest guest = FindGuest(id);
            return guest.GetGuestDetails();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    public class GuestController
    {
        private Collection<Guest> guests;
        private HotelDB hotelDB;

        public GuestController()
        {
            hotelDB = new HotelDB();
            guests = hotelDB.AllGuests;
            
        }

        public void AddGuest(Guest guest)
        {
            guests.Add(guest);
            hotelDB.CreateGuest(guest.GuestID, guest.FirstName + " " + guest.LastName, guest.Email, guest.Address, guest.ContactDetails);
        }

        public void RemoveGuest(Guest guest)
        {
            guests.Remove(guest);
            hotelDB.DeleteGuest(guest.GuestID);
        }
        public Collection<Guest> GetGuests()
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
            hotelDB.UpdateGuest(guest.GuestID, guest.FirstName + " " + guest.LastName, guest.Email, guest.Address, guest.ContactDetails);
            int index = guests.IndexOf(guest);
            guests[index] = guest;
        }

        public void UpdateEmail(string id, string newEmail)
        {
            Guest guest = FindGuest(id);
            guest.UpdateEmail(newEmail);
            hotelDB.UpdateGuest(guest.GuestID, guest.FirstName + " " + guest.LastName, guest.Email, guest.Address, guest.ContactDetails);
            int index = guests.IndexOf(guest);
            guests[index] = guest;
        }

        public string getGuestDetails(string id)
        {
            Guest guest = FindGuest(id);
            return guest.GetGuestDetails();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Guest : Person
    {
        #region Properties
        public string CreditCardNo { get; set; }
        public string Preferences { get; set; }

        public string GuestID { get; set; }

        #endregion

       
        #region constructor
        public Guest(String FName, String LName, String Phone , String Address ,String crdCard, String Prf, String GstID)
          : base(FName,LName,Phone,Address)
        {
            CreditCardNo = crdCard;
            Preferences = Prf;
            GuestID = GstID;
        }

        public Guest() :base() {
            CreditCardNo = "";
            Preferences = "";
            GuestID = "";

        }
        #endregion

        #region Method
        public void UpdatePreferences(string preferences)
        {
            Preferences = preferences;
        }
        public void UpdateCreditCardNo(string creditCardNo) {
            CreditCardNo = creditCardNo;  
        }
        public string GetGuestDetails()
        {
            return $"{GetFullName()}, CreditCardNo: {CreditCardNo }, Preferences: {Preferences}";
        }
        #endregion
    }
}
    


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
        public string CardNo { get; set; }
        public string SecurityDate {  get; set; }
        public int CVC {  get; set; }
        public string Preferences { get; set; }

        public string GuestID { get; set; }

        #endregion

       
        #region constructor
        public Guest(String FName, String LName, String Phone , String Address ,String crdCard,string SecurityDate, int CVC, String Prf, String GstID)
          : base(FName,LName,Phone,Address)
        {
            CardNo = crdCard;
            this.SecurityDate = SecurityDate;
            this.CVC = CVC;
            Preferences = Prf;
            GuestID = GstID;
        }

        public Guest() :base() {
            CardNo = "";
            Preferences = "";
            GuestID = "";

        }
        #endregion

        #region Method
        public void UpdatePreferences(string preferences)
        {
            Preferences = preferences;
        }
        public void UpdatePaymentDetails(string creditCardNo, string SecurityCode, int CVC) {
            CardNo = creditCardNo; 
            this.SecurityDate= SecurityCode;
            this.CVC = CVC;
        }
        public string GetGuestDetails()
        {
            return $"{GetFullName()}, CreditCardNo: {CardNo }, Security Date: {SecurityDate}, CVC: {CVC.ToString()} Preferences: {Preferences}";
        }
        #endregion
    }
}
    


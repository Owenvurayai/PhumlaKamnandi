using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Guest : Person
    {
        #region Properties
        public int CardNo { get; set; }
        public string ExpirationDate {  get; set; }
        public int CVC {  get; set; }
        public string GuestID { get; set; }
        public string Email { get; set; }

        #endregion

       
        #region constructor
        public Guest(String GstID, String FName, String LName, String Phone , String Address ,string Email, int crdCard,string SecurityDate, int CVC)
          : base(FName,LName,Phone,Address)
        {
            CardNo = crdCard;
            this.ExpirationDate = SecurityDate;
            this.CVC = CVC;
            this.Email = Email;
            GuestID = GstID;
        }

        public Guest() :base() {
            CardNo = -1;
            GuestID = "";
            Email = "";//create a method to change this

        }
        #endregion

        #region Method
        public void UpdateEmail(string newEmail)
        {
           Email = newEmail;
        }
        public void UpdatePaymentDetails(int creditCardNo, string SecurityCode, int CVC) {
            CardNo = creditCardNo; 
            this.ExpirationDate = SecurityCode;
            this.CVC = CVC;
        }
        public string GetGuestDetails()
        {
            return $"{GetFullName()}, CreditCardNo: {CardNo }, Security Date: {ExpirationDate}, CVC: {CVC.ToString()} Email: {Email}";
        }
        #endregion
    }
}
    


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
        public string ReservationID { get;set; }
        #endregion

       
        #region constructor
        public Guest(String GstID,string resID, string FName, String LName, String Phone , String Address ,string Email, int crdCard,string SecurityDate, int CVC)
          : base(FName,LName,Email, Phone,Address)
        {
            ReservationID = resID;
            CardNo = crdCard;
            this.ExpirationDate = SecurityDate;
            this.CVC = CVC;
            GuestID = GstID;
        }
        public Guest(String GstID, string resID, string FName, String LName, String Phone, String Address, string Email): base(FName, LName, Email, Phone, Address)
        {
            ReservationID = resID;
            GuestID = GstID;
        }

        public Guest() :base() {
            CardNo = -1;
            GuestID = "";
            Email = "";//create a method to change this
            ReservationID = "";
        }
        #endregion

        #region Method
       
        public void UpdatePaymentDetails(int creditCardNo, string SecurityCode, int CVC) {
            CardNo = creditCardNo; 
            this.ExpirationDate = SecurityCode;
            this.CVC = CVC;
        }
        public string GetGuestDetails()
        {
            return $"Name: {GetFullName()}, Reservation ID: {ReservationID}, CreditCardNo: {CardNo }, Security Date: {ExpirationDate}, CVC: {CVC.ToString()} Email: {Email}";
        }
        #endregion
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class BookingAgent : Person
    {
        #region Properties
        public string AgentID { get; set; }
        public String CompanyName { get; set; }
         
        public int NoOfGuest { get; set; }
        #endregion
        #region Constructor
        public BookingAgent( String FName, String LName, String Phone, String Address,String agentID,String companyName, int NoOfGuest)
         : base( FName, LName, Phone, Address)
        {
            AgentID = agentID;
            CompanyName = companyName;
            NoOfGuest = NoOfGuest;
        }

        public BookingAgent() : base() {

            AgentID = "";
            CompanyName = "";
            NoOfGuest = 0;
        }
        #endregion
        #region Methods
        public void UpdateCompanyName(String companyName) {
            CompanyName = companyName;
        }
        public string GetBookingAgentDetails()
        {
            return $"{GetFullName()}, CompanyName: {CompanyName}, NoOfGuest: {NoOfGuest}%";
        }
        #endregion
    }
}

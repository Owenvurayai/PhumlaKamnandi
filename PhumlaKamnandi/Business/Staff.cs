using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Staff : Person
    {
        #region Properties
        public string JobTitle { get; set; }
        public String EmployeeID { get; set; }
        #endregion


        #region constructor 
        public Staff( String FName, String LName, String Phone, String Address, String JobtTitle , String EmpId)
         : base(FName, LName, Phone, Address)
        {
            JobTitle = JobtTitle;
            EmployeeID = EmpId;
        }

        #endregion

        #region Methods
        /*
         * CHeck this out
        public string GetStaffDetails()
        {
           // return $"{GetFullName()}\nJob Title: {JobTitle}\nSalary: {Salary}\nShift: {ShiftSchedule}";
        }*/
        #endregion
    }
}

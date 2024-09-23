﻿using System;
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
        public Staff(int ID, String FName, String LName, String Phone, String Address, String JobtTitle, String , String EmpId)
         : base(ID, FName, LName, Phone, Address)
        {
            JobTitle = JobtTitle;
            EmployeeID = EmpId;
        }

        #endregion

        #region Methods
        public string GetStaffDetails()
        {
            return $"{GetFullName()}, Job Title: {JobTitle}, Salary: {Salary}, Shift: {ShiftSchedule}";
        }
        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi
{
        public class Person
        {
            #region Properties
            public int PersonID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ContactDetails { get; set; }
            public string Address { get; set; }
        public string Email { get; set; }
        #endregion
        #region Constructor
        public Person(String FName , String LName,String email, String Phone, String Address) {

            Email = email;
            FirstName = FName;
            LastName = LName;
            ContactDetails = Phone;
            Address = Address;
        }

        public Person() {
            PersonID = 0;
            FirstName = "";
            LastName = "";
            ContactDetails = "";
            Address = "";

        }
           
        #endregion
        #region Methods
        public virtual string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }
        public void UpdateEmail(string newEmail)
        {
            Email = newEmail;
        }
        public virtual void UpdateContactDetails(string contactDetails)
            {
                ContactDetails = contactDetails;
            }
        public virtual void UpdateAddress(string address) { 
            Address = address; 
        
        }

            #endregion
        }
    }

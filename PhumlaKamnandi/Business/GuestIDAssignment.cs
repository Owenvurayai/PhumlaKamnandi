using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class GuestIDAssignment
    {
        private static readonly AgentIDAssignment agentInstance = new AgentIDAssignment();
        private ArrayList assignedGuestIDs = new ArrayList();
        private int counter = 1;//increment this to make the ID unique
        public static AgentIDAssignment AgentInstance
        {
            get
            {
                return agentInstance;
            }
        }
        public string GenerateGuestID()
        {
            string guestID = "GuS" +(counter++) ;//generate a unique ID, which will be, "GuS1, GuS2
            assignedGuestIDs.Add(guestID); //Add the created ID into the list
            return guestID;
        }

        //make the room number to be available
        public void Delete(string guestID)
        {
            assignedGuestIDs.Remove(guestID);
        }
    }
}
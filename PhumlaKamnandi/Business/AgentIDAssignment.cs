using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class AgentIDAssignment
    {
        private ArrayList assignedAgentIDs=new ArrayList();
        private int counter = 1;

        public string GenerateGuestID() { 
          string guestID= "AGT"+(counter++);
            return guestID;
        }
    }
}

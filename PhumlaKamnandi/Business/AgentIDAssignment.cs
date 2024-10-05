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
        private static readonly AgentIDAssignment AgentInstance = new AgentIDAssignment();

        // Private readonly list to store assigned Agent IDs
        private ArrayList assignedAgentIDs = new ArrayList();

        // Counter for generating unique Agent IDs
        private int counter = 1;
        public static AgentIDAssignment instance
        {
            get
            {
                return AgentInstance;
            }
        }
        // Method to generate a unique Agent ID
        public string GenerateGuestID()
        {
            string agentID;
            do
            {
                agentID = "AGT" + (counter++); // Generate ID with prefix AGT and increment counter
            } while (assignedAgentIDs.Contains(agentID)); // Ensure the ID is unique

            assignedAgentIDs.Add(agentID); // Add the ID to the list
            return agentID;
        }

        // Method to remove an Agent ID from the list
        public void RemoveAgentID(string agentID)
        {
            assignedAgentIDs.Remove(agentID);
        }

        // Method to check if an Agent ID is already assigned
        public bool IsAssignedAgentID(string agentID)
        {
            return assignedAgentIDs.Contains(agentID);
        }

        // Method to retrieve a readonly version of the assigned IDs list
        public IReadOnlyList<object> GetAssignedAgentIDs()
        {
            return assignedAgentIDs.Cast<object>().ToList().AsReadOnly();
        }
    }
}

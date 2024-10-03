using PhumlaKamnandi.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class AgentController
    {
        private Collection<BookingAgent> agents;
        private HotelDB hotelDB;

        public AgentController()
        {
            agents = hotelDB.AllAgents;
            hotelDB = new HotelDB();
        }

        public void AddAgent(BookingAgent agent)
        {
            agents.Add(agent);
            hotelDB.CreateAgent(agent.AgentID, agent.CompanyName,agent.FirstName + " " + agent.LastName, agent.Email, agent.ContactDetails);
        }

        public void RemoveAgent(BookingAgent agent)
        {
            
            agents.Remove(agent);
            hotelDB.DeleteAgent(agent.AgentID);
        }
        public Collection<BookingAgent> GetAgents()
        {
            return agents;
        }

        public BookingAgent FindAgent(string id)
        {
            foreach (BookingAgent agent in agents)
            {
                if (agent.AgentID.Equals(id))
                    return agent;
            }
            return null;
        }

        public void UpdateBooking(BookingAgent new_agent)
        {
           BookingAgent agent = FindAgent(new_agent.AgentID);
            int index = agents.IndexOf(agent);
            if (agent != null)
            {
                //update the dababase and the collection
                hotelDB.UpdateAgent(agent.AgentID, new_agent.CompanyName, new_agent.FirstName + " " + new_agent.LastName, new_agent.Email);
                //update the collection
                agents[index]= new_agent;
            }
        }


        public void UpdateCompanyName(string id, string comName)
        {
            BookingAgent agent = FindAgent(id);
            agent.UpdateEmail(comName);
            hotelDB.UpdateAgent(id, agent.CompanyName, agent.FirstName + " " + agent.LastName, agent.Email);
            int index = agents.IndexOf(agent);
            agents[index] = agent;
        }

       

        public string getGuestDetails(string id)
        {
            BookingAgent agent = FindAgent(id);
            return agent.GetBookingAgentDetails();
        }
    }
}

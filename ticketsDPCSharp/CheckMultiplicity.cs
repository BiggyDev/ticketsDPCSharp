using System;
using System.Collections.Generic;

namespace ticketsDPCSharp
{
    public class CheckMultiplicity : CheckTicket
    {
        public Boolean Check(Ticket ticket)
        {
            List<Ticket> tickets = new List<Ticket>();
            return CheckAndAdd(ticket, tickets);
        }

        private Boolean CheckAndAdd(Ticket ticket, List<Ticket> tickets)
        {
            if (tickets.Contains(ticket))
            {
                return false;
            }

            tickets.Add(ticket);

            foreach (Ticket t in ticket.Tickets)
            {
                if (!CheckAndAdd(t, tickets))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

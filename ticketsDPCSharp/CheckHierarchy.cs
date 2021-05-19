using System;
using System.Collections.Generic;

namespace ticketsDPCSharp
{
    public class CheckHierarchy : CheckTicket
    {
        public Boolean Check(Ticket ticket)
        {
            Boolean result = true;
            foreach(Ticket childTicket in ticket.Tickets)
            {
                if (!Contains(childTicket, GetTicketTypeContent(ticket.Type)))
                {
                    return false;
                }

                result &= Check(childTicket);
            }
           
            return result;
        }

        private List<TicketType> GetTicketTypeContent(TicketType ticketType)
        {
            return ticketType.TicketTypes;
        }

        private Boolean Contains(Ticket ticket, List<TicketType> ticketTypes)
        {
            return ticketTypes.Contains(ticket.Type);
        }
    }
}

using System;
using System.Collections.Generic;

namespace ticketsDPCSharp
{
    public class TicketType
    {
        public String Label { get; set; }
        public List<TicketType> TicketTypes { get; }

        public TicketType(String label)
        {
            Label = label;
            TicketTypes = new List<TicketType>();
        }

        public void Add(TicketType ticketType)
        {
            TicketTypes.Add(ticketType);
        }
    }
}

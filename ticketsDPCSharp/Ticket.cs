using System;
using System.Collections.Generic;

namespace ticketsDPCSharp
{
    public class Ticket
    {
        public TicketType Type { get; set; }
        public String Label { get; set; }
        public List<Ticket> Tickets { get; }

        public Ticket(TicketType type, String label)
        {
            Type = type;
            Label = label;
            Tickets = new List<Ticket>();
        }

        public void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
        }

        public void Print()
        {
            Console.WriteLine(Label);
            foreach(Ticket ticket in Tickets)
            {
                ticket.Print();
            }
        }
    }
}

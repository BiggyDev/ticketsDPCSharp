using System;

namespace ticketsDPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketType type = new TicketType("Task");

            Ticket t1 = new Ticket(type, "t1");
            Ticket t1_1 = new Ticket(type, "t1_1");
            Ticket t1_1_1 = new Ticket(type, "t1_1_1");

            t1.Add(t1_1);
            t1.Add(t1_1_1);
            t1_1.Add(t1_1_1);

            t1.Print();

            Console.WriteLine(CheckMultiplicity.Check(t1));
        }
    }
}

using System;

namespace ticketsDPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketType task = new TicketType("Task");
            TicketType epic = new TicketType("Epic");
            TicketType initiative = new TicketType("Initiative");
            TicketType anomaly = new TicketType("Anomaly");
            TicketType story = new TicketType("Story");

            initiative.Add(epic);
            epic.Add(story);
            story.Add(anomaly);
            story.Add(task);
            anomaly.Add(task);

            Ticket t1 = new Ticket(initiative, "t1");
            Ticket t1_1 = new Ticket(epic, "t1_1");
            Ticket t1_1_1 = new Ticket(story, "t1_1_1");
            Ticket t1_1_1_1 = new Ticket(anomaly, "t1_1_1_1");
            Ticket t1_1_1_2 = new Ticket(task, "t1_1_1_2");
            Ticket t1_1_1_1_1 = new Ticket(task, "t1_1_1_1_1");

            t1.Add(t1_1);
            t1_1.Add(t1_1_1);
            t1_1_1.Add(t1_1_1_1);
            t1_1_1.Add(t1_1_1_2);
            t1_1_1_1.Add(t1_1_1_1_1);

            t1.Print();

            //Console.WriteLine(new CheckMultiplicity().Check(t1));
            Console.WriteLine(new CheckHierarchy().Check(t1));
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");
            Queue<Ticket> Payments = new Queue<Ticket>();
            Queue<Ticket> Subscriptions = new Queue<Ticket>();
            Queue<Ticket> Cancellations = new Queue<Ticket>();
            List<Ticket> testTicketElements = new List<Ticket>
        {
            new Ticket(Ticket.ERequestType.Payment, 30),
            new Ticket(Ticket.ERequestType.Cancellation, 24),
            new Ticket(Ticket.ERequestType.Cancellation, 50),
            new Ticket(Ticket.ERequestType.Subscription, 99),
            new Ticket(Ticket.ERequestType.Payment, 31),
            new Ticket(Ticket.ERequestType.Subscription, 80),
        };

            List<Ticket> cualquiera = testTicketElements.OrderBy(x => x.Turn).ToList();
            foreach ( Ticket tikete in cualquiera)
            {
                Console.WriteLine("turno :"+ tikete.Turn + " suscripcion " + tikete.RequestType);
            }
        }
    }
        
}

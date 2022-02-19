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
            foreach (Ticket tikete in cualquiera)
            {

                if (tikete.RequestType == Ticket.ERequestType.Payment)
                {
                    Payments.Enqueue(tikete);
                }
                else if (tikete.RequestType == Ticket.ERequestType.Subscription)
                {
                    Subscriptions.Enqueue(tikete);
                }
                else if (tikete.RequestType == Ticket.ERequestType.Cancellation)
                {
                    Cancellations.Enqueue(tikete);
                }

                //Console.WriteLine("turno :" + tikete.Turn + " suscripcion " + tikete.RequestType);
            }

            Queue<Ticket>[] result = { Payments, Subscriptions, Cancellations };

            for (int i =0; i<result.Length;i++)
            {
                foreach (Ticket lol in result[i])
                {
                    Console.WriteLine("turno :" + lol.Turn + " suscripcion " + lol.RequestType);
                }

            }
            prueba(result[0], new Ticket(Ticket.ERequestType.Payment, 99));

            for (int i = 0; i < result.Length; i++)
            {
                foreach (Ticket lol in result[i])
                {
                    Console.WriteLine("turno :" + lol.Turn + " suscripcion " + lol.RequestType);
                }

            }

        }
         static bool prueba(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            if (ticket.Turn > 0 && ticket.Turn < 100)
            {

                foreach (Ticket lol in targetQueue)
                {
                    if (ticket.RequestType == lol.RequestType)
                    {
                        targetQueue.Enqueue(ticket);
                        result = true;
                        Console.WriteLine("si sirve ");
                    }
                    else
                    {
                        result = false;
                        Console.WriteLine("no se guarda ");
                    }
                    break;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
        
}

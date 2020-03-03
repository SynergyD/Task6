using System;

namespace Task6LuckyTickets
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            TicketFactory tickets = new TicketFactory();
            MoskowTicketAlghorithm alghorithm = new MoskowTicketAlghorithm(tickets);
            PiterTicketAlghorithm alghorithm2 = new PiterTicketAlghorithm(tickets);
            
            Console.WriteLine("Moskow Alghorithm:{0}",alghorithm.CountLuckyTickets());
            Console.WriteLine("Piter Alghorithm:{0}",alghorithm2.CountLuckyTickets());

        }
    }
}
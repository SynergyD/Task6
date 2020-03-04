using System;
using System.IO;

namespace Task6LuckyTickets
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = args[0];
            TicketFactory tickets = new TicketFactory();
            Alghorithm a = Alghorithm.None;

            using (StreamReader sr = new StreamReader(path))
                {
                    string text = sr.ReadLine();
                    if (text == "Piter")
                    {
                        a = Alghorithm.Piter;
                    }
                    if (text == "Moscow")
                    {
                        a = Alghorithm.Moscow;
                    }
                }

                switch (a)
            {
                case Alghorithm.Moscow:
                    MoscowTicketAlghorithm alghorithm = new MoscowTicketAlghorithm(tickets);
                    Console.WriteLine("Moscow Alghorithm:{0}",alghorithm.CountLuckyTickets());
                    break;
                case Alghorithm.Piter:
                    PiterTicketAlghorithm alghorithm2 = new PiterTicketAlghorithm(tickets);
                    Console.WriteLine("Piter Alghorithm:{0}",alghorithm2.CountLuckyTickets());
                    break;
                case Alghorithm.None:
                    Console.WriteLine("Not complete");
                    break;
            }
        }
    }
}
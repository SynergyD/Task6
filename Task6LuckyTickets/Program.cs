using System;
using System.IO;

namespace Task6LuckyTickets
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string instruction = "Input path";

            try
            {
                TicketFactory tickets = new TicketFactory();
                switch (GetAlghorithm(args))
                {
                    case Alghorithm.Moscow:
                        MoscowTicketAlghorithm moscowAlghorithm = new MoscowTicketAlghorithm(tickets);
                        Console.WriteLine("Moscow Alghorithm:{0}", moscowAlghorithm.CountLuckyTickets());
                        break;
                    case Alghorithm.Piter:
                        PiterTicketAlghorithm piterAlghorithm = new PiterTicketAlghorithm(tickets);
                        Console.WriteLine("Piter Alghorithm:{0}", piterAlghorithm.CountLuckyTickets());
                        break;
                    case Alghorithm.None:
                        Console.WriteLine("Not complete");
                        break;
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(instruction);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(instruction);
            }
        }

        private static Alghorithm GetAlghorithm(string[] _args)
        {
            string path = GetArg(_args);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            string textAlghorithm;

            using (StreamReader streamReader = new StreamReader(path))
            {
                textAlghorithm = streamReader.ReadLine();
            }

            Enum.TryParse(textAlghorithm, out Alghorithm alghorithm);
            return alghorithm;
        }

        private static string GetArg(string[] _args)
        {
            if (_args.Length < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _args[0];
        }
    }
}
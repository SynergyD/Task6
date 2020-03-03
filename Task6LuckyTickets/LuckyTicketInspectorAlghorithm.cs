using System;
using System.Linq;

namespace Task6LuckyTickets
{
    public abstract  class LuckyTicketInspectorAlghorithm
    {
        protected const int CountOfNum = 6;
        private const int Devider = 10;

        private readonly TicketFactory _tickets;
        
        protected LuckyTicketInspectorAlghorithm(TicketFactory tickets)
        {
            _tickets = tickets;
        }
        
        protected int[] SplitTicketToArray(Ticket ticket)
        {
            var splitedArray = new int[CountOfNum];
            int temp = ticket.Number;

            for (int i = splitedArray.Length - 1; i >= 0; i--)
            {
                splitedArray[i] = ticket.Number % Devider;
                ticket.Number /=  Devider;
                
            }

            ticket.Number = temp;

            return splitedArray;
        }

        protected abstract  bool IsLucky(Ticket ticket);

        public int CountLuckyTickets()
        {
            return _tickets.Count(ticket => IsLucky(ticket));
        }
    }
}
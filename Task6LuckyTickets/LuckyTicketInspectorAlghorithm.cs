using System.Linq;

namespace Task6LuckyTickets
{
    public abstract  class LuckyTicketInspectorAlghorithm
    {
        protected int CountOfNum = 6;
        private const byte Devider = 10;

        private readonly TicketFactory _tickets;
        
        protected LuckyTicketInspectorAlghorithm(TicketFactory tickets)
        {
            _tickets = tickets;
        }
        
        protected int[] SplitTicketToArray(Ticket ticket)
        {
            var splitedArray = new int[CountOfNum];
            var temp = ticket.Number;

            for (var i = splitedArray.Length - 1; i >= 0; i--)
            {
                splitedArray[i] = temp % Devider;
                temp /=  Devider;
                
            }

            return splitedArray;
        }

        protected abstract  bool IsLucky(Ticket ticket);

        public int CountLuckyTickets()
        {
            return _tickets.Count(IsLucky);
        }
    }
}
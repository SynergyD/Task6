namespace Task6LuckyTickets
{
    public abstract  class LuckyTicketInspectorAlghorithm
    {
        protected const int CountOfNum = 6;
        protected const int Devider = 10;

        private readonly TicketFactory _tickets;
        
        protected LuckyTicketInspectorAlghorithm(TicketFactory tickets)
        {
            _tickets = tickets;
        }
        
        protected int[] SplitTicketToArray(Ticket ticket)
        {
            var splitedArray = new int[CountOfNum];
            var index= splitedArray.Length - 1;

            while (ticket.Number > Devider - 1)
            {
                splitedArray[index] = ticket.Number % Devider;
                ticket.Number = ticket.Number / Devider;
                index--;
            }

            splitedArray[index] = ticket.Number;

            return splitedArray;
        }

        protected abstract  bool IsLucky(Ticket ticket);

        public int CountLuckyTickets()
        {
            int sum = 0;

            foreach (Ticket ticket in _tickets)
            {
                if (IsLucky(ticket))
                {
                    sum++;
                }
            }
            
            return sum;
        }
    }
}
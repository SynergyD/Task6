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
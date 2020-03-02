using System;
using System.Collections;
using System.Collections.Generic;

namespace Task6LuckyTickets
{
    public class TicketFactory : IEnumerable<Ticket>
    {
        private const int Min = 0;
        private const int Max = 999999;
        public IEnumerator<Ticket> GetEnumerator()
        {
            for (int i = Min; i <= Max; i++)
            {
                yield return new Ticket(i);
                //return tickets.GetEnumerator();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
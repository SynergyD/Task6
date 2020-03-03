using System;
using System.Collections;
using System.Collections.Generic;

namespace Task6LuckyTickets
{
    public class TicketFactory : IEnumerable<Ticket>
    {
        private const int Min = 1;
        private const int Max = 999999;
        public IEnumerator<Ticket> GetEnumerator()
        {
            for (int i = Max; i >= Min; i--)
            {
                yield return new Ticket(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
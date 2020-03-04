namespace Task6LuckyTickets
{
    public class MoscowTicketAlghorithm : LuckyTicketInspectorAlghorithm
    {
        public MoscowTicketAlghorithm(TicketFactory tickets) : base(tickets)
        {
        }

        protected override bool IsLucky(Ticket ticket)
        {
            var sumOfFirstPart = SumOfSplitedTicket(SplitTicketToArray(ticket),0,CountOfNum/2);
            var sumOfSecondPart = SumOfSplitedTicket(SplitTicketToArray(ticket),CountOfNum/2,CountOfNum);

            return (sumOfFirstPart == sumOfSecondPart) ?  true : false;
        }
        
        private static int SumOfSplitedTicket(int[] splitedArray,int start,int end)
        {
            var sum = 0;
            
            for (int i = start; i < end; i++)
            {
                sum += splitedArray[i];
            }

            return sum;
        }
    }
}
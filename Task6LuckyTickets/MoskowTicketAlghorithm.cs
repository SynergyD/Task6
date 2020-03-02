namespace Task6LuckyTickets
{
    public class MoskowTicketAlghorithm : LuckyTicketInspectorAlghorithm
    {
        public MoskowTicketAlghorithm(TicketFactory tickets) : base(tickets)
        {
        }


        protected override bool IsLucky(Ticket ticket)
        {
            bool isLucky;
            int sumOfFirstPart = SumOfSplitedTicket(SplitTicketToArray(ticket),0,CountOfNum/2);
            int sumOfSecondPart = SumOfSplitedTicket(SplitTicketToArray(ticket),CountOfNum/2,CountOfNum);
            
            isLucky = (sumOfFirstPart == sumOfSecondPart) ? isLucky = true : isLucky = false;

            return isLucky;
        }

        

        private int SumOfSplitedTicket(int[] splitedArray,int start,int end)
        {
            int sum = 0;
            
            for (int i = start; i < end; i++)
            {
                sum += splitedArray[i];
            }

            return sum;
        }


        
    }
}
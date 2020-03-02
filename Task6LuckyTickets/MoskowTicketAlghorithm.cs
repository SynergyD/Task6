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
            int sumOfFirstPart = SumOfSplitedTicket(SplitTicket(ticket),0,CountOfNum/2);
            int sumOfSecondPart = SumOfSplitedTicket(SplitTicket(ticket),CountOfNum/2,CountOfNum);
            
            isLucky = (sumOfFirstPart == sumOfSecondPart) ? isLucky = true : isLucky = false;

            return isLucky;
        }

        private int[] SplitTicket(Ticket ticket)
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
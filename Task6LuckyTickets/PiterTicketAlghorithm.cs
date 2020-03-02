namespace Task6LuckyTickets
{
    public class PiterTicketAlghorithm : LuckyTicketInspectorAlghorithm
    {
        public PiterTicketAlghorithm(TicketFactory tickets) : base(tickets)
        {
        }

        protected override bool IsLucky(Ticket ticket)
        {
            bool isLucky = false;
            if (SumOfEvenNum(SplitTicketToArray(ticket)) == SumOfOddNum(SplitTicketToArray(ticket)))
            {
                isLucky = true;
            }
            return isLucky;
        }

        private int SumOfEvenNum(int[] splitedArray)
        {
            int sum = 0;

            for (int i = 1; i < splitedArray.Length; i+=2)
            {
                sum += splitedArray[i];
            }
            
            return sum;
        }
        
        private int SumOfOddNum(int[] splitedArray)
        {
            int sum = 0;

            for (int i = 0; i < splitedArray.Length; i+=2)
            {
                sum += splitedArray[i];
            }
            
            return sum;
        }
        
        

        
    }
}
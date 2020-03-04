namespace Task6LuckyTickets
{
    public class PiterTicketAlghorithm : LuckyTicketInspectorAlghorithm
    {
        public PiterTicketAlghorithm(TicketFactory tickets) : base(tickets)
        {
        }

        protected override bool IsLucky(Ticket ticket)
        {
            var isLucky = false;
            var sumOfEven = SumOfEvenNum(SplitTicketToArray(ticket));
            var sumOfOdd = SumOfOddNum(SplitTicketToArray(ticket));

            if (sumOfEven == sumOfOdd)
            {
                isLucky = true;
            }

            return isLucky;
        }

        private int SumOfEvenNum(int[] splitedArray)
        {
            var sum = 0;

            for (int i = 1; i < splitedArray.Length; i += 2)
            {
                sum += splitedArray[i];
            }

            return sum;
        }

        private int SumOfOddNum(int[] splitedArray)
        {
            var sum = 0;

            for (var i = 0; i < splitedArray.Length; i += 2)
            {
                sum += splitedArray[i];
            }

            return sum;
        }
    }
}
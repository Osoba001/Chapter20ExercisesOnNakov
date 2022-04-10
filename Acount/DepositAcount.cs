using CCBackEndAccountAssignment.Customers;
using System;
using System.Transactions;
using static CCBackEndAccountAssignment.Logic.Computation;

namespace CCBackEndAccountAssignment.Acount
{
    public class DepositAcount : Acount, ITransaction
    {
        public void Deposit()
        {
            Console.WriteLine("Hello, you made a deposit on a deposit acount");
        }
        public void WithDraw()
        {
            Console.WriteLine("Hello, you made a withdrawer from a deposit acount");
        }
        public override void CompanyInterest()
        {
           computeInterest();
        }
        public override void IndividualInterest()
        {
            computeInterest();
        }

        private void computeInterest()
        {
            if (Balance < 1000)
            {
                Interest = 0;
            }
            else
            {
                Interest = ComputeInterest(Months, InterestRate);
            }
        }
    }
}

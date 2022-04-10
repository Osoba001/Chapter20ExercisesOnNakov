using CCBackEndAccountAssignment.Customers;
using System;
using static CCBackEndAccountAssignment.Logic.Computation;
namespace CCBackEndAccountAssignment.Acount
{
    public class MortgageAcount : Acount,IDeposit
    {
        public void Deposit()
        {
            Console.WriteLine("Hello, you made a deposite on a Mortgage acount");
        }

        int interestMonth;
        public override void CompanyInterest()
        {
            if (Months>12)
            {
                Interest = ComputeInterest(Months, InterestRate);
            }
            else
            {
                Interest = ComputeInterest(Months, InterestRate)/2;
            }
        }

        public override void IndividualInterest()
        {
            if (Months>6)
            {
                interestMonth = Months - 6;
                Interest = ComputeInterest(interestMonth, InterestRate);
            }
            else
            {
                Interest = 0;
            }
        }
    }
}

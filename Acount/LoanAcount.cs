using CCBackEndAccountAssignment.Customers;
using System;
using static CCBackEndAccountAssignment.Logic.Computation;

namespace CCBackEndAccountAssignment.Acount
{
    public class LoanAcount : Acount,IDeposit
    {
        public void Deposit()
        {
            Console.WriteLine("Hello, you made a deposite on a loan acount");
        }
        int interestMonth;
        public override void CompanyInterest()
        {
            if (Months > 2)
            {
                interestMonth = Months - 2;
                Interest = ComputeInterest(interestMonth, InterestRate);
            }
            else
            {
                Interest = 0;
            }
           
        }

        public override void IndividualInterest()
        {
            if (Months>3)
            {
                interestMonth = Months - 3;
                Interest = ComputeInterest(interestMonth, InterestRate);
            }
            else
            {
                Interest = 0;
            }
        }
        
    }
}

using CCBackEndAccountAssignment.Acount;
using CCBackEndAccountAssignment.Customers;
using System;

namespace CCBackEndAccountAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //I have seperate interface for individual and company becaus I don't want to use "if statement" to be switching between customer type (company and Individaul) when calculating interest. I don't know if it's professional. I will like to get a feedback on this thanks.
            
            //ICompanyInterest comIn = new MortgageAcount();
            //IWithdraw tran = new DepositAcount();
            Console.WriteLine("Hello World!");
        }
    }
}

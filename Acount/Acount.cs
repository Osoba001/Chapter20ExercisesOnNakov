using CCBackEndAccountAssignment.Customer;
using CCBackEndAccountAssignment.Customers;
using System;
using System.Collections.Generic;

namespace CCBackEndAccountAssignment.Acount
{
    public abstract class Acount : IIndividualInterest,ICompanyInterest
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Interest { get; set; }
        public Customers.Customer IndividualCustomers { get; set; }
        public DateTime StartDate { get; set; }
        protected internal int Months
        {
            get { return (DateTime.Now.Month - StartDate.Month); }
        }
        public abstract void IndividualInterest();

        public abstract void CompanyInterest();
       
    }
}

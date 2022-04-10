using CCBackEndAccountAssignment.Customers;


namespace CCBackEndAccountAssignment.Customer
{
    public class Individual: Customers.Customer
    {
        public Acount.Acount Acount { get; set; }
    }
}

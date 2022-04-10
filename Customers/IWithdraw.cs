namespace CCBackEndAccountAssignment.Customers
{
    public interface IWithdraw
    {
        void WithDraw();
    }
    public interface IDeposit
    {
        void Deposit();
    }
    public interface ITransaction:IWithdraw,IDeposit
    {
        
    }
}

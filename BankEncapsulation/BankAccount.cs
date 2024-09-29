public class BankAccount
{
    private double balance;

    public void Deposit(double deposit)
    {
        balance += deposit;
    }

    public double GetBalance()
    {
        return balance;
    }
}
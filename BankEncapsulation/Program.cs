namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            myAccount.Deposit(300);

            Console.WriteLine(myAccount.GetBalance());
        }
    }
}

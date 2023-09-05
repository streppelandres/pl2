using ClassLibrary;

namespace I01Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("John Doe", 0);
            Console.WriteLine(account.Show());

            account.Add(500);
            Console.WriteLine(account.Show());

            account.Withdraw(100);
            Console.WriteLine(account.Show());

            account.Withdraw(500);
            Console.WriteLine(account.Show());
        }
    }
}
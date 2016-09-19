using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Accounts> accounts = new List<Accounts>();
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                accounts.Add(Accounts.CreateAccounts("#" + i, rand.Next(10, 100)));
            }

            Console.WriteLine("\n\nAll Accounts");
            foreach (Accounts Accounts in accounts)
            {
                Console.WriteLine(Accounts);
            }

            foreach (Accounts Accounts in accounts)
            {
                Accounts.Deposit(1.11);
            }

            Console.WriteLine("\n\nAfter $1.11 deposit ");
            foreach (Accounts Accounts in accounts)
            {
                Console.WriteLine(Accounts);
            }

            foreach (Accounts Accounts in accounts)
            {
                Accounts.Withdraw(0.05);
            }

            Console.WriteLine("\n\nAfter $0.05 withdrawal.");
            foreach (Accounts Accounts in accounts)
            {
                Console.WriteLine(Accounts);
            }

        }
    }
}

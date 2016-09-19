using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsDemo
{
    class Accounts
    {
        //fields

        //A readonly field is like a consts but it is normally assigned when the program is running
        //WHile a const is a value that cannot be modified.Its value is set at declaration.i.e.When the program is compiled
        private static int CURRENT_ACCOUNT_NUMBER;
        private const int TRANSIT_NUMBER = 314;  //cont is static by default :-)
        public readonly string Number;

        //properties
        public double Balance { get; private set; }
        public List<string> Names { get; private set; }

        //Two Constructor
        //static constructor can't be done "new". It triggers even when we instantiate the Class with a different non-static constructor.
        //auto-instantiates
        static Accounts()
        {
            CURRENT_ACCOUNT_NUMBER = 1000;
        }

        private Accounts(string number, string name, double balance)
        {
            Number = number;
            Balance = balance;
            Names = new List<string>();
            Names.Add(name);
        }

        //ToString Override
        public override string ToString()
        {
            return " A/C#  "+Number+" Balance "+Balance;
        }

        //Methods
        public void AddName(string name)
        {
            Names.Add(name);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public static Accounts CreateAccounts(string name, double balance = 0)
        {
            string fullAccNumber = "AC-"+TRANSIT_NUMBER +"-"+ CURRENT_ACCOUNT_NUMBER;
            CURRENT_ACCOUNT_NUMBER++;
            return new Accounts(fullAccNumber, name, balance);
        }











    }
}

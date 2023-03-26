using System;
namespace BankAccount
{
	public class BankAccount
	{
        private double balance;
        private string name;

        public BankAccount(double balance, string name)
        {
            this.balance = balance;
            this.name = name;
        }
        public double GetBalance() { return this.balance; }
        public string GetName() { return this.name; }
        public void Credit(double amount)
        {
            if (amount <= 0)
                throw new Exception(string.Format("balance less than 0"));
            else
            {
                this.balance += amount;
                Console.WriteLine("credit done");
            }
        }
        public void Debit(double amount)
        {
            if (this.balance - amount <= 0)
                throw new Exception(string.Format("balance less than 0,cant"));
            else
            {
                this.balance -= amount;
                Console.WriteLine("debit done");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}


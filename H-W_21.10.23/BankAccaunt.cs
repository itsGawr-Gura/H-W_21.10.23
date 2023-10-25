using System;

namespace H_W_21._10._23
{
    enum BankAccountType
    {
        Savings,
        Checking,
        Deposit
    }
    internal class BankAccount

    {
        private static int accountNumberCounter = 0001;
        private int accountNumber;
        private decimal balance;
        private BankAccountType accountType;
        public BankAccount(decimal initialBalance, BankAccountType type)
        {
            GenerateAccountNumber();
            balance = initialBalance;
            accountType = type;
        }
        public int AccountNumber
        {
            get { return accountNumber; }
        }
        public decimal Balance
        {
            get { return balance; }
        }
        public BankAccountType AccountType
        {
            get { return accountType; }
        }
        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Successfully withdrew ${0} from account number {1}.", amount, accountNumber);
            }
            else
            {
                Console.WriteLine("Insufficient funds in account number {0}.", accountNumber);
            }
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine("Successfully deposited ${0} to account number {1}.", amount, accountNumber);
        }
        private void GenerateAccountNumber()
        {
            accountNumber = accountNumberCounter++;
        }
    }
}

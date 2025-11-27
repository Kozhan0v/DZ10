using System;
using Tumakov12.Enums;

namespace Tumakov12.Classes
{
    internal class BankAccount
    {
        private static long staticAccountNum = 0;
        public long AccountNum { get; private set; }
        public decimal Balance { get; private set; }
        public TypeOfBankAccount BankAccountType { get; private set; }
        private Queue<BankTransaction> transactions = new Queue<BankTransaction>();

        internal BankAccount()
        {
            AccountNum = CreateNewAccountNum();
        }

        internal BankAccount(decimal balance)
        {
            AccountNum = CreateNewAccountNum();
            Balance = balance;
        }

        internal BankAccount(TypeOfBankAccount bankAccountType)
        {
            AccountNum = CreateNewAccountNum();
            BankAccountType = bankAccountType;
        }

        internal BankAccount(decimal balance, TypeOfBankAccount bankAccountType)
        {
            AccountNum = CreateNewAccountNum();
            Balance = balance;
            BankAccountType = bankAccountType;
        }

        private long CreateNewAccountNum()
        {
            return ++staticAccountNum;
        }

        public long GetAccountNum()
        {
            return AccountNum;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
        public TypeOfBankAccount GetBankAccountType()
        {
            return BankAccountType;
        }

        public void PrintTransactions()
        {
            foreach (var transaction in transactions)
            {
                transaction.PrintInfo();
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Операция невозможна!");
                return;
            }

            Balance += amount;

            BankTransaction transaction = new BankTransaction(amount, TransactionType.Deposit);
            transactions.Enqueue(transaction);

            Console.WriteLine("Операция прошла успешно, баланс пополнен");
        }

        public void Withdrow(decimal amount)
        {
            if (Balance < amount && amount < 0)
            {
                Console.WriteLine("Операция невозможна!");
                return;
            }

            Balance -= amount;

            BankTransaction transactions = new BankTransaction(amount, TransactionType.Withdrow);
            this.transactions.Enqueue(transactions);

            Console.WriteLine("Операция прошла успешно, деньги сняты со счета");
        }

        public void Transfer(BankAccount bankAccount, decimal amount)
        {
            bankAccount.Withdrow(amount);
            Deposit(amount);
        }

        public static bool operator==(BankAccount acc1, BankAccount acc2)
        {
            return acc1.AccountNum == acc2.AccountNum ? true : false;
        }

        public static bool operator!=(BankAccount acc1, BankAccount acc2)
        {
            return acc1.AccountNum == acc2.AccountNum ? false : true;
        }

        public override bool Equals(object obj)
        {
            BankAccount acc = obj as BankAccount;

            if (acc is not null)
            {
                return AccountNum == acc.AccountNum ? true : false;
            }
            
            return false;
        }

        public override int GetHashCode()
        {
            return AccountNum.GetHashCode();
        }

        public override string ToString()
        {
            return $"Номер счета: {AccountNum}. Баланс: {Balance}. Тип счета: {BankAccountType}.";
        }
    }
}
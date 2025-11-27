using System;
using System.Collections;
using Tumakov12.Enums;

namespace Tumakov12.Classes
{
    public class BankAccountFactory
    {
        public Hashtable AccountsTable { get; private set; }

        public BankAccountFactory()
        {
            AccountsTable = new Hashtable();
        }

        public long CreateAccount()
        {
            BankAccount account = new BankAccount();
            AccountsTable.Add(account.AccountNum, account);
            return account.GetAccountNum();
        }

        public long CreateAccount(decimal balance)
        {
            BankAccount account = new BankAccount(balance);
            AccountsTable.Add(account.AccountNum, account);
            return account.GetAccountNum();
        }

        public long CreateAccount(TypeOfBankAccount accountType)
        {
            BankAccount account = new BankAccount(accountType);
            AccountsTable.Add(account.AccountNum, account);
            return account.GetAccountNum();
        }
        public long CreateAccount(decimal balance, TypeOfBankAccount accountType)
        {
            BankAccount account = new BankAccount(balance, accountType);
            AccountsTable.Add(account.AccountNum, account);
            return account.GetAccountNum();
        }

        public void DeleteAccount(long accountNum)
        {
            AccountsTable.Remove(accountNum);
        }
    }
}

using System;
using BankAccountLibrary;
using BankAccountLibrary.Enums;
using HouseLibrary;

namespace Tumakov11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 11.1
            Console.WriteLine("Упражнение 11.2");

            BankAccountFactory accountCreator = new BankAccountFactory();

            long acc1 = accountCreator.CreateAccount();
            long acc2 = accountCreator.CreateAccount(650);
            long acc3 = accountCreator.CreateAccount(TypeOfBankAccount.Save);
            accountCreator.DeleteAccount(2);

            foreach (object key in accountCreator.AccountsTable.Keys)
            {
                Console.WriteLine("{0} - {1}", key, accountCreator.AccountsTable[key]);
            }


            // Упражнение 11.2
            Console.WriteLine("Домашнее задание 11.2");

            Creator.CreateBuild();
            Creator.CreateBuild(6.6);
            Creator.CreateBuild(6);
            Creator.CreateBuild(6.6, 6);
            Creator.CreateBuild(5.5, 5, 20, 1);
            Creator.DestroyBuild(3);

            foreach (object key in Creator.HouseTable.Keys)
            {
                Console.WriteLine("{0} - {1}", key, Creator.HouseTable[key]);
            }

        }
    }
}

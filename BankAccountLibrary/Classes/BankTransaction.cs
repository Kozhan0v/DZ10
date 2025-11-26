using System;
using BankAccountLibrary.Enums;

namespace BankAccountLibrary
{
    internal class BankTransaction
    {
        public decimal Amount { get; }
        public DateTime DataAndTime { get; }
        public TransactionType TransactionType { get; }

        public BankTransaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            DataAndTime = DateTime.Now;
            TransactionType = transactionType;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Сумма: {Amount}. Тип операции: {DataAndTime}. Дата и время: {TransactionType}");
        }
    }
}
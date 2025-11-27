using System;
using System.Collections;
using Tumakov12.Classes;
using Tumakov12.Enums;

namespace Tumakov12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 12.1
            Console.WriteLine("Упражнение 12.1");

            BankAccountFactory accountCreator = new BankAccountFactory();

            Hashtable HashTable = accountCreator.AccountsTable;

            long accNum1 = accountCreator.CreateAccount(650, TypeOfBankAccount.Current);
            long accNum2 = accountCreator.CreateAccount(1000, TypeOfBankAccount.Save);

            if (HashTable[accNum1] != HashTable[accNum2])
            {
                Console.WriteLine($"Счета разные");
                Console.WriteLine(HashTable[accNum1].ToString() + " Хэш код: " + HashTable[accNum1].GetHashCode());
                Console.WriteLine(HashTable[accNum2].ToString() + " Хэш код: " + HashTable[accNum2].GetHashCode());
            }

            if (HashTable[accNum2] == HashTable[accNum2])
            {
                Console.WriteLine("\nЭто один и тот же");
                Console.WriteLine(HashTable[accNum2].ToString() + " Хэш код: " + HashTable[accNum2].GetHashCode());
                Console.WriteLine(HashTable[accNum2].ToString() + " Хэш код: " + HashTable[accNum2].GetHashCode());
            }

            if (HashTable[accNum1].Equals(HashTable[accNum1]))
            {
                Console.WriteLine("\nСчета одинаковые");
                Console.WriteLine(HashTable[accNum1].ToString() + " Хэш код: " + HashTable[accNum1].GetHashCode());
                Console.WriteLine(HashTable[accNum1].ToString() + " Хэш код: " + HashTable[accNum1].GetHashCode());
            }



            // Упражнение 12.2
            Console.WriteLine("\nУпражнение 12.2");

            int x = 5;
            Rational num1 = new Rational(1, 2);
            Rational num2 = new Rational(2, 4);
            Rational num3 = x;

            if (num1 == num2)
            {
                Console.WriteLine($"{num1.ToString()} = {num2.ToString()}");
            }

            Console.WriteLine((int)(num1 + num2));

            Console.WriteLine("Сложение: " + (num1 + num2).ToString() + " = " + (int)(num1 + num2));
            Console.WriteLine("Вычитание: " + (num1 - num2).ToString() + " = " + (float)(num1 - num2));
            Console.WriteLine("Умножение: " + (num1 * num2).ToString() + " = " + (float)(num1 * num2));
            Console.WriteLine("Деление: " + (num1 / num2).ToString() + " = " + (int)(num1 / num2));
            Console.WriteLine(num3.ToString());



            // Домашнее задание 12.1
            Console.WriteLine("\nДомашнее задание 12.1");

            Complex number1 = new Complex(1, -3);
            Complex number2 = new Complex(2, 3);

            Console.WriteLine(number1.ToString());
            Console.WriteLine(number2.ToString());

            Console.WriteLine("Сложение: " + (number1 + number2).ToString());
            Console.WriteLine("Вычитание: " + (number1 - number2).ToString());
            Console.WriteLine("Умножение: " + (number1 * number2).ToString());



            // Домашнее задание 12.2
            Console.WriteLine("\nДомашнее задание 12.2");

            var books = new Book[]
            {
                new Book("Война и мир", "Лев Толстой", "Эксмо"),
                new Book("Тихий Дон", "Михаил Шолохов", "АСТ"),
                new Book("Братья Карамазовы", "Федор Достоевский", "Эксмо"),
                new Book("Идиот", "Федор Достоевский", "Азбука"),
                new Book("Анна Каренина", "Лев Толстой", "АСТ"),
                new Book("Преступление и наказание", "Федор Достоевский", "Эксмо"),
                new Book("Мастер и Маргарита", "Михаил Булгаков", "АСТ"),
                new Book("Доктор Живаго", "Борис Пастернак", "Эксмо"),
                new Book("Петр Первый", "Алексей Толстой", "Азбука"),
                new Book("Собор Парижской Богоматери", "Виктор Гюго", "Эксмо"),
                new Book("Отверженные", "Виктор Гюго", "АСТ"),
                new Book("Граф Монте-Кристо", "Александр Дюма", "Эксмо"),
                new Book("Три мушкетера", "Александр Дюма", "АСТ"),
                new Book("Улисс", "Джеймс Джойс", "Азбука"),
            };

            BookContainer bookContainer = new BookContainer(books);

            bookContainer.SortBooks(SortByName);
            bookContainer.PrintBooks();

            bookContainer.SortBooks(SortByAuthor);
            bookContainer.PrintBooks();

            bookContainer.SortBooks(SortByPublisher);
            bookContainer.PrintBooks();

        }

        public static int SortByName(Book book1, Book book2)
        {
            if (book1.Name.Length > book2.Name.Length)
            {
                return -1;
            }
            else if (book1.Name.Length == book2.Name.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static int SortByAuthor(Book book1, Book book2)
        {
            if (book1.Author.Length > book2.Author.Length)
            {
                return -1;
            }
            else if (book1.Author.Length == book2.Author.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static int SortByPublisher(Book book1, Book book2)
        {
            if (book1.Publisher.Length > book2.Publisher.Length)
            {
                return -1;
            }
            else if (book1.Publisher.Length == book2.Publisher.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
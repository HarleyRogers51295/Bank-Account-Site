using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1consoleUI
{
    public class CreditCard
    {
        CheckingAccount CheckingAccount = new CheckingAccount();

        private decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                Console.WriteLine("Please enter your PIN");
                int pin = int.Parse(Console.ReadLine());
                if (pin != CheckingAccount.PinNumber)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Invalid PIN!");
                }
            }
        }
        public string AccountNumber { get; set; }

        public Customer Owner { get; set; }

        public void PrintBalance()
        {
            Console.WriteLine($"Your credit card balance is : ${Balance}");
        }
       
        }
    }


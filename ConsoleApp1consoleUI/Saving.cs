using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1consoleUI
{
    class Saving
    {
        private decimal _balance;

        public decimal Balance//this makes it so adding and taking money is dependednt on the pin
        {
            get
            {
                return _balance;
            }
            set
            {
                Console.WriteLine("Please enter your PIN");
                int pin = int.Parse(Console.ReadLine());
                if (pin != CheckingAccount.PinNumber)// you need to make the pin number a variable.
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

        private string _routingNumber;
        public string RoutingNumber
        {
            get
            {
                return _routingNumber;//get the routing number from variable
            }
            set
            {
                if (value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Routing Number!");
                }
            }
        }
        public Customer Owner { get; set; }//connecting the other class here!

        public void PrintBalance()//this method connects to Balance and prints it.
        {
            Console.WriteLine($"Your Balance is : $ {Balance}");
        }
    }
}

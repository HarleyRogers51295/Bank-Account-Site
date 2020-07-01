using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1consoleUI
{
    public class CheckingAccount
    {
        public int PinNumber { get; set; }
        //Properties
        private static decimal _balance;

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
                if (pin != PinNumber)// you need to make the pin number a variable.
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Invalid PIN!");
                }
            }
        }
        //public int Balance { get; set; }
        public string AccountNumber { get; set; }

        private string _routingNumber;//feild = local class veriable
        public string RoutingNumber 
        {//
            get
            {
                return _routingNumber;//get the routing number from variable
            } 
            set 
            { 
                if(value.Length == 9)
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
            
            Console.WriteLine($"Your Checking account balance is : ${Balance}");
        }

        
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1consoleUI
{
    public class Customer
    {
        //These are all members.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }
        public CheckingAccount UserCheckingAccount { get; set; }



        public Customer()//Default Ptor
        {

        }
        //Peramitorized Ptor
        public Customer(string firstName, string lastName )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public void Deposit(decimal amount)// this take the users input and applies that to the Balance
        {
            UserCheckingAccount.Balance += amount;
        }
        public void Withdraw(decimal amount)// this take the users input and applies that to the Balance
        {
            UserCheckingAccount.Balance -= amount;
        }
        


    }
}

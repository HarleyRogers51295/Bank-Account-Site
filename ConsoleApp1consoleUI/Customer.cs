using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public CheckingAccount PinNumber { get; set; }
        public CreditCard UsersCard { get; set; }
        public Saving UserSavings { get; set; }


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
        public void Deposit1(decimal amount)// this take the users input and applies that to the Balance
        {
            UsersCard.Balance += amount;
        }
        public void Deposit2(decimal amount)// this take the users input and applies that to the Balance
        {
            UserSavings.Balance += amount;
        }
        public void Withdraw(decimal amount)// this take the users input and applies that to the Balance
        {
            UserCheckingAccount.Balance -= amount;
        }
        public void Withdraw1(decimal amount)// this take the users input and applies that to the Balance
        {
            UsersCard.Balance -= amount;
        }
        public void Withdraw2(decimal amount)// this take the users input and applies that to the Balance
        {
            UserSavings.Balance -= amount;
        }



    }
}

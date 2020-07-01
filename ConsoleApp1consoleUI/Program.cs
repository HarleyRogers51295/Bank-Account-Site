using System;
using System.Net;

namespace ConsoleApp1consoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a customer == creating a variabl/object of the customer data type.
            Customer customer = new Customer();

            //This alows the user to input and store the data in Customer
            Console.Write("Enter your first name: ");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your last name: ");
            customer.LastName = Console.ReadLine();
            Console.WriteLine();
            //This takes the users inputs and puts it in a string fro a greeting.
            Console.Write($"Hello {customer.FirstName} {customer.LastName}.");
            Console.WriteLine();
            Console.WriteLine();
            //Here we ask the user to input their age
            Console.Write("Please enter your age:");
            customer.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //this is an if statement to see if the user is old enough
            if (customer.Age >= 18)
            {
                //instantiating a checking account
                CheckingAccount checkingAccount = new CheckingAccount();
                //setting properties for the checking account
                CheckingAccount CheckingAccount = new CheckingAccount();

                Saving savingAcct = new Saving();
                customer.UserSavings = savingAcct;

                CreditCard creditCard = new CreditCard();
                customer.UsersCard = creditCard;

                CheckingAccount.RoutingNumber = "062004563";
                CheckingAccount.AccountNumber = "235426542125";

                //setting the owner property to the instance of the customer we created
                CheckingAccount.Owner = customer;

                //setting the checking acciount property on the customer 
                customer.UserCheckingAccount = checkingAccount;

                //printing the values
                Console.WriteLine($"Your checking account number " +
                    $"is: {CheckingAccount.AccountNumber}. \nThe " +
                    $"owner of this account is: {CheckingAccount.Owner.FirstName} " +
                    $"{CheckingAccount.Owner.LastName}");
                Console.WriteLine();
                Console.Write("Create a PIN number:");
                CheckingAccount.PinNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You are too young to have a bank " +
                   "account! \nContact your local branch for more details!");
                //the \n == make new line.
                return; //this will make it exit the program.

            }
            //initialize methods here. 

            string decision;
            string[] AcctChoice = { "1. Savings Account", "2. Credit Card", "3. Checking Account", "4. Exit" };
            do
            {
                Console.WriteLine();
                Console.WriteLine("What account would you like to go into?");
                Console.WriteLine("<Type the Number for your chouce>\n1. Savings, 2. Credit Card, 3. Checking Account, 4. Exit");
                Console.WriteLine();

                foreach (string option in AcctChoice)
                {
                    Console.WriteLine(option);
                }
                AcctChoice[0] = "1";
                AcctChoice[1] = "2";
                AcctChoice[2] = "3"; 
                AcctChoice[3] = "4"; 
                decision = Console.ReadLine();

                if (decision == AcctChoice[0])
                {
                    Console.WriteLine($"your current balance is: $ {customer.UserSavings.Balance}");

                    //asking user for withdraw or deposit
                    Console.WriteLine("Do you want to (1)deposit or (2)withdraw money?");
                    string userResponse = Console.ReadLine();

                    decimal amount;//this makes it so we can have amount in both below!
                    switch (userResponse)
                    {
                        case "1"://deposit operation
                            Console.WriteLine("How much?");//how much
                            amount = decimal.Parse(Console.ReadLine());//their input
                            customer.Deposit2(amount);//store it
                            customer.UserSavings.PrintBalance();//call the method that outputs it
                            break;
                        case "2"://withdraw opperation
                            Console.WriteLine("How much?");
                            amount = decimal.Parse(Console.ReadLine());
                            customer.Withdraw2(amount);
                            customer.UserSavings.PrintBalance();
                            break;

                    }

                }
                else if (decision == AcctChoice[1])
                {
                    Console.WriteLine($"your current balance is: $ {customer.UsersCard.Balance}");

                    //asking user for withdraw or deposit
                    Console.WriteLine("Do you want to (1)deposit or (2)withdraw money?");
                    string userResponse = Console.ReadLine();

                    decimal amount;//this makes it so we can have amount in both below!
                    switch (userResponse)
                    {
                        case "1"://deposit operation
                            Console.WriteLine("How much?");//how much
                            amount = decimal.Parse(Console.ReadLine());//their input
                            customer.Deposit1(amount);//store it
                            customer.UsersCard.PrintBalance();//call the method that outputs it
                            break;
                        case "2"://withdraw opperation
                            Console.WriteLine("How much?");
                            amount = decimal.Parse(Console.ReadLine());
                            customer.Withdraw1(amount);
                            customer.UsersCard.PrintBalance();
                            break;

                    }

                }
                else if (decision == AcctChoice[2])
                {
                    Console.WriteLine($"your current balance is: $ {customer.UserCheckingAccount.Balance}");

                    //asking user for withdraw or deposit
                    Console.WriteLine("Do you want to (1)deposit or (2)withdraw money?");
                    string userResponse = Console.ReadLine();

                    decimal amount;//this makes it so we can have amount in both below!
                    switch (userResponse)
                    {
                        case "1"://deposit operation
                            Console.WriteLine("How much?");//how much
                            amount = decimal.Parse(Console.ReadLine());//their input
                            customer.Deposit(amount);//store it
                            customer.UserCheckingAccount.PrintBalance();//call the method that outputs it
                            break;
                        case "2"://withdraw opperation
                            Console.WriteLine("How much?");
                            amount = decimal.Parse(Console.ReadLine());
                            customer.Withdraw(amount);
                            customer.UserCheckingAccount.PrintBalance();
                            break;

                    }
                 
                }
                else if (decision == AcctChoice[3])
                {
                    Console.WriteLine("Here are your final Balances.");
                    Console.WriteLine();
                    customer.UserSavings.PrintBalance();
                    customer.UsersCard.PrintBalance();
                    customer.UserCheckingAccount.PrintBalance();
                    Console.WriteLine();
                    Console.WriteLine("Thank you and have a great day!");
                    return;
                }
            } while (decision != AcctChoice[3]);

        }
    }
}

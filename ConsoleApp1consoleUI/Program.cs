using System;

namespace ConsoleApp1consoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a customer == creating a variabl/object of the customer data type.
            Customer c = new Customer();

            Console.Write("Enter your first name: ");
            c.FirstName = Console.ReadLine(); //Allows the user to input information for a class

            Console.Write("Enter your last name: ");
            c.LastName = Console.ReadLine();

            Console.Write($"Hello {c.FirstName} {c.LastName}.");
            Console.WriteLine();

            Console.Write("Please enter your age:");
            c.Age = int.Parse(Console.ReadLine());

            if(c.Age >= 18)
            {
                //instantiating a checking account
                CheckingAccount checkingAccount = new CheckingAccount();
                //setting properties for the checking account
                CheckingAccount CheckingAccount = new CheckingAccount();
                
                CheckingAccount.RoutingNumber = "062004563";
                CheckingAccount.AccountNumber = "235426542125";
                //setting the owner property to the instance of the customer we created
                CheckingAccount.Owner = c;
                //setting the checking acciount property on the customer 
                c.UserCheckingAccount = checkingAccount;
                //printing the values
                Console.WriteLine($"Your checking account number " +
                    $"is: {CheckingAccount.AccountNumber}. \nThe " +
                    $"owner of this account is: {CheckingAccount.Owner.FirstName} " +
                    $"{CheckingAccount.Owner.LastName}");

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
            

            //asking user for withdraw or deposit
            Console.WriteLine("Do you want to deposit or withdraw money?");
            string userResponse = Console.ReadLine();

            decimal amount;//this makes it so we can have amount in both below!
            switch (userResponse) 
            {
                case "deposit"://deposit operation
                    Console.WriteLine("How much?");//how much
                    amount = decimal.Parse(Console.ReadLine());//their input
                    c.Deposit(amount);//store it
                    c.UserCheckingAccount.PrintBalance();//call the method that outputs it
                    break;
                case "withdrawel"://withdraw opperation
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Withdraw(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;

            }
            
            //make another w or d
            // make a starting balance.
            // make a saving account. (class)
            //transfer?
            //credit card acct (class)

        }
    }
}

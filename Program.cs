using System;

namespace Console_ATM_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incorrectOptionQ = false;
            while (incorrectOptionQ == false)
            {
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                int option = int.Parse(Console.ReadLine());
        
                switch (option){
                    case 1:
                        Console.WriteLine("What is your card pin?");
                        int cardPin = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is your card number?");
                        int cardNumber = int.Parse(Console.ReadLine());
                        ATM_Actions.Withdraw.WithdrawCash(cardPin, cardNumber);



                        incorrectOptionQ = true;
                        break;

                    case 2:
                        Console.WriteLine("Deposit");
                        incorrectOptionQ = true;
                        break;

                    case 3:
                        Console.WriteLine("Check Balance");
                        incorrectOptionQ = true;
                        break;

                    default:
                        Console.WriteLine("Not a valid input");
                        incorrectOptionQ = false;
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project
{
    class CardSetters
    {
        // NOT SURE ABOUT THIS
        private int cardNum;
        private int cardPinNum;

        public int CardNumber
        {
            set
            {
                Console.WriteLine("What is your card number?");
                this.CardNumber = int.Parse(Console.ReadLine());
            }
        }

        public int CardPin
        {
            set
            {
                Console.WriteLine("What is your card pin?");
                this.cardPinNum = int.Parse(Console.ReadLine());
            }
        }


    }
}

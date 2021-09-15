using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project.ATM_Actions
{
    class CheckBal
    {
        public static int checkCardBalance(int cardNumber, int cardPin)
        {
            return Database.SelectCardBalance.CheckBalance(cardNumber, cardPin);
        }

    }
}

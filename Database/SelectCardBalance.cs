using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project.Database
{
    class SelectCardBalance
    {

        public static int CheckBalance(int cardNumber, int cardPin)
        {
            //String SQL = $"select user_amount from useraccounts where card_number = '" + cardNumber+ '" and card_pin =" + cardPin + "'";
            String SQL = $"select user_amount from useraccounts where card_number='{cardNumber}' and card_pin ='{cardPin}'";
            String balance = DBCommand.command(SQL).ExecuteScalar().ToString();
            return int.Parse(balance);
        }

    }
}

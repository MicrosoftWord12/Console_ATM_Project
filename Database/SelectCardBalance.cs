using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project.Database
{
    class SelectCardBalance
    {

        public int CheckBalance(int cardNumber, int cardPin)
        {
            String SQL = "select user_amount from useraccounts where cardNumber = " + cardNumber+ " and cardPin =" + cardPin + "'";
            String balance = DBCommand.command(SQL).ExecuteScalar().ToString();
            return int.Parse(balance);
        }

    }
}

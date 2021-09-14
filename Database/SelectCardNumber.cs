using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project.Database
{
    class SelectCardNumber
    {
        public static int SelectCardNum(int accountID)
        {
            String SQL = "select card_number from useraccounts where account_id=" + accountID + "'";
            String command = DBCommand.command(SQL).ExecuteScalar().ToString();
            return int.Parse(command);
        }
    }
}

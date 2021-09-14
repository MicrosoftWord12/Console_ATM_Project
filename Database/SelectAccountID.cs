using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace Console_ATM_Project.Database
{
    class SelectAccountID
    {
        public static int SelectAccountId(int cardNumber)
        {
            String sql = "select account_id from useraccounts where card_number='" + cardNumber + "'";
            String command = DBCommand.command(sql).ExecuteScalar().ToString();
            return int.Parse(command);
        }
    }
}
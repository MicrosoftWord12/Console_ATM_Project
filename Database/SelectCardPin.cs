using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project.Database
{
    class SelectCardPin
    {
        public int SelectPin(int cardNumber, int accountId)
        {
            String SQL = "select card_pin from useraccounts where card_number" + cardNumber + " AND account_id='" + accountId + "'";
            String command = DBCommand.command(SQL).ExecuteScalar().ToString();
            return int.Parse(command);
        }
    }
}

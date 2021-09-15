using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ATM_Project.ATM_Actions
{
    class Deposit
    {
        public int DepositAmount(int cardNumber, int cardPin)
        {
            int currentBalance = Database.SelectCardBalance.CheckBalance(cardNumber, cardPin);
            int withdrawAmount = int.Parse(Console.ReadLine());
            int newAmount = currentBalance + withdrawAmount;

            try
            {
                String SQL = $"update useraccount set user_amount='{newAmount}' where='{cardNumber}'";
                return int.Parse(Database.DBCommand.command(SQL).ExecuteScalar().ToString());
            }catch(Exception e)
            {
                 Console.WriteLine(e.ToString());
                 return 0;
             }

        }
    }
}

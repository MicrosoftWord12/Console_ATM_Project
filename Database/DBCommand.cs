using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace Console_ATM_Project.Database
{
    class DBCommand
    {

        public NpgsqlCommand command(String SQL)
        {
            DBConnection conn = new DBConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn.Connection());
            return cmd;
        }

    }
}

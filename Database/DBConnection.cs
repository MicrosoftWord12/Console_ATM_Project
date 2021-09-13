using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace Console_ATM_Project.Database
{
    class DBConnection
    {
        
        public NpgsqlConnection Connection()
        {
            String connectionString = "Host=localhost;Username=postgres;Password=1832;Database=C#Projects";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }

    }
}

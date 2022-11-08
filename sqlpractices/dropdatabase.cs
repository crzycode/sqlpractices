using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace sqlpractices
{
    internal class dropdatabase
    {
        

        public static string dropdb(string db)
        {
            string drop = $"drop database {db}";
            SqlConnection con = new SqlConnection(Program.str);
            con.Open();
            con.ChangeDatabase("master");
            SqlCommand cmd = new SqlCommand(drop,con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "drop";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace sqlpractices
{
    internal class renamedatabase
    {
        public static string renamedb(string oldname, string newname)
        {
            string rename = $"ALTER DATABASE {oldname} MODIFY NAME = {newname}";
            SqlConnection con = new SqlConnection(Program.str);
            con.Open();
            SqlCommand cmd = new SqlCommand(rename, con);
            cmd.ExecuteNonQuery();
            con.Close();

            return "renamed";
        }
        
    }
}

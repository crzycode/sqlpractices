using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace sqlpractices
{
    internal class createtable
    {
        public static void createtables()
        {
            string com = @"if exists(select * from sys.tables where name like 'Users')"
                + "drop table Users\n"
                + "create table Users(" +
                "id int identity(1,1) not null,"
                + "names varchar(50) not null," +
                "age int," +
                "constraint PK_id primary key clustered(id)" +
                ")";



            SqlConnection con = new SqlConnection(Program.str);
            SqlCommand cmd = new SqlCommand(com, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("success");
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace sqlpractices
{
    internal class CreateDatabase
    {
        
        
        
        
         public static string createdb(string datbaseexist)
        {

           string sqlCreateDBQuery = $"SELECT * FROM master.dbo.sysdatabases where name=\'{datbaseexist}\'";
            string command = "create database pracdb";

            string command2 = "create database Mydb on primary(name=wsis_d,filename='D:\\SQLPractice\\ned.mdf', size=10,maxsize=40MB,filegrowth=10%)" +
                "LOG ON(name=wsis_l, filename='D:\\SQLPractice\\ned.ldf', size=5,maxsize=10,filegrowth=1)";//file backup
            SqlConnection con = new SqlConnection(Program.str);
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    
                    con.Open();
                    con.ChangeDatabase("master");
                    Console.WriteLine("connection is open");
                    SqlCommand cmd = new SqlCommand($"SELECT db_id=('{datbaseexist}')", con);  
                   object exists = cmd.ExecuteScalar();
                    con.Close();
                    if (exists != null)
                    {
                      
                        return "exist";
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand($"create database {datbaseexist}", con);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        return "created";
                    }
                        
                    
                }
                catch (Exception ex )
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }
            return "ha";
        }
            
           
    }
}

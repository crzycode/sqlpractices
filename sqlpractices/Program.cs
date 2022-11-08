using System;
using System.Data.SqlClient;

namespace sqlpractices
{
    internal class Program
    {
        public static string str = @"Data Source=DESKTOP-K05R8T3\BEAST;Initial Catalog=;Integrated Security=True";
        static void Main(string[] args)
        {

            string ha = renamedatabase.renamedb("wwww", "manage");
               Console.WriteLine(ha);   
            
        }
    }
}

using _44_LoginValidation.model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_LoginValidation.DAL
{
    internal class UserDBContext
    {
        String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=DAC32;Integrated Security=True;";

        internal object validateUser(MyUser user)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand($"select * from [user] where uname = '{user.userName}' and password = '{user.password}'",conn);

            conn.Open();
            MyUser u1 = null;
            SqlDataReader record = cmd.ExecuteReader();

            if (record != null)
            {
                while (record.Read()) { 
                    u1 = new MyUser(record[0].ToString(), record[1].ToString(), record[2].ToString());
                }
            }

            conn.Close();

            return u1;

        }
    }
}

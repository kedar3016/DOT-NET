using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_LoginValidation.model
{
    internal class MyUser
    {
        public string userName {  get; set; }
        public string password { get; set; }

        public string email { get; set; }

        public MyUser(string userName, string password, string email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        public MyUser(String userName, string password)
        {
            this.userName = userName;
            this.password = password;
            
        }

        public override string ToString()
        {
            return $"UserName : {userName} , Email : {email}";
        }
    }
}

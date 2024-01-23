using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string login, string password) 
        {
            Login = login;
            Password = password;
                }

        //public override void PrintUser()
        //{
        //    Console.WriteLine(  $"user: {Login}, password {Password}");
        //}
    }
}

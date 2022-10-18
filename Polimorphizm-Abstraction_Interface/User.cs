using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface
{
    public class User : IUser
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Login successfull"); 
        }

        public string SenEmail(string email)
        {
            return "Email was send";
        }
    }
}

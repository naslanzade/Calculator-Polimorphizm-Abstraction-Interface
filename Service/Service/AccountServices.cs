using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    class AccountServices : IAccountServices
    {
        public void Register(string login, string password)
        {
            Console.WriteLine("Registered"); 
        }
    }
}

using Polimorphizm_Abstraction_Interface.Servicess.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface.Servicess.Implementation
{
    public class AccountService : IAccountService
    {
        public void Register()
        {
            Console.WriteLine("Registered");
        }
    }
}

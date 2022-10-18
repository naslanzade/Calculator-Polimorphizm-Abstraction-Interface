using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface
{
    public interface IUser
    {
        void Login(string username, string password);
        string SenEmail(string email);
    }
}

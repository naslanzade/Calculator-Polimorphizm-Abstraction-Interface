using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service.Interface
{
   public interface IAccountServices
    {
        void Register(string login, string password);
    }
}

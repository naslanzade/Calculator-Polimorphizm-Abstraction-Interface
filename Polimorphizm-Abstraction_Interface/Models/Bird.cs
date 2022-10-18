using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface.Models
{
    class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
    }
}

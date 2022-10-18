using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface.Models
{
    class Animal
    {
        public string Name { get; set; }


        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }            

    }
}

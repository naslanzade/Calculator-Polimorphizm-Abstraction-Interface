using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface.Models
{
    public class Student:Person
    {
        public override void Test2()
        {
            Console.WriteLine("Test Student");
        }

        public override string ToString()
        {
            return Name+" "+Surname+" "+Age;
        }
    }
}

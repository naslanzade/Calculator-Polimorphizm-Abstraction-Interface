using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface.Models
{
    public class Employee : Person
    {
        public override void Test2()
        {
            Console.WriteLine("Employee Test");
        }
    }
}

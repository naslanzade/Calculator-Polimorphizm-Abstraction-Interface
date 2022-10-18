using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphizm_Abstraction_Interface.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }



        public abstract void Test2();
        
    }

}

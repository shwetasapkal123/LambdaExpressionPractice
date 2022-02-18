using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpr
{
    public class Person
    {
        //uc1
        public string Address { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int SSN { get; set; }

        public override string ToString()
        {
            return $"SSN: {SSN}\t Name: {Name}\t Address: {Address}\t Age: {Age}";
        }
    }
}

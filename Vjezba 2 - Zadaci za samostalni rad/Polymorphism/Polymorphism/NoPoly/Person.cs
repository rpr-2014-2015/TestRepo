using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.NoPoly
{
    public class Person
    {
        public Int32 Identity { get; set; }
        public String Name { get; set; }
        public List<DrawingAccount> Accounts { get; set; }

        public Person()
        {
            Accounts = new List<DrawingAccount>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Poly.Bank b = new Poly.Bank();
            b.addPersonClient(new Poly.Person(1, "Adnan"));

            Poly.Person p = b.findClient(1) as Poly.Person;
            b.openDrawingAccountForPerson(p);

            p.Accounts[0].deposit(550);
            Console.WriteLine("Status: {0}", b.findClient(1).Accounts[0].Balance);
        }
    }
}

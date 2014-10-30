using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.NoPoly
{
    public class Bank
    {
        private List<Person> Clients { get; set; }
        private List<DrawingAccount> Accounts { get; set; }

        public Bank()
        {
            Clients = new List<Person>();
            Accounts = new List<DrawingAccount>();
        }

        public void addClient(Person p)
        {
            Clients.Add(p);
        }

        public void openAccountForPerson(Person p)
        {
            DrawingAccount acc = new DrawingAccount(0) { 
                AccountIdentity= Accounts.Count
            };
            Accounts.Add(acc);
            p.Accounts.Add(acc);
        }

        public Person findClient(Int32 identity)
        {
            return Clients.Single(person => person.Identity == identity);
        }

        public void depositMoney(DrawingAccount acc, Decimal amount)
        {
            acc.deposit(amount);
        }
    }
}

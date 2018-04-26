using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjRolePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCore person = new PersonCore();
            person.AddRole("borrower",new Borrower());
            Borrower bperson = person.GetRole("borrower") as Borrower;
            bperson.AddCredit(25);
            bperson.AddRole("investor", new Investor());
            Investor iperson = bperson.GetRole("investor") as Investor;
            iperson.Investe(100);
            bperson = iperson.GetRole("borrower") as Borrower;
            Console.WriteLine(bperson.GetCredit());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjRolePattern
{
    class Investor : PersonRole
    {
        public void Investe(int i)
        {
            Console.WriteLine(GetName() + "инвестировал"+i+"грЫвень");
        }
    }
}

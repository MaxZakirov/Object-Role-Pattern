using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjRolePattern
{
    class Borrower : PersonRole
    {
        int credit=0;

        public Borrower()
        {
        }

        public void AddCredit(int i)
        {
            credit += i;
        }

        public int GetCredit()
        {
            return credit;
        }
    }
}

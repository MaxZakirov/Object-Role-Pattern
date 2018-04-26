using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjRolePattern
{
    class PersonRole
    {
        PersonCore core;

        public PersonRole()
        {

        }

        public string GetName()
        {
            return core.GetName();
        }

        public PersonRole(PersonCore instance)
        {
            core = instance;
        }

        public void SetCore(PersonCore Core)
        {
            core = Core;
        }

        public List<string> GetAccounts()
        {
            return core.GetAccounts();
        }

        public PersonRole GetRole(string name)
        {
            return core.GetRole(name);
        }

        public void AddRole(string name,PersonRole Role)
        {
            core.AddRole(name,Role);
        }
    }
}

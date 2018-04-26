using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjRolePattern
{
    class PersonCore
    {
        string name;
        List<string> accounts;
        Dictionary<string,PersonRole> roles; 

        public PersonCore()
        {
            roles = new Dictionary<string, PersonRole>();
            roles.Add("person", new PersonRole(this));
            accounts = new List<string>() { "Max", "Allay" };
        }

        public string GetName()
        {
            return name;
        }

        public List<string> GetAccounts()
        {
            return accounts;
        }

        public void AddRole(string roleName,PersonRole role)
        {
            role.SetCore(this);
            roles.Add(roleName, role);
        }

        public PersonRole GetRole(string name)
        {
            return roles.ContainsKey(name) ? roles[name] : null;
        }
    }
}

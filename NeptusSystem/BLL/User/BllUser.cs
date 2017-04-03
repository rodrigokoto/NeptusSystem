using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeptusSystem.Model;
using NeptusSystem.DAO;

namespace NeptusSystem.BLL
{
    public class BllUser
    {
        public User ReturnUser(string name =  "")
        {
            return new DaoUser().ReturnUser(name);
        }
    }
}

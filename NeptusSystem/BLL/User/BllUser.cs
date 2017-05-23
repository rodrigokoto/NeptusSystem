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
        public User ReturnUser(string name = "")
        {
            return new DaoUser().ReturnUser(name);
        }

        public void ResetPassword(User user)
        {
            new DaoUser().ResetPassword(user);
        }

        public List<User> ReturnUserList()
        {
            return new DaoUser().ReturnUserList();
        }

        public void CreateUser(User user)
        {
            new DaoUser().CreateUser(user);
        }
    }
}

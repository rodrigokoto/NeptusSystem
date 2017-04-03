using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeptusSystem.Model;
using NeptusSystem.Model.User;

namespace NeptusSystem.DAO.Login
{
    class DaoLogin
    {
        public void Login(User user, out bool status)
        {

            status = true;
        }

        public void SessionLogin(User user)
        {


            Session.Session session = new Session.Session();
            
            session.SessionUser = user.Usuario;
            session.SessionPassword = user.Password;
            session.SessionStart = DateTime.Now;
        }

        public bool ValidateLogin()
        {
            return true;
        }

        
    }
}

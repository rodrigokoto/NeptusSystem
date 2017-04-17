using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeptusSystem.Model;
using System.Data.SqlClient;

namespace NeptusSystem.DAO
{
    public class DaoLogin
    {
        public object Dbfactory { get; private set; }

        public void ReturnUser(string user)
        {

            
            DBFactory factory = new DBFactory();

            SqlConnection conn = factory.Conection();
            SqlCommand command = conn.CreateCommand();

            command.CommandText = @"SELECT NPTIDLOGIN, NPTUSUARIO , NPTPASSWORD , NPTAREA , NPTACESSO FROM NPTLOGIN WHERE NPTUSUARIO = @user";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@user";



        }
        public void Login() { }


    }
}

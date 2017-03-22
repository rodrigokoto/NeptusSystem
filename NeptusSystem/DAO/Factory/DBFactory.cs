using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace NeptusSystem.DAO.Factory
{
    public class DBFactory 
    {
        public DBFactory() { }


        public class Conexao
        {
            private OleDbConnection _conn;
            private OleDbCommand _command;
            private static string _conexao = ConfigurationManager.ConnectionStrings["NeptusConection"].ConnectionString;



            private SqlConnection OpenConnection()
            {
                SqlConnection conn = new SqlConnection(_conexao);
                conn.Open();

                return conn;
            }
            
            public void Close()
            {

            }
        }
        

    }
}

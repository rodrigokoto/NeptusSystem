using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using ContractLicence;
using System.ComponentModel.Composition;

namespace NeptusSystem.DAO
{
    [Export(typeof(IConnection))]
    public class DBFactory : IConnection
    {
        public DBFactory() { }

        private static string _conexao = ConfigurationManager.ConnectionStrings["NeptusConection"].ConnectionString;

        public SqlConnection Connection
        {
            get
            {
                return Conection();
            }
        }

        public SqlConnection Conection()
        {
            SqlConnection conn = new SqlConnection(_conexao);

            conn.Open();
            
            return conn;
        }




    }
}

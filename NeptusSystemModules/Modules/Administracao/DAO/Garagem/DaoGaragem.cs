using NeptusSystemModules.Modules.Administracao.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules.Administracao.DAO
{
    class DaoGaragem
    {

        public SqlConnection Sqlcon { get; private set; }

        public int Insert_Garagem(Garagem garagem)
        {
            int ID = 0;

            Connection con = Connection.Instance;

            Sqlcon = con.NeptusConection.Connection;
            
            SqlTransaction transaction = null;

            try
            {
                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string insertCommand = @"INSERT INTO NPTGARAGEM (GARIDENTIFICADOR , GARNUMERO , GARBOX) OUTPUT INSERTED.GARID VALUES (@GARIDENTIFICADOR, @GARNUMERO, @GARBOX )";

                command.Parameters.AddWithValue("@GARIDENTIFICADOR", garagem.GARIDENTIFICADOR);
                command.Parameters.AddWithValue("@GARNUMERO", garagem.GARNUMERO);
                command.Parameters.AddWithValue("@GARBOX", garagem.GARBOX);
                
                command.CommandText = insertCommand;

                ID = (int)command.ExecuteScalar();
                transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Ocorreu um erro ao inserir os dados na tabela.\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
            }
            finally
            {
                Sqlcon.Close();
                Sqlcon.Dispose();
            }

            return ID;
        }

        public List<Garagem> Return_ListGaragem()
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Garagem> lstApartamento = new List<Garagem>();

            string selectCommand = @"SELECT GARID , GARIDENTIFICADOR , GARNUMERO , GARBOX FROM NPTGARAGEM";

            command.CommandText = selectCommand;

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                Garagem garagem = new Garagem();

                garagem.GARID = Convert.ToInt32(rs["GARID"].ToString());
                garagem.GARIDENTIFICADOR = rs["GARIDENTIFICADOR"].ToString();
                garagem.GARNUMERO = Convert.ToInt32(rs["GARNUMERO"].ToString());
                garagem.GARBOX = rs["GARBOX"].ToString();
                
                lstApartamento.Add(garagem);
            }

            Sqlcon.Close();

            return lstApartamento;
        }

        public void Delete_Garagem()
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Garagem> lstApartamento = new List<Garagem>();

            string selectCommand = @"TRUNCATE TABLE NPTAPART";

            command.CommandText = selectCommand;

            command.ExecuteNonQuery();
        }
    }
}

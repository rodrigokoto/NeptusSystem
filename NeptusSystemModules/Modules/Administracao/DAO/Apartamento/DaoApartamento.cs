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
    class DaoApartamento
    {

        public SqlConnection Sqlcon { get; private set; }

        public int Insert_Apartamento(Apartamento apartamento)
        {
            int ID = 0;

            Connection con = Connection.Instance;

            Sqlcon = con.NeptusConection.Connection;
            //Sqlcon.Open();
            SqlTransaction transaction = null;

            try
            {
                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string insertCommand = @"INSERT INTO NPTAPART (APARTBLOCO , APARTNUMERO) OUTPUT INSERTED.APARTID VALUES (@APARTBLCOCO, @APARTNUMERO)";

                command.Parameters.AddWithValue("@APARTBLCOCO", apartamento.blocoApart );
                command.Parameters.AddWithValue("@APARTNUMERO", apartamento.NumeroApart);
                
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

        public List<Apartamento> Return_ListApartamento()
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Apartamento> lstApartamento = new List<Apartamento>();

            string selectCommand = @"SELECT APARTID , APARTBLOCO ,  APARTNUMERO FROM NPTAPART";

            command.CommandText = selectCommand;

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                Apartamento apartamento = new Apartamento();

                apartamento.idApart = Convert.ToInt32(rs["APARTID"].ToString());
                apartamento.NumeroApart = Convert.ToInt32(rs["APARTNUMERO"].ToString());
                apartamento.blocoApart = rs["APARTBLOCO"].ToString();

                lstApartamento.Add(apartamento);
            }

            Sqlcon.Close();

            return lstApartamento;
        }

        public void Delete_Apartamentos()
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Apartamento> lstApartamento = new List<Apartamento>();

            string selectCommand = @"TRUNCATE TABLE NPTAPART";

            command.CommandText = selectCommand;

            command.ExecuteNonQuery();
        }

        public List<Apartamento> Retorna_Cadastrados()
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Apartamento> lstApartamento = new List<Apartamento>();

            string selectCommand = @"SELECT * FROM NPTAPART A WHERE A.APARTID IN (SELECT NPTMORADOR.MORADORAPART FROM NPTMORADOR)";

            command.CommandText = selectCommand;

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                Apartamento apartamento = new Apartamento();

                apartamento.idApart = Convert.ToInt32(rs["APARTID"].ToString());
                apartamento.NumeroApart = Convert.ToInt32(rs["APARTNUMERO"].ToString());
                apartamento.blocoApart = rs["APARTBLOCO"].ToString();

                lstApartamento.Add(apartamento);
            }

            Sqlcon.Close();

            return lstApartamento;
        }
    }
}

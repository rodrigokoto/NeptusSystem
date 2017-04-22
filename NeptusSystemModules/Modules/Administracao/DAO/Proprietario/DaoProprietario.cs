using NeptusSystemModules.Modules.Administracao.Model.Proprietario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules.Administracao.DAO
{
    public class DaoProprietario
    {
        SqlConnection Sqlcon;

        public void Insert_Proprietario(Proprietario proprietario)
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlTransaction transaction = null;

            try
            {


                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string insertCommand = @"INSERT INTO NPTPROPRIETARIO (PROPNAME,PROPCEL,PROPTEL,PROPEND,PROPDOC,PROPRG,PROPDDD1,PROPDDD2,PROPTPPESSOA, PROPMAIL) VALUES (@PROPNAME,@PROPCEL,@PROPTEL,@PROPEND,@PROPDOC,@PROPRG,@PROPDDD1,@PROPDDD2,@PROPTPPESSOA , @PROPMAIL)";

                command.Parameters.AddWithValue("@PROPNAME", proprietario.PROPNOME);
                command.Parameters.AddWithValue("@PROPCEL", proprietario.PROPCEL);
                command.Parameters.AddWithValue("@PROPTEL", proprietario.PROPTEL);
                command.Parameters.AddWithValue("@PROPEND", proprietario.PROPEND);
                command.Parameters.AddWithValue("@PROPDOC", proprietario.PROPDOC);
                command.Parameters.AddWithValue("@PROPRG", proprietario.PROPRG);
                command.Parameters.AddWithValue("@PROPDDD1", proprietario.PROPDDD1);
                command.Parameters.AddWithValue("@PROPDDD2", proprietario.PROPDDD2);
                command.Parameters.AddWithValue("@PROPTPPESSOA", proprietario.PROPTPPESSOA);
                command.Parameters.AddWithValue("@PROPMAIL", proprietario.PROPMAIL);

                command.CommandText = insertCommand;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Ocorreu um erro ao inserir os dados na tabela.\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Sqlcon.Close();
                Sqlcon.Dispose();
            }
        }

        public void Update_Proprietario(Proprietario proprietario)
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlTransaction transaction = null;

            try
            {
                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string updateCommand = @"UPDATE NPTPROPRIETARIO SET PROPNAME = @PROPNAME, PROPDOC = @PROPDOC, PROPRG = @PROPRG, PROPTPPESSOA = @PROPTPPESSOA, PROPMAIL = @PROPMAIL, PROPDDD1 = @PROPDDD1, PROPDDD2 = @PROPDDD2, PROPCEL = @PROPCEL, PROPTEL = @PROPTEL, PROPEND = @PROPEND WHERE PROPID = @PROPID";

                command.Parameters.AddWithValue("@PROPNAME", proprietario.PROPNOME);
                command.Parameters.AddWithValue("@PROPCEL", proprietario.PROPCEL);
                command.Parameters.AddWithValue("@PROPTEL", proprietario.PROPTEL);
                command.Parameters.AddWithValue("@PROPEND", proprietario.PROPEND);
                command.Parameters.AddWithValue("@PROPDOC", proprietario.PROPDOC);
                command.Parameters.AddWithValue("@PROPRG", proprietario.PROPRG);
                command.Parameters.AddWithValue("@PROPDDD1", proprietario.PROPDDD1);
                command.Parameters.AddWithValue("@PROPDDD2", proprietario.PROPDDD2);
                command.Parameters.AddWithValue("@PROPTPPESSOA", proprietario.PROPTPPESSOA);
                command.Parameters.AddWithValue("@PROPMAIL", proprietario.PROPMAIL);

                command.Parameters.AddWithValue("@PROPID", proprietario.PROPID);
                command.CommandText = updateCommand;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Ocorreu um erro ao alterar os dados na tabela.\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Sqlcon.Close();
                Sqlcon.Dispose();
            }

        }
       

        public List<Proprietario> Return_ListProprietario()
        {
            Connection con = Connection.Instance ;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Proprietario> lstProprietario = new List<Proprietario>();

            string selectCommand = @"SELECT PROPID ,PROPNAME ,PROPDOC ,PROPRG ,PROPTPPESSOA ,PROPMAIL ,PROPDDD1 ,PROPDDD2 ,PROPCEL ,PROPTEL ,PROPEND FROM NPTPROPRIETARIO";

            command.CommandText = selectCommand;

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                Proprietario proprietario = new Proprietario();

                proprietario.PROPID = Convert.ToInt32(rs["PROPID"].ToString());
                proprietario.PROPNOME = rs["PROPNAME"].ToString();
                proprietario.PROPDOC = rs["PROPDOC"].ToString();
                proprietario.PROPRG = rs["PROPRG"].ToString();
                proprietario.PROPTPPESSOA = rs["PROPTPPESSOA"].ToString();
                proprietario.PROPMAIL = rs["PROPMAIL"].ToString();
                proprietario.PROPDDD1 = rs["PROPDDD1"].ToString();
                proprietario.PROPDDD2 = rs["PROPDDD2"].ToString();
                proprietario.PROPCEL = rs["PROPCEL"].ToString();
                proprietario.PROPTEL = rs["PROPTEL"].ToString();
                proprietario.PROPEND = Convert.ToInt32(rs["PROPEND"].ToString());

                lstProprietario.Add(proprietario);
            }

            Sqlcon.Close();

            return lstProprietario;
        }

        public Proprietario Return_Proprietario(int id)
        {
            Proprietario proprietario = new Proprietario();

            Connection con = Connection.Instance ;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Proprietario> lstProprietario = new List<Proprietario>();

            string selectCommand = @"SELECT PROPID ,PROPNAME ,PROPDOC ,PROPRG ,PROPTPPESSOA ,PROPMAIL ,PROPDDD1 ,PROPDDD2 ,PROPCEL ,PROPTEL ,PROPEND FROM NPTPROPRIETARIO WHERE PROPID = @PROPID";

            command.CommandText = selectCommand;
            command.Parameters.AddWithValue("PROPID", id);
            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                proprietario.PROPID = Convert.ToInt32(rs["PROPID"].ToString());
                proprietario.PROPNOME = rs["PROPNAME"].ToString();
                proprietario.PROPDOC = rs["PROPDOC"].ToString();
                proprietario.PROPRG = rs["PROPRG"].ToString();
                proprietario.PROPTPPESSOA = rs["PROPTPPESSOA"].ToString();
                proprietario.PROPMAIL = rs["PROPMAIL"].ToString();
                proprietario.PROPDDD1 = rs["PROPDDD1"].ToString();
                proprietario.PROPDDD2 = rs["PROPDDD2"].ToString();
                proprietario.PROPCEL = rs["PROPCEL"].ToString();
                proprietario.PROPTEL = rs["PROPTEL"].ToString();
                proprietario.PROPEND = Convert.ToInt32(rs["PROPEND"].ToString());
            }

            Sqlcon.Close();

            return proprietario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules.Administracao.DAO
{
    public class DaoMorador
    {
        SqlConnection Sqlcon;

        public void Insert_Morador(Model.Morador morador)
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlTransaction transaction = null;

            try
            {

                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string insertCommand = @"INSERT INTO NPTMORADOR (MORADORNOME, MORADORRG, MORADORCPF, MORADOREMAIL, MORADORAPART, MORADORDDD1, MORADORDDD2, MORADORTEL, MORADORCEL) VALUES(@MORADORNOME, @MORADORRG, @MORADORCPF, @MORADOREMAIL, @MORADORAPART, @MORADORDDD1, @MORADORDDD2, @MORADORTEL, @MORADORCEL)";

                command.Parameters.AddWithValue("@MORADORNOME", morador.MORADORNOME);
                command.Parameters.AddWithValue("@MORADORRG", morador.MORADORRG);
                command.Parameters.AddWithValue("@MORADORCPF", morador.MORADORCPF);
                command.Parameters.AddWithValue("@MORADOREMAIL", morador.MORADOREMAIL);
                command.Parameters.AddWithValue("@MORADORAPART", morador.MORADORAPART);
                command.Parameters.AddWithValue("@MORADORDDD1", morador.MORADORDDD1);
                command.Parameters.AddWithValue("@MORADORDDD2", morador.MORADORDDD2);
                command.Parameters.AddWithValue("@MORADORTEL", morador.MORADORDTEL);
                command.Parameters.AddWithValue("@MORADORCEL", morador.MORADORDCEL);



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
        public void Update_Proprietario(Model.Morador morador)
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlTransaction transaction = null;

            try
            {
                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string updateCommand = @"UPDATE NPTMORADOR SET  MORADORNOME = @MORADORNOME,  MORADORRG = @MORADORRG,  MORADORCPF = @MORADORCPF, MORADOREMAIL = @MORADOREMAIL, MORADORAPART = @MORADORAPART, MORADORDDD1 = @MORADORDDD1, MORADORDDD2 = @MORADORDDD2, MORADORTEL = @MORADORTEL, MORADORCEL = @MORADORCEL WHERE MORADORID = @MORADORID";

                
                command.Parameters.AddWithValue("@MORADORNOME", morador.MORADORNOME);
                command.Parameters.AddWithValue("@MORADORRG", morador.MORADORRG);
                command.Parameters.AddWithValue("@MORADORCPF", morador.MORADORCPF);
                command.Parameters.AddWithValue("@MORADOREMAIL", morador.MORADOREMAIL);
                command.Parameters.AddWithValue("@MORADORAPART", morador.MORADORAPART);
                command.Parameters.AddWithValue("@MORADORDDD1", morador.MORADORDDD1);
                command.Parameters.AddWithValue("@MORADORDDD2", morador.MORADORDDD2);
                command.Parameters.AddWithValue("@MORADORTEL", morador.MORADORDTEL);
                command.Parameters.AddWithValue("@MORADORCEL", morador.MORADORDCEL);

                command.Parameters.AddWithValue("@MORADORID", morador.MORADORID);

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
        public List<Model.Morador> Return_ListMorador()
        {

            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Model.Morador> lstMorador = new List<Model.Morador>();

            string selectCommand = @"select MORADORID, MORADORNOME, MORADORRG, MORADORCPF, MORADOREMAIL, MORADORAPART, MORADORDDD1, MORADORDDD2, MORADORTEL , MORADORCEL FROM NPTMORADOR";

            command.CommandText = selectCommand;

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                Model.Morador morador = new Model.Morador();

                morador.MORADORID = Convert.ToInt32(rs["MORADORID"].ToString());
                morador.MORADORNOME = rs["MORADORNOME"].ToString();
                morador.MORADORRG = rs["MORADORRG"].ToString();
                morador.MORADORCPF = rs["MORADORCPF"].ToString();
                morador.MORADOREMAIL = rs["MORADOREMAIL"].ToString();
                morador.MORADORAPART = Convert.ToInt32(rs["MORADORAPART"].ToString());
                morador.MORADORDDD1 = rs["MORADORDDD1"].ToString();
                morador.MORADORDDD2 = rs["MORADORDDD2"].ToString();
                morador.MORADORDTEL = rs["MORADORTEL"].ToString();
                morador.MORADORDCEL = rs["MORADORCEL"].ToString();

                lstMorador.Add(morador);

            }

            Sqlcon.Close();

            return lstMorador;
        }
        public Model.Morador Return_Morador(int id)
        {
            Model.Morador morador = new Model.Morador();

            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();
            List<Model.Morador> lstMorador = new List<Model.Morador>();

            string selectCommand = @"select MORADORID, MORADORNOME, MORADORRG, MORADORCPF, MORADOREMAIL, MORADORAPART, MORADORDDD1, MORADORDDD2, MORADORTEL , MORADORCEL FROM NPTMORADOR WHERE MORADORID = @MORADORID";

            command.CommandText = selectCommand;
            command.Parameters.AddWithValue("MORADORID", id);

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                morador.MORADORID = Convert.ToInt32(rs["MORADORID"].ToString());
                morador.MORADORNOME = rs["MORADORNOME"].ToString();
                morador.MORADORRG = rs["MORADORRG"].ToString();
                morador.MORADORCPF = rs["MORADORCPF"].ToString();
                morador.MORADOREMAIL = rs["MORADOREMAIL"].ToString();
                morador.MORADORAPART = Convert.ToInt32(rs["MORADORAPART"].ToString());
                morador.MORADORDDD1 = rs["MORADORDDD1"].ToString();
                morador.MORADORDDD2 = rs["MORADORDDD2"].ToString();
                morador.MORADORDTEL = rs["MORADORTEL"].ToString();
                morador.MORADORDCEL = rs["MORADORCEL"].ToString();
                
            }

            Sqlcon.Close();

            return morador;
        }
    }
}

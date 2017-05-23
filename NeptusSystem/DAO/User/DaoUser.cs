using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeptusSystem.Model;
using NeptusSystem.DAO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace NeptusSystem.DAO
{
    public class DaoUser
    {
        public User ReturnUser(string name = "")
        {
            DBFactory factory = new DBFactory();

            SqlConnection conn = factory.Conection();
            SqlCommand command = conn.CreateCommand();

            command.CommandText = @"SELECT NPTIDLOGIN, NPTUSUARIO , NPTPASSWORD , NPTAREA , NPTACESSO FROM NPTLOGIN WHERE NPTUSUARIO = @user";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@user";
            param.Value = name;
            command.Parameters.Add(param);
            SqlDataReader rs = command.ExecuteReader();

            User MdlUser = new User();

            while (rs.Read())
            {
                MdlUser.IdUsuario = Convert.ToInt32(rs["NPTIDLOGIN"].ToString());
                MdlUser.Usuario = rs["NPTUSUARIO"].ToString();
                MdlUser.Password = rs["NPTPASSWORD"].ToString();
                MdlUser.Area =  rs["NPTAREA"].ToString();
                MdlUser.Acesso = rs["NPTACESSO"].ToString();
            }

            conn.Close();
            conn.Dispose();

            return MdlUser;
        }
        public List<User> ReturnUserList()
        {
            DBFactory factory = new DBFactory();
            SqlConnection conn = factory.Conection();
            SqlCommand command = conn.CreateCommand();

            command.CommandText = @"SELECT NPTIDLOGIN, NPTUSUARIO , NPTPASSWORD , NPTAREA , NPTACESSO FROM NPTLOGIN";

            SqlDataReader rs = command.ExecuteReader();

            List<User> lstUser = new List<User>();

            while (rs.Read())
            {
                User user = new User();

                user.IdUsuario = Convert.ToInt32(rs["NPTIDLOGIN"].ToString());
                user.Usuario = rs["NPTUSUARIO"].ToString();
                user.Password = rs["NPTPASSWORD"].ToString();
                user.Area = rs["NPTAREA"].ToString();
                user.Acesso = rs["NPTACESSO"].ToString();

                lstUser.Add(user);
                    
            }

            conn.Close();

            return lstUser;

            
        }
        public void CreateUser(User user)
        {
            DBFactory factory = new DBFactory();

            SqlConnection conn = factory.Conection();
            SqlTransaction transaction = null;
            SqlCommand command = conn.CreateCommand();

            try
            {
                transaction = conn.BeginTransaction();

                command.Transaction = transaction;

                string insertCommand = @"insert into NPTLOGIN (nptusuario , nptpassword, nptarea , nptacesso) VALUES (@nptusuario, @nptpassword, @nptarea , @nptacesso)";

                command.Parameters.AddWithValue("@nptusuario", user.Usuario);
                command.Parameters.AddWithValue("@nptpassword", user.Password);
                command.Parameters.AddWithValue("@nptarea", user.Area);
                command.Parameters.AddWithValue("@nptacesso", Convert.ToInt32(user.Acesso));

                command.CommandText = insertCommand;
                command.ExecuteNonQuery();
                transaction.Commit();
            }

            catch (Exception ex)
            {

                if (transaction != null) transaction.Rollback();

                MessageBox.Show("Ocorreu um erro ao inserir os dados na tabela.\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }
        public void ResetPassword(User user)
        {
            DBFactory factory = new DBFactory();

            SqlConnection conn = factory.Conection();
            SqlTransaction transaction = null;
            SqlCommand command = conn.CreateCommand();

            try
            {
                transaction = conn.BeginTransaction();

                command.Transaction = transaction;

                string updatecommand = @"UPDATE NPTLOGIN SET nptpassword = @nptpassword WHERE nptidlogin = @nptidlogin";

                command.Parameters.AddWithValue("@nptpassword", user.Password);
                command.Parameters.AddWithValue("@nptidlogin", user.IdUsuario);

                command.CommandText = updatecommand;

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {

                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Ocorreu um erro ao alterar os dados na tabela.\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }

            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void DeleteUser(User user) { }
    }
}

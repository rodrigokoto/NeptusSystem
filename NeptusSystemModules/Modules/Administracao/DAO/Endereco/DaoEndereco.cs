using NeptusSystemModules.Modules.Administracao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules.Administracao.DAO
{
    public class DaoEndereco
    {
        public SqlConnection Sqlcon { get; private set; }

        public int Insert_Endereco(Endereco endereco)
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
                string insertCommand = @"INSERT INTO NPTEND (ENDRUA, ENDBAIRRO, ENDCIDADE, ENDCOMPLEMENTO, ENDNUM, ENDCEP, ENDUF) OUTPUT INSERTED.ENDID VALUES(@ENDRUA, @ENDBAIRRO, @ENDCIDADE, @ENDCOMPLEMENTO, @ENDNUM, @ENDCEP, @ENDUF)";

                command.Parameters.AddWithValue("@ENDRUA", endereco.ENDRUA);
                command.Parameters.AddWithValue("@ENDBAIRRO", endereco.ENDBAIRRO);
                command.Parameters.AddWithValue("@ENDCIDADE", endereco.ENDCIDADE);
                command.Parameters.AddWithValue("@ENDCOMPLEMENTO", endereco.ENDCOMPLEMENTO);
                command.Parameters.AddWithValue("@ENDNUM", endereco.ENDNUM);
                command.Parameters.AddWithValue("@ENDCEP", endereco.ENDCEP);
                command.Parameters.AddWithValue("@ENDUF", endereco.ENDUF);
                
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

        public Endereco ReturnEndereco(int id)
        {
            Endereco endereco = new Endereco();

            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlCommand command = con.NeptusConection.Connection.CreateCommand();

            string selectCommand = @"SELECT ENDID,ENDRUA,ENDBAIRRO,ENDCIDADE,ENDCOMPLEMENTO,ENDNUM,ENDCEP,ENDUF  FROM NPTEND WHERE ENDID = @ENDID";

            command.CommandText = selectCommand;

            command.Parameters.AddWithValue("@ENDID", id);

            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                endereco.ENDID = Convert.ToInt32(rs["ENDID"].ToString());
                endereco.ENDRUA = rs["ENDRUA"].ToString();
                endereco.ENDBAIRRO = rs["ENDBAIRRO"].ToString();
                endereco.ENDCIDADE = rs["ENDCIDADE"].ToString();
                endereco.ENDCOMPLEMENTO = rs["ENDCOMPLEMENTO"].ToString();
                endereco.ENDNUM = rs["ENDNUM"].ToString();
                endereco.ENDCEP = rs["ENDCEP"].ToString();
                endereco.ENDUF = rs["ENDUF"].ToString();
            }

            Sqlcon.Close();

            return endereco;
        }

        public void Update_Endereco(Endereco endereco)
        {
            Connection con = Connection.Instance;
            Sqlcon = con.NeptusConection.Connection;
            SqlTransaction transaction = null;

            try
            {
                SqlCommand command = Sqlcon.CreateCommand();
                transaction = Sqlcon.BeginTransaction();
                command.Transaction = transaction;
                string updateCommand = @"UPDATE NPTEND SET ENDRUA = @ENDRUA , ENDBAIRRO = @ENDBAIRRO, ENDCIDADE = @ENDCIDADE, ENDCOMPLEMENTO = @ENDCOMPLEMENTO, ENDNUM = @ENDNUM, ENDCEP = @ENDCEP, ENDUF = @ENDUF WHERE ENDID = @ENDID";

                command.Parameters.AddWithValue("@ENDRUA", endereco.ENDRUA);
                command.Parameters.AddWithValue("@ENDBAIRRO", endereco.ENDBAIRRO);
                command.Parameters.AddWithValue("@ENDCIDADE", endereco.ENDCIDADE);
                command.Parameters.AddWithValue("@ENDCOMPLEMENTO", endereco.ENDCOMPLEMENTO);
                command.Parameters.AddWithValue("@ENDNUM", endereco.ENDNUM);
                command.Parameters.AddWithValue("@ENDCEP", endereco.ENDCEP);
                command.Parameters.AddWithValue("@ENDUF", endereco.ENDUF);

                command.Parameters.AddWithValue("@ENDID", endereco.ENDID);

                command.CommandText = updateCommand;
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
    }
}

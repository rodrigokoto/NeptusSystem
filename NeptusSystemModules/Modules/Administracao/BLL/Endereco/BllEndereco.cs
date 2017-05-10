using NeptusSystemModules.Modules.Administracao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.BLL
{
    public class BllEndereco
    {
        public int Insert_Endereco(Endereco endereco)
        {
            return new DAO.DaoEndereco().Insert_Endereco(endereco);
        }

        public Endereco Return_Endereco(int id)
        {
            return new DAO.DaoEndereco().ReturnEndereco(id);
        }

        public void Update_Endereco(Endereco endereco)
        {
            new DAO.DaoEndereco().Update_Endereco(endereco);
        }
    }
}

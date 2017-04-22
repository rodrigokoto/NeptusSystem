using NeptusSystemModules.Modules.Administracao.Model.Proprietario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.BLL
{
    public class BllProprietario
    {
        public void Insert_Proprietario(Proprietario proprietario)
        {
            new DAO.DaoProprietario().Insert_Proprietario(proprietario);
        }

        public List<Proprietario> Return_ListProprietario()
        {
            return new DAO.DaoProprietario().Return_ListProprietario();
        }

        public Proprietario Return_Proprietario(int id)
        {
            return new DAO.DaoProprietario().Return_Proprietario(id);
        }

        public void Update_Proprietario(Proprietario proprietario)
        {
            new DAO.DaoProprietario().Update_Proprietario(proprietario);
        }
    }
}

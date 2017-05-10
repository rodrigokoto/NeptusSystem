using NeptusSystemModules.Modules.Administracao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.BLL
{
    public class BllGaragem
    {
        public int Insert_Garagem(Garagem garagem)
        {
            return new DAO.DaoGaragem().Insert_Garagem(garagem);
        }

        public List<Garagem> Return_ListGaragem()
        {
            return new DAO.DaoGaragem().Return_ListGaragem();
        }

        public void Delete_Garagem()
        {
            new DAO.DaoGaragem().Delete_Garagem();
        }
    }
}

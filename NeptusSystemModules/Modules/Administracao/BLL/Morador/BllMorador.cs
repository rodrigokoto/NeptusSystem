using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.BLL
{
    public class BllMorador
    {
        public void Insert_Morador(Model.Morador morador)
        {
            new DAO.DaoMorador().Insert_Morador(morador);
        }

        public void Update_Proprietario(Model.Morador morador)
        {
            new DAO.DaoMorador().Update_Proprietario(morador);
        }

        public List<Model.Morador> Return_ListMorador()
        {
            return new DAO.DaoMorador().Return_ListMorador();
        }

        public Model.Morador Return_Morador(int id)
        {
            return new DAO.DaoMorador().Return_Morador(id);
        }
    }
}

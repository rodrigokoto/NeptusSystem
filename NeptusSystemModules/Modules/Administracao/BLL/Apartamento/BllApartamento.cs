using NeptusSystemModules.Modules.Administracao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.BLL
{
    public class BllApartamento
    {
        public int Insert_Apartamento(Apartamento apartamento)
        {
            return new DAO.DaoApartamento().Insert_Apartamento(apartamento);
        }

        public List<Apartamento> Return_ListApartamento()
        {
            return new DAO.DaoApartamento().Return_ListApartamento();
        }

        public void Delete_Apartamentos()
        {
            new DAO.DaoApartamento().Delete_Apartamentos();
        }

        public List<Apartamento> Retorna_Cadastrados()
        {
            return new DAO.DaoApartamento().Retorna_Cadastrados();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystem.Model
{
    public class User
    {
        private int _idUsuario;
        private string _usuario;
        private string _password;
        private string _area;
        private string _acesso;



        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public string Acesso
        {
            get { return _acesso; }
            set { _acesso = value; }
        }

        public int IdUsuario
        {
            get
            {
                return _idUsuario;
            }

            set
            {
                _idUsuario = value;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystem.Session
{
    public class Session
    {
        private static Session instance = null;

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }

            set
            {
                instance = value;
            }
        }


        private string _sessionUser;
        private string _sessionPassword;
        private string _sessionAcesso;
        private string _sessionArea;
        private DateTime _sessionStart;

       
        public string SessionUser
        {
            get
            {
                return _sessionUser;
            }

            set
            {
                _sessionUser = value;
            }
        }

        public string SessionPassword
        {
            get
            {
                return _sessionPassword;
            }

            set
            {
                _sessionPassword = value;
            }
        }

        public DateTime SessionStart
        {
            get
            {
                return _sessionStart;
            }

            set
            {
                _sessionStart = value;
            }
        }

        public string SessionArea
        {
            get
            {
                return _sessionArea;
            }

            set
            {
                _sessionArea = value;
            }
        }

        public string SessionAcesso
        {
            get
            {
                return _sessionAcesso;
            }

            set
            {
                _sessionAcesso = value;
            }
        }
    }
}
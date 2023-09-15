using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSistem.Clases
{
    static class Global
    {
        private static int _globalVarId = 0;
        private static string _globalVarNombre = "";
        private static string _globalVarClave = "";
        private static int _globalVarPerfil = 0;

        public static int GlobalVarId
        {
            get { return _globalVarId; }
            set { _globalVarId = value; }
        }
        public static string GlobalVarNombre
        {
            get { return _globalVarNombre; }
            set { _globalVarNombre = value; }
        }

        public static string GlobalVarClave
        {
            get { return _globalVarClave; }
            set { _globalVarClave = value; }
        }

        public static int GlobalVarPerfil
        {
            get { return _globalVarPerfil; }
            set { _globalVarPerfil = value; }
        }
    }
}

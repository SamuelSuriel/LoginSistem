﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSistem.Clases
{
    public class Usuarios
    {
        public int UsuarioID { get; set; }
        public string? Nombre { get; set; }
        public string? Clave { get; set; }
        public int? IdPerfil { get; set; }
    }
}

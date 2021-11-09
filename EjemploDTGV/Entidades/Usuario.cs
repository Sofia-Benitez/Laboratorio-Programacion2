﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        int codigoUsuario;
        string username;

        public Usuario(int codigoUsuario, string username)
        {
            this.codigoUsuario = codigoUsuario;
            this.username = username;
        }

        public int CodigoUsuario { get => codigoUsuario;  }

        public override string ToString()
        {
            return this.username;
        }
    }
}

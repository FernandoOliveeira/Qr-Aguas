﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Models
{
    class NewUser
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public int IdTipoUsuario { get; set; }
        public string CadastradoPor { get; set; }

    }
}

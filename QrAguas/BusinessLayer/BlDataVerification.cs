using QrAguas.Controls;
using QrAguas.Models;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.BusinessLayer
{
    class BlDataVerification : Connection
    {
        public bool VerificarDadosUsuario(NewUser usuario)
        {
            if (!String.IsNullOrEmpty(usuario.NomeUsuario) &&
                !String.IsNullOrEmpty(usuario.Senha) &&
                !String.IsNullOrEmpty(usuario.IdTipoUsuario.ToString()) &&
                !String.IsNullOrEmpty(usuario.CadastradoPor))
            {
                return true;
            }

            return false;
        }
    }
}

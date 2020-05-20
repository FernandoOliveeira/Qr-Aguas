using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class ChangePasswordMethods : Connection
    {
        public bool AlterarSenha(string senha, string nomeUsuario)
        {
            string queryAlterarSenha = "UPDATE USUARIOS SET SENHA = @Senha WHERE NOME_USUARIO = @NomeUsuario";

            MySqlCommand command = new MySqlCommand(queryAlterarSenha, AbrirBanco());

            command.Parameters.AddWithValue("@Senha", senha);
            command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

            int rowCount = command.ExecuteNonQuery();

            if (rowCount != 0)
            {
                string querySenhaAlterada = "UPDATE USUARIOS SET DATA_SENHA_ALTERADA  = @DataAtual WHERE NOME_USUARIO = @NomeUsuario";

                MySqlCommand commandSenhaAlterada = new MySqlCommand(querySenhaAlterada, AbrirBanco());

                commandSenhaAlterada.Parameters.AddWithValue("@DataAtual", DateTime.Now);
                commandSenhaAlterada.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                commandSenhaAlterada.ExecuteNonQuery();

                FecharBanco(AbrirBanco());

                return true;
            }

            FecharBanco(AbrirBanco());

            return false;
        }

    }
}

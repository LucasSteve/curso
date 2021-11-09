using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFaculdade.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool Verificarlogin(string login, string senha)
        {

            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }

                con.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no banco de dados! Erro: " + e;
            }

            return tem;
        }

        internal string cadastrar(string email, string senha, string confsenha)
        {
            tem = false;

            if (senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into logins(email,senha) values (@email,@senha)";
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Usuario cadastrado com sucesso!";

                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o banco de dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}

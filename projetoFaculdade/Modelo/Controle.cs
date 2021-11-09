using projetoFaculdade.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projetoFaculdade.Modelo
{
    class Controle
    {
        public bool validacao;
        public string mensagem = "";
        public bool Acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           validacao = loginDao.Verificarlogin(login, senha);
            if (loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return validacao;
        }

        public string cadastrar(string email, string senha, string confsenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();

            this.mensagem = loginDao.cadastrar(email, senha, confsenha);
            if (loginDao.tem)
            {
                this.validacao = true;
            }

            return mensagem;
        }
    }
}

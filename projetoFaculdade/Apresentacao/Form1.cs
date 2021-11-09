using projetoFaculdade.Apresentacao;
using projetoFaculdade.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFaculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();         
            cad.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txtLogin.Text,txtSenha.Text);
            if (controle.mensagem.Equals("")) 
            { 
             if (controle.validacao)
             {
                MessageBox.Show("Logado com Sucesso!");
                    TelaPrincipal tp = new TelaPrincipal();
                    tp.Show();
                   this.Hide();
             }
             else
             {
                MessageBox.Show("Login invalido!");
             }
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

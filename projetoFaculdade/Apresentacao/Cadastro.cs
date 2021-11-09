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

namespace projetoFaculdade.Apresentacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Controle controle = new Controle();
            string mensagem = controle.cadastrar(textBox1.Text, txtsenha.Text,txtconfirmasenha.Text);
            if (textBox1.Text == "" || txtsenha.Text == "" || txtconfirmasenha.Text == "")
            {
                MessageBox.Show("Campos em braco!");
            }
            else
            {
                if (controle.validacao)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

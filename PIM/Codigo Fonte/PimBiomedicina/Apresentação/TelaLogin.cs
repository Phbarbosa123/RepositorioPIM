using PimBiomedicina.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PimBiomedicina
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaMenuEst tela = new TelaMenuEst();
            tela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.entrar(txtusuario.Text, txtsenha.Text);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso");
            }
            else
            {
                MessageBox.Show("Login ou senha estão incorretos");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com seu coordenador!");
            TelaMenuAdm telaMenuAdm = new TelaMenuAdm();
            telaMenuAdm.Show();
            this.Hide();
        }
    }
}

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
    public partial class TelaMenuAdm : Form
    {
        public TelaMenuAdm()
        {
            InitializeComponent();
       
        }

        private void TelaMenuAdm_Load(object sender, EventArgs e)
        {
            
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPacAdm CadPac = new CadPacAdm();
            CadPac.MdiParent = this;
            CadPac.Show();
        }

        private void estagiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEst CadEst = new CadEst();
            CadEst.MdiParent = this;
            CadEst.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPac ConPac = new ConsultaPac();
            ConPac.MdiParent = this;
            ConPac.Show();
        }

        private void estagiárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEst ConEst = new ConsultaEst();
            ConEst.MdiParent = this;
            ConEst.Show();

        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento Agenda = new Agendamento();
            Agenda.MdiParent = this;
            Agenda.Show();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void físicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmUrinalise frmUrinalise = new Apresentação.frmUrinalise();
            frmUrinalise.Show();
        }

        private void químicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.UriQui uriQui = new Apresentação.UriQui();
            uriQui.Show();
        }

        private void sedimentoscopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.UriSed uriSed = new Apresentação.UriSed();
            uriSed.Show();
        }

        private void bioquímicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmBioquimica frmBioquimica = new Apresentação.frmBioquimica();
            frmBioquimica.Show();
        }

        private void herToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmHematologia frmHematologia = new Apresentação.frmHematologia();
            frmHematologia.Show();
        }

        private void microbiologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmMicrobiologia frmMicrobiologia = new Apresentação.frmMicrobiologia();
            frmMicrobiologia.Show();
        }
    }
}

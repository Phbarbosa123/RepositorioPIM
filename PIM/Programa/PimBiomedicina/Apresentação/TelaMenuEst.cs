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
    public partial class TelaMenuEst : Form
    {
        public TelaMenuEst()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPacEst CadPac = new CadPacEst();
            CadPac.MdiParent = this;
            CadPac.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPac ConsultaPac = new ConsultaPac();
            ConsultaPac.MdiParent = this;
            ConsultaPac.Show();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento Agenda = new Agendamento();
            Agenda.MdiParent = this;
            Agenda.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void físicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmUrinalise urinalise = new Apresentação.frmUrinalise();
            urinalise.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
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

        private void hematologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmBioquimica bioquimica = new Apresentação.frmBioquimica();
            bioquimica.Show();
        }

        private void hematologiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Apresentação.frmHematologia hematologia = new Apresentação.frmHematologia();
            hematologia.Show();
        }

        private void microbiologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação.frmMicrobiologia microbiologia = new Apresentação.frmMicrobiologia();
            microbiologia.Show();
        }
    }
}

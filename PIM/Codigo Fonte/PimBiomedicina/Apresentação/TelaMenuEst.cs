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

        }
    }
}

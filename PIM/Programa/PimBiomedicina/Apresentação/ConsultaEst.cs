using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PimBiomedicina.Modelo
{
    public partial class ConsultaEst : Form
    {
        public ConsultaEst()
        {
            InitializeComponent();
        }

        private void ConsultaEst_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.estagiario'. Você pode movê-la ou removê-la conforme necessário.
            this.estagiarioTableAdapter.Fill(this.testePimDataSet.estagiario);

        }
    }
}

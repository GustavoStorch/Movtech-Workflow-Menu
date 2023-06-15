using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuWorkflow
{
    public partial class FormMenuWorkflow : Form
    {
        public FormMenuWorkflow()
        {
            InitializeComponent();
        }

        private void cadastroEtapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movtech_WorkFlow.FormCadEtapas formCadEtapas = new Movtech_WorkFlow.FormCadEtapas();
            formCadEtapas.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movtech_Workflow_Pedidos.FormWorkflowPedidos formWorkflowPedidos = new Movtech_Workflow_Pedidos.FormWorkflowPedidos();
            formWorkflowPedidos.ShowDialog();
        }
    }
}

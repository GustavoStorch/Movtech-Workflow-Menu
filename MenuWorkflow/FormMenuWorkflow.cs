using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuWorkflow
{
    public partial class FormMenuWorkflow : Form
    {
        public string nomeUsuario { get; set; }

        public FormMenuWorkflow(String NomeUsuario)
        {
            InitializeComponent();
            nomeUsuario = NomeUsuario;
        }

        private void cadastroEtapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movtech_WorkFlow.FormCadEtapas formCadEtapas = new Movtech_WorkFlow.FormCadEtapas();
            formCadEtapas.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movtech_Workflow_Pedidos.FormWorkflowPedidos formWorkflowPedidos = new Movtech_Workflow_Pedidos.FormWorkflowPedidos(nomeUsuario);
            formWorkflowPedidos.ShowDialog();
        }

        private void FormMenuWorkflow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuWorkflow
{
    public partial class FormLoginWorkflow : System.Windows.Forms.Form
    {
        public FormLoginWorkflow()
        {
            InitializeComponent();
        }

        private void FormLoginWorkflow_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    LoginDAO dao = new LoginDAO(connection);
                    FormMenuWorkflow formMenuWorkflow = new FormMenuWorkflow();

                    bool verifica = dao.VerificaLogin(new LoginModel()
                    {
                        Usuario = txtNomeUsuário.Text,
                        Senha = txtSenhaUsuario.Text
                    });

                    if (verifica)
                    {
                        MessageBox.Show("Logado com sucesso!");
                        formMenuWorkflow.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
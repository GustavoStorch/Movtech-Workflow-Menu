namespace MenuWorkflow
{
    partial class FormMenuWorkflow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuWorkflow));
            this.menuWorkflow = new System.Windows.Forms.MenuStrip();
            this.cadastroEtapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgMenuWork = new System.Windows.Forms.PictureBox();
            this.lblDataSimulacao = new System.Windows.Forms.Label();
            this.dtpDataSimulacao = new System.Windows.Forms.DateTimePicker();
            this.menuWorkflow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuWork)).BeginInit();
            this.SuspendLayout();
            // 
            // menuWorkflow
            // 
            this.menuWorkflow.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuWorkflow.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuWorkflow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroEtapaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuWorkflow.Location = new System.Drawing.Point(0, 0);
            this.menuWorkflow.Name = "menuWorkflow";
            this.menuWorkflow.Size = new System.Drawing.Size(691, 36);
            this.menuWorkflow.TabIndex = 0;
            this.menuWorkflow.Text = "menuStrip1";
            // 
            // cadastroEtapaToolStripMenuItem
            // 
            this.cadastroEtapaToolStripMenuItem.Name = "cadastroEtapaToolStripMenuItem";
            this.cadastroEtapaToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.cadastroEtapaToolStripMenuItem.Text = "Cadastro Etapa";
            this.cadastroEtapaToolStripMenuItem.Click += new System.EventHandler(this.cadastroEtapaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // imgMenuWork
            // 
            this.imgMenuWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMenuWork.Image = global::MenuWorkflow.Properties.Resources.movtech2;
            this.imgMenuWork.Location = new System.Drawing.Point(67, 62);
            this.imgMenuWork.Name = "imgMenuWork";
            this.imgMenuWork.Size = new System.Drawing.Size(551, 286);
            this.imgMenuWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMenuWork.TabIndex = 2;
            this.imgMenuWork.TabStop = false;
            // 
            // lblDataSimulacao
            // 
            this.lblDataSimulacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDataSimulacao.AutoSize = true;
            this.lblDataSimulacao.Location = new System.Drawing.Point(12, 377);
            this.lblDataSimulacao.Name = "lblDataSimulacao";
            this.lblDataSimulacao.Size = new System.Drawing.Size(138, 20);
            this.lblDataSimulacao.TabIndex = 3;
            this.lblDataSimulacao.Text = "Data para simular:";
            // 
            // dtpDataSimulacao
            // 
            this.dtpDataSimulacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataSimulacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSimulacao.Location = new System.Drawing.Point(156, 372);
            this.dtpDataSimulacao.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataSimulacao.Name = "dtpDataSimulacao";
            this.dtpDataSimulacao.Size = new System.Drawing.Size(139, 26);
            this.dtpDataSimulacao.TabIndex = 4;
            this.dtpDataSimulacao.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataSimulacao.ValueChanged += new System.EventHandler(this.dtpDataSimulacao_ValueChanged);
            // 
            // FormMenuWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 416);
            this.Controls.Add(this.dtpDataSimulacao);
            this.Controls.Add(this.lblDataSimulacao);
            this.Controls.Add(this.imgMenuWork);
            this.Controls.Add(this.menuWorkflow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuWorkflow;
            this.Name = "FormMenuWorkflow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workflow Movtech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuWorkflow_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuWorkflow_Load);
            this.menuWorkflow.ResumeLayout(false);
            this.menuWorkflow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuWorkflow;
        private System.Windows.Forms.ToolStripMenuItem cadastroEtapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgMenuWork;
        private System.Windows.Forms.Label lblDataSimulacao;
        private System.Windows.Forms.DateTimePicker dtpDataSimulacao;
    }
}
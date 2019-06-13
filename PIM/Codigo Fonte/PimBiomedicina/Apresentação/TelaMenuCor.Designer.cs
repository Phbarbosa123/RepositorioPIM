namespace PimBiomedicina
{
    partial class TelaMenuAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenuAdm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConPac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConEst = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadPac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadEst = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExames = new System.Windows.Forms.ToolStripMenuItem();
            this.urináliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.físicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.químicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sedimentoscopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.bioquímicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microbiologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConsulta,
            this.tsmCadastro,
            this.tsmAgendamento,
            this.tsmExames});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConPac,
            this.tsmConEst});
            this.tsmConsulta.Image = global::PimBiomedicina.Properties.Resources.zoom;
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(82, 20);
            this.tsmConsulta.Text = "&Consulta";
            // 
            // tsmConPac
            // 
            this.tsmConPac.Name = "tsmConPac";
            this.tsmConPac.Size = new System.Drawing.Size(125, 22);
            this.tsmConPac.Text = "&Pacientes";
            this.tsmConPac.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // tsmConEst
            // 
            this.tsmConEst.Name = "tsmConEst";
            this.tsmConEst.Size = new System.Drawing.Size(125, 22);
            this.tsmConEst.Text = "&Estagiário";
            this.tsmConEst.Click += new System.EventHandler(this.estagiárioToolStripMenuItem1_Click);
            // 
            // tsmCadastro
            // 
            this.tsmCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadPac,
            this.tsmCadEst});
            this.tsmCadastro.Image = global::PimBiomedicina.Properties.Resources.add;
            this.tsmCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmCadastro.Name = "tsmCadastro";
            this.tsmCadastro.Size = new System.Drawing.Size(82, 20);
            this.tsmCadastro.Text = "&Cadastro";
            this.tsmCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmCadPac
            // 
            this.tsmCadPac.Name = "tsmCadPac";
            this.tsmCadPac.Size = new System.Drawing.Size(125, 22);
            this.tsmCadPac.Text = "&Pacientes";
            this.tsmCadPac.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // tsmCadEst
            // 
            this.tsmCadEst.Name = "tsmCadEst";
            this.tsmCadEst.Size = new System.Drawing.Size(125, 22);
            this.tsmCadEst.Text = "&Estagiário";
            this.tsmCadEst.Click += new System.EventHandler(this.estagiárioToolStripMenuItem_Click);
            // 
            // tsmAgendamento
            // 
            this.tsmAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("tsmAgendamento.Image")));
            this.tsmAgendamento.Name = "tsmAgendamento";
            this.tsmAgendamento.Size = new System.Drawing.Size(111, 20);
            this.tsmAgendamento.Text = "&Agendamento";
            this.tsmAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmAgendamento.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // tsmExames
            // 
            this.tsmExames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urináliseToolStripMenuItem,
            this.bioquímicaToolStripMenuItem,
            this.herToolStripMenuItem,
            this.microbiologiaToolStripMenuItem});
            this.tsmExames.Image = ((System.Drawing.Image)(resources.GetObject("tsmExames.Image")));
            this.tsmExames.Name = "tsmExames";
            this.tsmExames.Size = new System.Drawing.Size(74, 20);
            this.tsmExames.Text = "&Exames";
            // 
            // urináliseToolStripMenuItem
            // 
            this.urináliseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.físicoToolStripMenuItem,
            this.químicoToolStripMenuItem,
            this.sedimentoscopiaToolStripMenuItem});
            this.urináliseToolStripMenuItem.Name = "urináliseToolStripMenuItem";
            this.urináliseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urináliseToolStripMenuItem.Text = "Urinálise";
            // 
            // físicoToolStripMenuItem
            // 
            this.físicoToolStripMenuItem.Name = "físicoToolStripMenuItem";
            this.físicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.físicoToolStripMenuItem.Text = "Físico";
            this.físicoToolStripMenuItem.Click += new System.EventHandler(this.físicoToolStripMenuItem_Click);
            // 
            // químicoToolStripMenuItem
            // 
            this.químicoToolStripMenuItem.Name = "químicoToolStripMenuItem";
            this.químicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.químicoToolStripMenuItem.Text = "Químico";
            this.químicoToolStripMenuItem.Click += new System.EventHandler(this.químicoToolStripMenuItem_Click);
            // 
            // sedimentoscopiaToolStripMenuItem
            // 
            this.sedimentoscopiaToolStripMenuItem.Name = "sedimentoscopiaToolStripMenuItem";
            this.sedimentoscopiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sedimentoscopiaToolStripMenuItem.Text = "Sedimentoscopia";
            this.sedimentoscopiaToolStripMenuItem.Click += new System.EventHandler(this.sedimentoscopiaToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(724, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bioquímicaToolStripMenuItem
            // 
            this.bioquímicaToolStripMenuItem.Name = "bioquímicaToolStripMenuItem";
            this.bioquímicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bioquímicaToolStripMenuItem.Text = "Bioquímica";
            this.bioquímicaToolStripMenuItem.Click += new System.EventHandler(this.bioquímicaToolStripMenuItem_Click);
            // 
            // herToolStripMenuItem
            // 
            this.herToolStripMenuItem.Name = "herToolStripMenuItem";
            this.herToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.herToolStripMenuItem.Text = "Hematologia";
            this.herToolStripMenuItem.Click += new System.EventHandler(this.herToolStripMenuItem_Click);
            // 
            // microbiologiaToolStripMenuItem
            // 
            this.microbiologiaToolStripMenuItem.Name = "microbiologiaToolStripMenuItem";
            this.microbiologiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.microbiologiaToolStripMenuItem.Text = "Microbiologia";
            this.microbiologiaToolStripMenuItem.Click += new System.EventHandler(this.microbiologiaToolStripMenuItem_Click);
            // 
            // TelaMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "TelaMenuAdm";
            this.Text = "TelaMenuAdm";
            this.Load += new System.EventHandler(this.TelaMenuAdm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmConPac;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmCadPac;
        private System.Windows.Forms.ToolStripMenuItem tsmAgendamento;
        private System.Windows.Forms.ToolStripMenuItem tsmConEst;
        private System.Windows.Forms.ToolStripMenuItem tsmCadEst;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem tsmExames;
        private System.Windows.Forms.ToolStripMenuItem urináliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem físicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem químicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sedimentoscopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bioquímicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microbiologiaToolStripMenuItem;
    }
}
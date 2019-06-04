namespace PimBiomedicina.Modelo
{
    partial class ConsultaPac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPac));
            this.label15 = new System.Windows.Forms.Label();
            this.txtconnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconcpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconnome = new System.Windows.Forms.Button();
            this.btnconcpf = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(113, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(286, 31);
            this.label15.TabIndex = 45;
            this.label15.Text = "Consulta de Pacientes";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtconnome
            // 
            this.txtconnome.Location = new System.Drawing.Point(190, 75);
            this.txtconnome.Name = "txtconnome";
            this.txtconnome.Size = new System.Drawing.Size(182, 20);
            this.txtconnome.TabIndex = 38;
            this.txtconnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(86, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Consulta por nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtconcpf
            // 
            this.txtconcpf.Location = new System.Drawing.Point(190, 124);
            this.txtconcpf.Name = "txtconcpf";
            this.txtconcpf.Size = new System.Drawing.Size(182, 20);
            this.txtconcpf.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(86, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Consulta por CPF:";
            // 
            // btnconnome
            // 
            this.btnconnome.Image = global::PimBiomedicina.Properties.Resources.zoom;
            this.btnconnome.Location = new System.Drawing.Point(398, 72);
            this.btnconnome.Name = "btnconnome";
            this.btnconnome.Size = new System.Drawing.Size(33, 25);
            this.btnconnome.TabIndex = 48;
            this.btnconnome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconnome.UseVisualStyleBackColor = true;
            // 
            // btnconcpf
            // 
            this.btnconcpf.Image = global::PimBiomedicina.Properties.Resources.zoom;
            this.btnconcpf.Location = new System.Drawing.Point(398, 124);
            this.btnconcpf.Name = "btnconcpf";
            this.btnconcpf.Size = new System.Drawing.Size(33, 25);
            this.btnconcpf.TabIndex = 49;
            this.btnconcpf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconcpf.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(420, 204);
            this.dataGridView1.TabIndex = 50;
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnconcpf);
            this.Controls.Add(this.btnconnome);
            this.Controls.Add(this.txtconcpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtconnome);
            this.Controls.Add(this.label1);
            this.Name = "TelaConsulta";
            this.Text = "TelaConsulta";
            this.Load += new System.EventHandler(this.TelaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtconnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconcpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconnome;
        private System.Windows.Forms.Button btnconcpf;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
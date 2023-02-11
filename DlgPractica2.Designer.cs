namespace PE22B_MAv2
{
    partial class DlgPractica2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica2));
            this.P2DgvDatos = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2PnlFiltros = new System.Windows.Forms.Panel();
            this.P2BtnImportar = new System.Windows.Forms.Button();
            this.P2BtnLlenar = new System.Windows.Forms.Button();
            this.P2CbxFiltro = new System.Windows.Forms.ComboBox();
            this.P2TbxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.P2DgvDatos)).BeginInit();
            this.P2PnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // P2DgvDatos
            // 
            this.P2DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P2DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombre,
            this.ColApellidoP,
            this.ColApellidoM,
            this.ColFechaNac,
            this.ColRFC});
            this.P2DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P2DgvDatos.Location = new System.Drawing.Point(0, 73);
            this.P2DgvDatos.Name = "P2DgvDatos";
            this.P2DgvDatos.Size = new System.Drawing.Size(900, 377);
            this.P2DgvDatos.TabIndex = 5;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigó";
            this.ColCodigo.Name = "ColCodigo";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 200;
            // 
            // ColApellidoP
            // 
            this.ColApellidoP.HeaderText = "Apellido Paterno";
            this.ColApellidoP.Name = "ColApellidoP";
            this.ColApellidoP.Width = 150;
            // 
            // ColApellidoM
            // 
            this.ColApellidoM.HeaderText = "Apellido Materno";
            this.ColApellidoM.Name = "ColApellidoM";
            this.ColApellidoM.Width = 150;
            // 
            // ColFechaNac
            // 
            this.ColFechaNac.HeaderText = "Fecha Nacimiento";
            this.ColFechaNac.Name = "ColFechaNac";
            // 
            // ColRFC
            // 
            this.ColRFC.HeaderText = "RFC";
            this.ColRFC.Name = "ColRFC";
            // 
            // P2PnlFiltros
            // 
            this.P2PnlFiltros.BackColor = System.Drawing.Color.Black;
            this.P2PnlFiltros.Controls.Add(this.P2BtnImportar);
            this.P2PnlFiltros.Controls.Add(this.P2BtnLlenar);
            this.P2PnlFiltros.Controls.Add(this.P2CbxFiltro);
            this.P2PnlFiltros.Controls.Add(this.P2TbxNombre);
            this.P2PnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.P2PnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.P2PnlFiltros.Name = "P2PnlFiltros";
            this.P2PnlFiltros.Size = new System.Drawing.Size(900, 73);
            this.P2PnlFiltros.TabIndex = 4;
            // 
            // P2BtnImportar
            // 
            this.P2BtnImportar.Location = new System.Drawing.Point(361, 17);
            this.P2BtnImportar.Name = "P2BtnImportar";
            this.P2BtnImportar.Size = new System.Drawing.Size(75, 23);
            this.P2BtnImportar.TabIndex = 5;
            this.P2BtnImportar.Text = "Importar";
            this.P2BtnImportar.UseVisualStyleBackColor = true;
            this.P2BtnImportar.Click += new System.EventHandler(this.P2BtnImportar_Click);
            // 
            // P2BtnLlenar
            // 
            this.P2BtnLlenar.Location = new System.Drawing.Point(280, 17);
            this.P2BtnLlenar.Name = "P2BtnLlenar";
            this.P2BtnLlenar.Size = new System.Drawing.Size(75, 23);
            this.P2BtnLlenar.TabIndex = 4;
            this.P2BtnLlenar.Text = "Llenar datos";
            this.P2BtnLlenar.UseVisualStyleBackColor = true;
            this.P2BtnLlenar.Click += new System.EventHandler(this.P2BtnLlenar_Click);
            // 
            // P2CbxFiltro
            // 
            this.P2CbxFiltro.FormattingEnabled = true;
            this.P2CbxFiltro.Location = new System.Drawing.Point(153, 18);
            this.P2CbxFiltro.Name = "P2CbxFiltro";
            this.P2CbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.P2CbxFiltro.TabIndex = 3;
            // 
            // P2TbxNombre
            // 
            this.P2TbxNombre.Location = new System.Drawing.Point(8, 19);
            this.P2TbxNombre.Name = "P2TbxNombre";
            this.P2TbxNombre.Size = new System.Drawing.Size(139, 20);
            this.P2TbxNombre.TabIndex = 1;
            // 
            // DlgPractica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.P2DgvDatos);
            this.Controls.Add(this.P2PnlFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPractica2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgPractica2";
            ((System.ComponentModel.ISupportInitialize)(this.P2DgvDatos)).EndInit();
            this.P2PnlFiltros.ResumeLayout(false);
            this.P2PnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView P2DgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRFC;
        private System.Windows.Forms.Panel P2PnlFiltros;
        private System.Windows.Forms.Button P2BtnImportar;
        private System.Windows.Forms.Button P2BtnLlenar;
        private System.Windows.Forms.ComboBox P2CbxFiltro;
        private System.Windows.Forms.TextBox P2TbxNombre;
    }
}
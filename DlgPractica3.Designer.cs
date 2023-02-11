namespace PE22B_MAv2
{
    partial class DlgPractica3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica3));
            this.P3DgvFlujosEfectivo = new System.Windows.Forms.DataGridView();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.P3PnlImagen = new System.Windows.Forms.Panel();
            this.P3PnlLateral = new System.Windows.Forms.Panel();
            this.P3BtnLimpiar = new System.Windows.Forms.Button();
            this.P3BtnCalcular = new System.Windows.Forms.Button();
            this.P3TbxResultado = new System.Windows.Forms.TextBox();
            this.P3LblResultado = new System.Windows.Forms.Label();
            this.P3TbxTMAR = new System.Windows.Forms.TextBox();
            this.P3LblTMAR = new System.Windows.Forms.Label();
            this.P3TbxInversionI = new System.Windows.Forms.TextBox();
            this.P3LbInversionI = new System.Windows.Forms.Label();
            this.P3PnlSuperior = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.P3LblNombreP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P3DgvFlujosEfectivo)).BeginInit();
            this.P3PnlLateral.SuspendLayout();
            this.P3PnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // P3DgvFlujosEfectivo
            // 
            this.P3DgvFlujosEfectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P3DgvFlujosEfectivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAno,
            this.ColVF,
            this.ColActivo});
            this.P3DgvFlujosEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P3DgvFlujosEfectivo.Location = new System.Drawing.Point(118, 71);
            this.P3DgvFlujosEfectivo.Name = "P3DgvFlujosEfectivo";
            this.P3DgvFlujosEfectivo.Size = new System.Drawing.Size(782, 320);
            this.P3DgvFlujosEfectivo.TabIndex = 7;
            // 
            // ColAno
            // 
            this.ColAno.HeaderText = "Año";
            this.ColAno.Name = "ColAno";
            this.ColAno.ToolTipText = "Coloque a cuantos años planea llevar el proyecto";
            // 
            // ColVF
            // 
            this.ColVF.HeaderText = "Valor Futuro";
            this.ColVF.Name = "ColVF";
            this.ColVF.ToolTipText = "Valor la cual espera tener para dentro de ese año.";
            // 
            // ColActivo
            // 
            this.ColActivo.HeaderText = "Activo";
            this.ColActivo.Name = "ColActivo";
            // 
            // P3PnlImagen
            // 
            this.P3PnlImagen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P3PnlImagen.Location = new System.Drawing.Point(118, 391);
            this.P3PnlImagen.Name = "P3PnlImagen";
            this.P3PnlImagen.Size = new System.Drawing.Size(782, 59);
            this.P3PnlImagen.TabIndex = 6;
            // 
            // P3PnlLateral
            // 
            this.P3PnlLateral.BackColor = System.Drawing.Color.Gray;
            this.P3PnlLateral.Controls.Add(this.P3BtnLimpiar);
            this.P3PnlLateral.Controls.Add(this.P3BtnCalcular);
            this.P3PnlLateral.Controls.Add(this.P3TbxResultado);
            this.P3PnlLateral.Controls.Add(this.P3LblResultado);
            this.P3PnlLateral.Controls.Add(this.P3TbxTMAR);
            this.P3PnlLateral.Controls.Add(this.P3LblTMAR);
            this.P3PnlLateral.Controls.Add(this.P3TbxInversionI);
            this.P3PnlLateral.Controls.Add(this.P3LbInversionI);
            this.P3PnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.P3PnlLateral.Location = new System.Drawing.Point(0, 71);
            this.P3PnlLateral.Name = "P3PnlLateral";
            this.P3PnlLateral.Size = new System.Drawing.Size(118, 379);
            this.P3PnlLateral.TabIndex = 5;
            // 
            // P3BtnLimpiar
            // 
            this.P3BtnLimpiar.Location = new System.Drawing.Point(9, 182);
            this.P3BtnLimpiar.Name = "P3BtnLimpiar";
            this.P3BtnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.P3BtnLimpiar.TabIndex = 7;
            this.P3BtnLimpiar.Text = "Limpiar";
            this.P3BtnLimpiar.UseVisualStyleBackColor = true;
            this.P3BtnLimpiar.Click += new System.EventHandler(this.P3BtnLimpiar_Click);
            // 
            // P3BtnCalcular
            // 
            this.P3BtnCalcular.Location = new System.Drawing.Point(9, 152);
            this.P3BtnCalcular.Name = "P3BtnCalcular";
            this.P3BtnCalcular.Size = new System.Drawing.Size(100, 23);
            this.P3BtnCalcular.TabIndex = 5;
            this.P3BtnCalcular.Text = "Calcular";
            this.P3BtnCalcular.UseVisualStyleBackColor = true;
            this.P3BtnCalcular.Click += new System.EventHandler(this.P3BtnCalcular_Click);
            // 
            // P3TbxResultado
            // 
            this.P3TbxResultado.Location = new System.Drawing.Point(9, 120);
            this.P3TbxResultado.Name = "P3TbxResultado";
            this.P3TbxResultado.Size = new System.Drawing.Size(100, 20);
            this.P3TbxResultado.TabIndex = 4;
            // 
            // P3LblResultado
            // 
            this.P3LblResultado.AutoSize = true;
            this.P3LblResultado.Location = new System.Drawing.Point(6, 104);
            this.P3LblResultado.Name = "P3LblResultado";
            this.P3LblResultado.Size = new System.Drawing.Size(55, 13);
            this.P3LblResultado.TabIndex = 6;
            this.P3LblResultado.Text = "Resultado";
            // 
            // P3TbxTMAR
            // 
            this.P3TbxTMAR.Location = new System.Drawing.Point(9, 78);
            this.P3TbxTMAR.Name = "P3TbxTMAR";
            this.P3TbxTMAR.Size = new System.Drawing.Size(100, 20);
            this.P3TbxTMAR.TabIndex = 2;
            // 
            // P3LblTMAR
            // 
            this.P3LblTMAR.AutoSize = true;
            this.P3LblTMAR.Location = new System.Drawing.Point(6, 62);
            this.P3LblTMAR.Name = "P3LblTMAR";
            this.P3LblTMAR.Size = new System.Drawing.Size(49, 13);
            this.P3LblTMAR.TabIndex = 2;
            this.P3LblTMAR.Text = "TMAR %";
            // 
            // P3TbxInversionI
            // 
            this.P3TbxInversionI.Location = new System.Drawing.Point(9, 37);
            this.P3TbxInversionI.Name = "P3TbxInversionI";
            this.P3TbxInversionI.Size = new System.Drawing.Size(100, 20);
            this.P3TbxInversionI.TabIndex = 1;
            // 
            // P3LbInversionI
            // 
            this.P3LbInversionI.AutoSize = true;
            this.P3LbInversionI.Location = new System.Drawing.Point(6, 21);
            this.P3LbInversionI.Name = "P3LbInversionI";
            this.P3LbInversionI.Size = new System.Drawing.Size(80, 13);
            this.P3LbInversionI.TabIndex = 0;
            this.P3LbInversionI.Text = "Inversión Inicial";
            // 
            // P3PnlSuperior
            // 
            this.P3PnlSuperior.BackColor = System.Drawing.Color.DodgerBlue;
            this.P3PnlSuperior.Controls.Add(this.linkLabel1);
            this.P3PnlSuperior.Controls.Add(this.P3LblNombreP);
            this.P3PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.P3PnlSuperior.Name = "P3PnlSuperior";
            this.P3PnlSuperior.Size = new System.Drawing.Size(900, 71);
            this.P3PnlSuperior.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(350, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(249, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Utilizando el Método del Valor Presente Neto (VPN)";
            // 
            // P3LblNombreP
            // 
            this.P3LblNombreP.AutoSize = true;
            this.P3LblNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P3LblNombreP.Location = new System.Drawing.Point(3, 19);
            this.P3LblNombreP.Name = "P3LblNombreP";
            this.P3LblNombreP.Size = new System.Drawing.Size(353, 24);
            this.P3LblNombreP.TabIndex = 0;
            this.P3LblNombreP.Text = "Evaluador de Proyectos de Inversión";
            // 
            // DlgPractica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.P3DgvFlujosEfectivo);
            this.Controls.Add(this.P3PnlImagen);
            this.Controls.Add(this.P3PnlLateral);
            this.Controls.Add(this.P3PnlSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPractica3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgPractica3";
            ((System.ComponentModel.ISupportInitialize)(this.P3DgvFlujosEfectivo)).EndInit();
            this.P3PnlLateral.ResumeLayout(false);
            this.P3PnlLateral.PerformLayout();
            this.P3PnlSuperior.ResumeLayout(false);
            this.P3PnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView P3DgvFlujosEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColActivo;
        private System.Windows.Forms.Panel P3PnlImagen;
        private System.Windows.Forms.Panel P3PnlLateral;
        private System.Windows.Forms.Button P3BtnLimpiar;
        private System.Windows.Forms.Button P3BtnCalcular;
        private System.Windows.Forms.TextBox P3TbxResultado;
        private System.Windows.Forms.Label P3LblResultado;
        private System.Windows.Forms.TextBox P3TbxTMAR;
        private System.Windows.Forms.Label P3LblTMAR;
        private System.Windows.Forms.TextBox P3TbxInversionI;
        private System.Windows.Forms.Label P3LbInversionI;
        private System.Windows.Forms.Panel P3PnlSuperior;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label P3LblNombreP;
    }
}
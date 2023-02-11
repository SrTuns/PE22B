namespace PE22B_MAv2
{
    partial class DlgPractica6
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
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.PnlControles = new System.Windows.Forms.Panel();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnLlenar = new System.Windows.Forms.Button();
            this.LblColumnas = new System.Windows.Forms.Label();
            this.TbxColumnas = new System.Windows.Forms.TextBox();
            this.LblRenglones = new System.Windows.Forms.Label();
            this.TbxRenglones = new System.Windows.Forms.TextBox();
            this.ChbInvertir = new System.Windows.Forms.CheckBox();
            this.LbSumatoria = new System.Windows.Forms.Label();
            this.TbxSumatoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            this.PnlControles.SuspendLayout();
            this.PnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(211, 50);
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.Size = new System.Drawing.Size(689, 400);
            this.DgvPrincipal.TabIndex = 4;
            // 
            // PnlControles
            // 
            this.PnlControles.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlControles.Controls.Add(this.TbxSumatoria);
            this.PnlControles.Controls.Add(this.LbSumatoria);
            this.PnlControles.Controls.Add(this.ChbInvertir);
            this.PnlControles.Controls.Add(this.BtnCalcular);
            this.PnlControles.Controls.Add(this.LblEnunciado);
            this.PnlControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlControles.Location = new System.Drawing.Point(0, 50);
            this.PnlControles.Name = "PnlControles";
            this.PnlControles.Size = new System.Drawing.Size(211, 400);
            this.PnlControles.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.White;
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Location = new System.Drawing.Point(6, 63);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(199, 23);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.ForeColor = System.Drawing.SystemColors.Control;
            this.LblEnunciado.Location = new System.Drawing.Point(3, 15);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(205, 13);
            this.LblEnunciado.TabIndex = 6;
            this.LblEnunciado.Text = "Titulo de la Practica 6";
            this.LblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PnlSuperior.Controls.Add(this.BtnLlenar);
            this.PnlSuperior.Controls.Add(this.LblColumnas);
            this.PnlSuperior.Controls.Add(this.TbxColumnas);
            this.PnlSuperior.Controls.Add(this.LblRenglones);
            this.PnlSuperior.Controls.Add(this.TbxRenglones);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(900, 50);
            this.PnlSuperior.TabIndex = 3;
            // 
            // BtnLlenar
            // 
            this.BtnLlenar.BackColor = System.Drawing.Color.White;
            this.BtnLlenar.FlatAppearance.BorderSize = 0;
            this.BtnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLlenar.Location = new System.Drawing.Point(250, 17);
            this.BtnLlenar.Name = "BtnLlenar";
            this.BtnLlenar.Size = new System.Drawing.Size(75, 23);
            this.BtnLlenar.TabIndex = 4;
            this.BtnLlenar.Text = "Llenar";
            this.BtnLlenar.UseVisualStyleBackColor = false;
            this.BtnLlenar.Click += new System.EventHandler(this.BtnLlenar_Click);
            // 
            // LblColumnas
            // 
            this.LblColumnas.AutoSize = true;
            this.LblColumnas.ForeColor = System.Drawing.SystemColors.Control;
            this.LblColumnas.Location = new System.Drawing.Point(131, 3);
            this.LblColumnas.Name = "LblColumnas";
            this.LblColumnas.Size = new System.Drawing.Size(53, 13);
            this.LblColumnas.TabIndex = 3;
            this.LblColumnas.Text = "Columnas";
            // 
            // TbxColumnas
            // 
            this.TbxColumnas.Location = new System.Drawing.Point(129, 19);
            this.TbxColumnas.Name = "TbxColumnas";
            this.TbxColumnas.Size = new System.Drawing.Size(100, 20);
            this.TbxColumnas.TabIndex = 2;
            this.TbxColumnas.Text = "9";
            // 
            // LblRenglones
            // 
            this.LblRenglones.AutoSize = true;
            this.LblRenglones.ForeColor = System.Drawing.SystemColors.Control;
            this.LblRenglones.Location = new System.Drawing.Point(14, 3);
            this.LblRenglones.Name = "LblRenglones";
            this.LblRenglones.Size = new System.Drawing.Size(58, 13);
            this.LblRenglones.TabIndex = 1;
            this.LblRenglones.Text = "Renglones";
            // 
            // TbxRenglones
            // 
            this.TbxRenglones.Location = new System.Drawing.Point(12, 19);
            this.TbxRenglones.Name = "TbxRenglones";
            this.TbxRenglones.Size = new System.Drawing.Size(100, 20);
            this.TbxRenglones.TabIndex = 0;
            this.TbxRenglones.Text = "5";
            // 
            // ChbInvertir
            // 
            this.ChbInvertir.AutoSize = true;
            this.ChbInvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbInvertir.ForeColor = System.Drawing.SystemColors.Control;
            this.ChbInvertir.Location = new System.Drawing.Point(6, 40);
            this.ChbInvertir.Name = "ChbInvertir";
            this.ChbInvertir.Size = new System.Drawing.Size(119, 17);
            this.ChbInvertir.TabIndex = 12;
            this.ChbInvertir.Text = "Invertir triángulo";
            this.ChbInvertir.UseVisualStyleBackColor = true;
            // 
            // LbSumatoria
            // 
            this.LbSumatoria.AutoSize = true;
            this.LbSumatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSumatoria.ForeColor = System.Drawing.SystemColors.Control;
            this.LbSumatoria.Location = new System.Drawing.Point(6, 93);
            this.LbSumatoria.Name = "LbSumatoria";
            this.LbSumatoria.Size = new System.Drawing.Size(63, 13);
            this.LbSumatoria.TabIndex = 13;
            this.LbSumatoria.Text = "Sumatoria";
            // 
            // TbxSumatoria
            // 
            this.TbxSumatoria.Location = new System.Drawing.Point(6, 110);
            this.TbxSumatoria.Name = "TbxSumatoria";
            this.TbxSumatoria.Size = new System.Drawing.Size(199, 20);
            this.TbxSumatoria.TabIndex = 14;
            // 
            // DlgPractica6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.DgvPrincipal);
            this.Controls.Add(this.PnlControles);
            this.Controls.Add(this.PnlSuperior);
            this.Name = "DlgPractica6";
            this.Text = "DlgPractica6";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.PnlControles.ResumeLayout(false);
            this.PnlControles.PerformLayout();
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.Panel PnlControles;
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Button BtnLlenar;
        private System.Windows.Forms.Label LblColumnas;
        private System.Windows.Forms.TextBox TbxColumnas;
        private System.Windows.Forms.Label LblRenglones;
        private System.Windows.Forms.TextBox TbxRenglones;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.CheckBox ChbInvertir;
        private System.Windows.Forms.TextBox TbxSumatoria;
        private System.Windows.Forms.Label LbSumatoria;
    }
}
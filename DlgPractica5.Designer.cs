namespace PE22B_MAv2
{
    partial class DlgPractica5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica5));
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnLlenar = new System.Windows.Forms.Button();
            this.LblColumnas = new System.Windows.Forms.Label();
            this.TbxColumnas = new System.Windows.Forms.TextBox();
            this.LblRenglones = new System.Windows.Forms.Label();
            this.TbxRenglones = new System.Windows.Forms.TextBox();
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.PnlControles = new System.Windows.Forms.Panel();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblPasos = new System.Windows.Forms.Label();
            this.TbxCapturar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            this.PnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PnlSuperior.Controls.Add(this.button1);
            this.PnlSuperior.Controls.Add(this.BtnLlenar);
            this.PnlSuperior.Controls.Add(this.LblColumnas);
            this.PnlSuperior.Controls.Add(this.TbxColumnas);
            this.PnlSuperior.Controls.Add(this.LblRenglones);
            this.PnlSuperior.Controls.Add(this.TbxRenglones);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(900, 50);
            this.PnlSuperior.TabIndex = 0;
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
            this.BtnLlenar.Text = " ";
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
            this.TbxColumnas.Text = "3";
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
            this.TbxRenglones.Text = "3";
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(211, 50);
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.Size = new System.Drawing.Size(689, 400);
            this.DgvPrincipal.TabIndex = 1;
            // 
            // PnlControles
            // 
            this.PnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PnlControles.Controls.Add(this.BtnCalcular);
            this.PnlControles.Controls.Add(this.LblPasos);
            this.PnlControles.Controls.Add(this.TbxCapturar);
            this.PnlControles.Controls.Add(this.label2);
            this.PnlControles.Controls.Add(this.LblEnunciado);
            this.PnlControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlControles.Location = new System.Drawing.Point(0, 50);
            this.PnlControles.Name = "PnlControles";
            this.PnlControles.Size = new System.Drawing.Size(211, 400);
            this.PnlControles.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.White;
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Location = new System.Drawing.Point(6, 104);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(199, 23);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblPasos
            // 
            this.LblPasos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.LblPasos.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPasos.Location = new System.Drawing.Point(6, 88);
            this.LblPasos.Name = "LblPasos";
            this.LblPasos.Size = new System.Drawing.Size(199, 13);
            this.LblPasos.TabIndex = 9;
            this.LblPasos.Text = "Pasos a 1";
            this.LblPasos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxCapturar
            // 
            this.TbxCapturar.Location = new System.Drawing.Point(73, 51);
            this.TbxCapturar.Name = "TbxCapturar";
            this.TbxCapturar.Size = new System.Drawing.Size(100, 20);
            this.TbxCapturar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "N = ";
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.ForeColor = System.Drawing.SystemColors.Control;
            this.LblEnunciado.Location = new System.Drawing.Point(3, 24);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(205, 13);
            this.LblEnunciado.TabIndex = 6;
            this.LblEnunciado.Text = "El problema de la Conjetura Collatz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(407, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Llenar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DlgPractica5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.DgvPrincipal);
            this.Controls.Add(this.PnlControles);
            this.Controls.Add(this.PnlSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPractica5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgPractica5";
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.PnlControles.ResumeLayout(false);
            this.PnlControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.Button BtnLlenar;
        private System.Windows.Forms.Label LblColumnas;
        private System.Windows.Forms.TextBox TbxColumnas;
        private System.Windows.Forms.Label LblRenglones;
        private System.Windows.Forms.TextBox TbxRenglones;
        private System.Windows.Forms.Panel PnlControles;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TbxCapturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.Label LblPasos;
        private System.Windows.Forms.Button button1;
    }
}
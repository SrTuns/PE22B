namespace PE22B_MAv2
{
    partial class DlgPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPrincipal));
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnMazimizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PnlPracticas = new System.Windows.Forms.Panel();
            this.BtnPractica10 = new System.Windows.Forms.Button();
            this.BtnPractica9 = new System.Windows.Forms.Button();
            this.BtnPractica8 = new System.Windows.Forms.Button();
            this.BtnPractica7 = new System.Windows.Forms.Button();
            this.BtnPractica6 = new System.Windows.Forms.Button();
            this.BtnPractica5 = new System.Windows.Forms.Button();
            this.BtnPractica4 = new System.Windows.Forms.Button();
            this.BtnPractica3 = new System.Windows.Forms.Button();
            this.BtnPractica2 = new System.Windows.Forms.Button();
            this.BtnPractica1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.PnlMostrarPracticas = new System.Windows.Forms.Panel();
            this.PnlSuperior.SuspendLayout();
            this.PnlPracticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PnlSuperior.Controls.Add(this.BtnMinimizar);
            this.PnlSuperior.Controls.Add(this.BtnMazimizar);
            this.PnlSuperior.Controls.Add(this.BtnCerrar);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(1116, 30);
            this.PnlSuperior.TabIndex = 1;
            this.PnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseMove);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMinimizar.Location = new System.Drawing.Point(1032, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(28, 30);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.Text = "___";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMazimizar
            // 
            this.BtnMazimizar.BackgroundImage = global::PE22B_MAv2.Properties.Resources.klipartz_com;
            this.BtnMazimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMazimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMazimizar.FlatAppearance.BorderSize = 0;
            this.BtnMazimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMazimizar.ForeColor = System.Drawing.Color.Red;
            this.BtnMazimizar.Location = new System.Drawing.Point(1060, 0);
            this.BtnMazimizar.Name = "BtnMazimizar";
            this.BtnMazimizar.Size = new System.Drawing.Size(28, 30);
            this.BtnMazimizar.TabIndex = 1;
            this.BtnMazimizar.UseVisualStyleBackColor = true;
            this.BtnMazimizar.Click += new System.EventHandler(this.BtnMazimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrar.Location = new System.Drawing.Point(1088, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(28, 30);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlPracticas
            // 
            this.PnlPracticas.AutoScroll = true;
            this.PnlPracticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.PnlPracticas.Controls.Add(this.BtnPractica10);
            this.PnlPracticas.Controls.Add(this.BtnPractica9);
            this.PnlPracticas.Controls.Add(this.BtnPractica8);
            this.PnlPracticas.Controls.Add(this.BtnPractica7);
            this.PnlPracticas.Controls.Add(this.BtnPractica6);
            this.PnlPracticas.Controls.Add(this.BtnPractica5);
            this.PnlPracticas.Controls.Add(this.BtnPractica4);
            this.PnlPracticas.Controls.Add(this.BtnPractica3);
            this.PnlPracticas.Controls.Add(this.BtnPractica2);
            this.PnlPracticas.Controls.Add(this.BtnPractica1);
            this.PnlPracticas.Controls.Add(this.a);
            this.PnlPracticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlPracticas.Location = new System.Drawing.Point(0, 30);
            this.PnlPracticas.Name = "PnlPracticas";
            this.PnlPracticas.Size = new System.Drawing.Size(150, 490);
            this.PnlPracticas.TabIndex = 2;
            // 
            // BtnPractica10
            // 
            this.BtnPractica10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPractica10.BackgroundImage")));
            this.BtnPractica10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica10.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica10.Enabled = false;
            this.BtnPractica10.FlatAppearance.BorderSize = 0;
            this.BtnPractica10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica10.Location = new System.Drawing.Point(0, 600);
            this.BtnPractica10.Name = "BtnPractica10";
            this.BtnPractica10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica10.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica10.TabIndex = 22;
            this.BtnPractica10.UseVisualStyleBackColor = true;
            // 
            // BtnPractica9
            // 
            this.BtnPractica9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPractica9.BackgroundImage")));
            this.BtnPractica9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica9.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica9.Enabled = false;
            this.BtnPractica9.FlatAppearance.BorderSize = 0;
            this.BtnPractica9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica9.Location = new System.Drawing.Point(0, 540);
            this.BtnPractica9.Name = "BtnPractica9";
            this.BtnPractica9.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica9.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica9.TabIndex = 21;
            this.BtnPractica9.UseVisualStyleBackColor = true;
            // 
            // BtnPractica8
            // 
            this.BtnPractica8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPractica8.BackgroundImage")));
            this.BtnPractica8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica8.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica8.FlatAppearance.BorderSize = 0;
            this.BtnPractica8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica8.Location = new System.Drawing.Point(0, 480);
            this.BtnPractica8.Name = "BtnPractica8";
            this.BtnPractica8.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica8.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica8.TabIndex = 20;
            this.BtnPractica8.UseVisualStyleBackColor = true;
            this.BtnPractica8.Click += new System.EventHandler(this.BtnPractica8_Click);
            // 
            // BtnPractica7
            // 
            this.BtnPractica7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPractica7.BackgroundImage")));
            this.BtnPractica7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica7.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica7.FlatAppearance.BorderSize = 0;
            this.BtnPractica7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica7.Location = new System.Drawing.Point(0, 420);
            this.BtnPractica7.Name = "BtnPractica7";
            this.BtnPractica7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica7.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica7.TabIndex = 19;
            this.BtnPractica7.UseVisualStyleBackColor = true;
            this.BtnPractica7.Click += new System.EventHandler(this.BtnPractica7_Click);
            // 
            // BtnPractica6
            // 
            this.BtnPractica6.BackgroundImage = global::PE22B_MAv2.Properties.Resources.Practica6;
            this.BtnPractica6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica6.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica6.FlatAppearance.BorderSize = 0;
            this.BtnPractica6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica6.Location = new System.Drawing.Point(0, 360);
            this.BtnPractica6.Name = "BtnPractica6";
            this.BtnPractica6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica6.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica6.TabIndex = 18;
            this.BtnPractica6.UseVisualStyleBackColor = true;
            this.BtnPractica6.Click += new System.EventHandler(this.BtnPractica6_Click);
            // 
            // BtnPractica5
            // 
            this.BtnPractica5.BackgroundImage = global::PE22B_MAv2.Properties.Resources.Collatz;
            this.BtnPractica5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica5.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica5.FlatAppearance.BorderSize = 0;
            this.BtnPractica5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica5.Location = new System.Drawing.Point(0, 300);
            this.BtnPractica5.Name = "BtnPractica5";
            this.BtnPractica5.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica5.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica5.TabIndex = 17;
            this.BtnPractica5.UseVisualStyleBackColor = true;
            this.BtnPractica5.Click += new System.EventHandler(this.BtnPractica5_Click);
            // 
            // BtnPractica4
            // 
            this.BtnPractica4.BackgroundImage = global::PE22B_MAv2.Properties.Resources.Practica4;
            this.BtnPractica4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica4.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica4.FlatAppearance.BorderSize = 0;
            this.BtnPractica4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica4.Location = new System.Drawing.Point(0, 240);
            this.BtnPractica4.Name = "BtnPractica4";
            this.BtnPractica4.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica4.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica4.TabIndex = 16;
            this.BtnPractica4.UseVisualStyleBackColor = true;
            this.BtnPractica4.Click += new System.EventHandler(this.BtnPractica4_Click);
            // 
            // BtnPractica3
            // 
            this.BtnPractica3.BackgroundImage = global::PE22B_MAv2.Properties.Resources.Practica3;
            this.BtnPractica3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica3.FlatAppearance.BorderSize = 0;
            this.BtnPractica3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica3.Location = new System.Drawing.Point(0, 180);
            this.BtnPractica3.Name = "BtnPractica3";
            this.BtnPractica3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica3.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica3.TabIndex = 15;
            this.BtnPractica3.UseVisualStyleBackColor = true;
            this.BtnPractica3.Click += new System.EventHandler(this.BtnPractica3_Click);
            // 
            // BtnPractica2
            // 
            this.BtnPractica2.BackgroundImage = global::PE22B_MAv2.Properties.Resources.Practica2;
            this.BtnPractica2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica2.FlatAppearance.BorderSize = 0;
            this.BtnPractica2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica2.Location = new System.Drawing.Point(0, 120);
            this.BtnPractica2.Name = "BtnPractica2";
            this.BtnPractica2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica2.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica2.TabIndex = 14;
            this.BtnPractica2.UseVisualStyleBackColor = true;
            this.BtnPractica2.Click += new System.EventHandler(this.BtnPractica2_Click);
            // 
            // BtnPractica1
            // 
            this.BtnPractica1.BackgroundImage = global::PE22B_MAv2.Properties.Resources.Practica1;
            this.BtnPractica1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPractica1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPractica1.FlatAppearance.BorderSize = 0;
            this.BtnPractica1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPractica1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.BtnPractica1.Location = new System.Drawing.Point(0, 60);
            this.BtnPractica1.Name = "BtnPractica1";
            this.BtnPractica1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnPractica1.Size = new System.Drawing.Size(133, 60);
            this.BtnPractica1.TabIndex = 13;
            this.BtnPractica1.UseVisualStyleBackColor = true;
            this.BtnPractica1.Click += new System.EventHandler(this.BtnPractica1_Click);
            // 
            // a
            // 
            this.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.a.Dock = System.Windows.Forms.DockStyle.Top;
            this.a.Enabled = false;
            this.a.FlatAppearance.BorderSize = 0;
            this.a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.a.Location = new System.Drawing.Point(0, 0);
            this.a.Name = "a";
            this.a.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.a.Size = new System.Drawing.Size(133, 60);
            this.a.TabIndex = 12;
            this.a.Text = "Prácticas";
            this.a.UseVisualStyleBackColor = true;
            // 
            // PnlMostrarPracticas
            // 
            this.PnlMostrarPracticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PnlMostrarPracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMostrarPracticas.Location = new System.Drawing.Point(150, 30);
            this.PnlMostrarPracticas.Name = "PnlMostrarPracticas";
            this.PnlMostrarPracticas.Size = new System.Drawing.Size(966, 490);
            this.PnlMostrarPracticas.TabIndex = 12;
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 520);
            this.Controls.Add(this.PnlMostrarPracticas);
            this.Controls.Add(this.PnlPracticas);
            this.Controls.Add(this.PnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DlgPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practicas";
            this.PnlSuperior.ResumeLayout(false);
            this.PnlPracticas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Button BtnMazimizar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Panel PnlPracticas;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button BtnPractica10;
        private System.Windows.Forms.Button BtnPractica9;
        private System.Windows.Forms.Button BtnPractica8;
        private System.Windows.Forms.Button BtnPractica7;
        private System.Windows.Forms.Button BtnPractica6;
        private System.Windows.Forms.Button BtnPractica5;
        private System.Windows.Forms.Button BtnPractica4;
        private System.Windows.Forms.Button BtnPractica3;
        private System.Windows.Forms.Button BtnPractica2;
        private System.Windows.Forms.Button BtnPractica1;
        private System.Windows.Forms.Panel PnlMostrarPracticas;
    }
}


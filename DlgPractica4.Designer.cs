namespace PE22B_MAv2
{
    partial class DlgPractica4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica4));
            this.TbxLatitud = new System.Windows.Forms.TextBox();
            this.LblLatitud = new System.Windows.Forms.Label();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TbxLugar = new System.Windows.Forms.TextBox();
            this.LblLugar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGeneraKML = new System.Windows.Forms.Button();
            this.LblLongitudEO = new System.Windows.Forms.Label();
            this.LblLatitudNS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.TbxLatitudGrados = new System.Windows.Forms.TextBox();
            this.BtnObtenerCoordenadas = new System.Windows.Forms.Button();
            this.TbxLongitudGrados = new System.Windows.Forms.TextBox();
            this.TbxLongitud = new System.Windows.Forms.TextBox();
            this.LblLongitud = new System.Windows.Forms.Label();
            this.TbAlturaPunto = new System.Windows.Forms.TrackBar();
            this.LblAltura = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbAlturaPunto)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxLatitud
            // 
            this.TbxLatitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxLatitud.ForeColor = System.Drawing.SystemColors.Info;
            this.TbxLatitud.Location = new System.Drawing.Point(11, 188);
            this.TbxLatitud.Name = "TbxLatitud";
            this.TbxLatitud.ReadOnly = true;
            this.TbxLatitud.Size = new System.Drawing.Size(270, 20);
            this.TbxLatitud.TabIndex = 15;
            // 
            // LblLatitud
            // 
            this.LblLatitud.AutoSize = true;
            this.LblLatitud.BackColor = System.Drawing.Color.DimGray;
            this.LblLatitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.LblLatitud.Location = new System.Drawing.Point(11, 171);
            this.LblLatitud.Name = "LblLatitud";
            this.LblLatitud.Size = new System.Drawing.Size(45, 13);
            this.LblLatitud.TabIndex = 14;
            this.LblLatitud.Text = "Latitud I";
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxDescripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.TbxDescripcion.Location = new System.Drawing.Point(11, 127);
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.ReadOnly = true;
            this.TbxDescripcion.Size = new System.Drawing.Size(550, 20);
            this.TbxDescripcion.TabIndex = 13;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.DimGray;
            this.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.LblDescripcion.Location = new System.Drawing.Point(11, 110);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 12;
            this.LblDescripcion.Text = "Descripción";
            // 
            // TbxLugar
            // 
            this.TbxLugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(168)))));
            this.TbxLugar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TbxLugar.Location = new System.Drawing.Point(11, 70);
            this.TbxLugar.Name = "TbxLugar";
            this.TbxLugar.Size = new System.Drawing.Size(550, 20);
            this.TbxLugar.TabIndex = 11;
            this.TbxLugar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxLugar_KeyDown);
            // 
            // LblLugar
            // 
            this.LblLugar.AutoSize = true;
            this.LblLugar.BackColor = System.Drawing.Color.DimGray;
            this.LblLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.LblLugar.Location = new System.Drawing.Point(11, 53);
            this.LblLugar.Name = "LblLugar";
            this.LblLugar.Size = new System.Drawing.Size(34, 13);
            this.LblLugar.TabIndex = 10;
            this.LblLugar.Text = "Lugar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(50)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LblAltura);
            this.panel1.Controls.Add(this.TbAlturaPunto);
            this.panel1.Controls.Add(this.BtnGeneraKML);
            this.panel1.Controls.Add(this.LblLongitudEO);
            this.panel1.Controls.Add(this.LblLatitudNS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnConvertir);
            this.panel1.Controls.Add(this.TbxLatitudGrados);
            this.panel1.Controls.Add(this.BtnObtenerCoordenadas);
            this.panel1.Controls.Add(this.TbxLongitudGrados);
            this.panel1.Controls.Add(this.TbxLongitud);
            this.panel1.Controls.Add(this.LblLongitud);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 450);
            this.panel1.TabIndex = 19;
            // 
            // BtnGeneraKML
            // 
            this.BtnGeneraKML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.BtnGeneraKML.FlatAppearance.BorderSize = 0;
            this.BtnGeneraKML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneraKML.ForeColor = System.Drawing.Color.White;
            this.BtnGeneraKML.Location = new System.Drawing.Point(654, 54);
            this.BtnGeneraKML.Name = "BtnGeneraKML";
            this.BtnGeneraKML.Size = new System.Drawing.Size(170, 50);
            this.BtnGeneraKML.TabIndex = 23;
            this.BtnGeneraKML.Text = "P8 - Generar KML";
            this.BtnGeneraKML.UseVisualStyleBackColor = false;
            this.BtnGeneraKML.Click += new System.EventHandler(this.BtnGeneraKML_Click);
            // 
            // LblLongitudEO
            // 
            this.LblLongitudEO.AutoSize = true;
            this.LblLongitudEO.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLongitudEO.Location = new System.Drawing.Point(593, 242);
            this.LblLongitudEO.Name = "LblLongitudEO";
            this.LblLongitudEO.Size = new System.Drawing.Size(0, 13);
            this.LblLongitudEO.TabIndex = 22;
            // 
            // LblLatitudNS
            // 
            this.LblLatitudNS.AutoSize = true;
            this.LblLatitudNS.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLatitudNS.Location = new System.Drawing.Point(593, 194);
            this.LblLatitudNS.Name = "LblLatitudNS";
            this.LblLatitudNS.Size = new System.Drawing.Size(0, 13);
            this.LblLatitudNS.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Longitud -";
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.BtnConvertir.FlatAppearance.BorderSize = 0;
            this.BtnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvertir.ForeColor = System.Drawing.Color.White;
            this.BtnConvertir.Location = new System.Drawing.Point(330, 275);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(170, 50);
            this.BtnConvertir.TabIndex = 19;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = false;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // TbxLatitudGrados
            // 
            this.TbxLatitudGrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxLatitudGrados.ForeColor = System.Drawing.SystemColors.Info;
            this.TbxLatitudGrados.Location = new System.Drawing.Point(291, 188);
            this.TbxLatitudGrados.Name = "TbxLatitudGrados";
            this.TbxLatitudGrados.ReadOnly = true;
            this.TbxLatitudGrados.Size = new System.Drawing.Size(270, 20);
            this.TbxLatitudGrados.TabIndex = 15;
            // 
            // BtnObtenerCoordenadas
            // 
            this.BtnObtenerCoordenadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.BtnObtenerCoordenadas.FlatAppearance.BorderSize = 0;
            this.BtnObtenerCoordenadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObtenerCoordenadas.ForeColor = System.Drawing.Color.White;
            this.BtnObtenerCoordenadas.Location = new System.Drawing.Point(61, 275);
            this.BtnObtenerCoordenadas.Name = "BtnObtenerCoordenadas";
            this.BtnObtenerCoordenadas.Size = new System.Drawing.Size(170, 50);
            this.BtnObtenerCoordenadas.TabIndex = 18;
            this.BtnObtenerCoordenadas.Text = "Obtener\r\nCoordenadas";
            this.BtnObtenerCoordenadas.UseVisualStyleBackColor = false;
            this.BtnObtenerCoordenadas.Click += new System.EventHandler(this.BtnObtenerCoordenadas_Click);
            // 
            // TbxLongitudGrados
            // 
            this.TbxLongitudGrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxLongitudGrados.ForeColor = System.Drawing.SystemColors.Info;
            this.TbxLongitudGrados.Location = new System.Drawing.Point(291, 235);
            this.TbxLongitudGrados.Name = "TbxLongitudGrados";
            this.TbxLongitudGrados.ReadOnly = true;
            this.TbxLongitudGrados.Size = new System.Drawing.Size(270, 20);
            this.TbxLongitudGrados.TabIndex = 17;
            // 
            // TbxLongitud
            // 
            this.TbxLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxLongitud.ForeColor = System.Drawing.SystemColors.Info;
            this.TbxLongitud.Location = new System.Drawing.Point(11, 235);
            this.TbxLongitud.Name = "TbxLongitud";
            this.TbxLongitud.ReadOnly = true;
            this.TbxLongitud.Size = new System.Drawing.Size(270, 20);
            this.TbxLongitud.TabIndex = 17;
            // 
            // LblLongitud
            // 
            this.LblLongitud.AutoSize = true;
            this.LblLongitud.BackColor = System.Drawing.Color.DimGray;
            this.LblLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.LblLongitud.Location = new System.Drawing.Point(12, 190);
            this.LblLongitud.Name = "LblLongitud";
            this.LblLongitud.Size = new System.Drawing.Size(54, 13);
            this.LblLongitud.TabIndex = 16;
            this.LblLongitud.Text = "Longitud -";
            // 
            // TbAlturaPunto
            // 
            this.TbAlturaPunto.LargeChange = 0;
            this.TbAlturaPunto.Location = new System.Drawing.Point(654, 110);
            this.TbAlturaPunto.Name = "TbAlturaPunto";
            this.TbAlturaPunto.Size = new System.Drawing.Size(170, 45);
            this.TbAlturaPunto.TabIndex = 24;
            this.TbAlturaPunto.Value = 1;
            this.TbAlturaPunto.Scroll += new System.EventHandler(this.TbAlturaPunto_Scroll);
            // 
            // LblAltura
            // 
            this.LblAltura.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAltura.Location = new System.Drawing.Point(831, 114);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(57, 23);
            this.LblAltura.TabIndex = 25;
            this.LblAltura.Text = "100";
            this.LblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlgPractica4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.TbxLatitud);
            this.Controls.Add(this.LblLatitud);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TbxLugar);
            this.Controls.Add(this.LblLugar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPractica4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgPractica4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbAlturaPunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnObtenerCoordenadas;
        private System.Windows.Forms.TextBox TbxLongitud;
        private System.Windows.Forms.Label LblLongitud;
        private System.Windows.Forms.TextBox TbxLatitud;
        private System.Windows.Forms.Label LblLatitud;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TbxLugar;
        private System.Windows.Forms.Label LblLugar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbxLatitudGrados;
        private System.Windows.Forms.TextBox TbxLongitudGrados;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblLongitudEO;
        private System.Windows.Forms.Label LblLatitudNS;
        private System.Windows.Forms.Button BtnGeneraKML;
        private System.Windows.Forms.TrackBar TbAlturaPunto;
        private System.Windows.Forms.Label LblAltura;
    }
}
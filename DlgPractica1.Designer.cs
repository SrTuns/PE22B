namespace PE22B_MAv2
{
    partial class DlgPractica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica1));
            this.PnlDer = new System.Windows.Forms.Panel();
            this.Mamaguevo = new System.Windows.Forms.Button();
            this.PnlIzq = new System.Windows.Forms.Panel();
            this.PbxLogoETG = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogoETG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlDer
            // 
            this.PnlDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(173)))), ((int)(((byte)(58)))));
            this.PnlDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDer.Location = new System.Drawing.Point(700, 0);
            this.PnlDer.Name = "PnlDer";
            this.PnlDer.Size = new System.Drawing.Size(200, 450);
            this.PnlDer.TabIndex = 7;
            // 
            // Mamaguevo
            // 
            this.Mamaguevo.Location = new System.Drawing.Point(40, 145);
            this.Mamaguevo.Name = "Mamaguevo";
            this.Mamaguevo.Size = new System.Drawing.Size(124, 51);
            this.Mamaguevo.TabIndex = 100;
            this.Mamaguevo.Text = "Tocame >.<";
            this.Mamaguevo.UseVisualStyleBackColor = true;
            this.Mamaguevo.Click += new System.EventHandler(this.Mamaguevo_Click);
            // 
            // PnlIzq
            // 
            this.PnlIzq.BackColor = System.Drawing.Color.Black;
            this.PnlIzq.Controls.Add(this.PbxLogoETG);
            this.PnlIzq.Controls.Add(this.Mamaguevo);
            this.PnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzq.Location = new System.Drawing.Point(0, 0);
            this.PnlIzq.Name = "PnlIzq";
            this.PnlIzq.Size = new System.Drawing.Size(200, 450);
            this.PnlIzq.TabIndex = 6;
            // 
            // PbxLogoETG
            // 
            this.PbxLogoETG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxLogoETG.Image = global::PE22B_MAv2.Properties.Resources.ETG;
            this.PbxLogoETG.Location = new System.Drawing.Point(40, 15);
            this.PbxLogoETG.Name = "PbxLogoETG";
            this.PbxLogoETG.Size = new System.Drawing.Size(124, 124);
            this.PbxLogoETG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxLogoETG.TabIndex = 2;
            this.PbxLogoETG.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PE22B_MAv2.Properties.Resources.etgfondo;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DlgPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlDer);
            this.Controls.Add(this.PnlIzq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPractica1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgPractica1";
            this.PnlIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogoETG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlDer;
        private System.Windows.Forms.Button Mamaguevo;
        private System.Windows.Forms.Panel PnlIzq;
        private System.Windows.Forms.PictureBox PbxLogoETG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
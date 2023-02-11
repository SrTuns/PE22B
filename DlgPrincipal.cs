using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE22B_MAv2
{
    public partial class DlgPrincipal : Form
    {
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Form FormularioActivo = null;
        private void AbrirPanel(Form ContenidoFormulario)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = ContenidoFormulario;
            ContenidoFormulario.TopLevel = false;
            ContenidoFormulario.FormBorderStyle = FormBorderStyle.None;
            ContenidoFormulario.Dock = DockStyle.Fill;
            PnlMostrarPracticas.Controls.Add(ContenidoFormulario);
            PnlMostrarPracticas.Tag = ContenidoFormulario;
            ContenidoFormulario.BringToFront();
            ContenidoFormulario.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMazimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;
        private void PnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        //-------------------------------------------------------------------------
        //Botón practica 1.
        //-------------------------------------------------------------------------
        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica1());
        }

        //-------------------------------------------------------------------------
        //Botón practica 2.
        //-------------------------------------------------------------------------
        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica2());
        }

        //-------------------------------------------------------------------------
        //Botón practica 3.
        //-------------------------------------------------------------------------
        private void BtnPractica3_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica3());
        }

        //-------------------------------------------------------------------------
        //Botón practica 4.
        //-------------------------------------------------------------------------
        private void BtnPractica4_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica4());
        }

        //-------------------------------------------------------------------------
        //Botón practica 5.
        //-------------------------------------------------------------------------
        private void BtnPractica5_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica5());
        }

        //-------------------------------------------------------------------------
        //Botón practica 6.
        //-------------------------------------------------------------------------
        private void BtnPractica6_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica6());
        }

        //-------------------------------------------------------------------------
        //Botón practica 7.
        //-------------------------------------------------------------------------
        private void BtnPractica7_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica7());
        }

        private void BtnPractica8_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DlgPractica4());
        }
    }
}

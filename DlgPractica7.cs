using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PE22B_MAv2
{
    //-------------------------------------------------------------------------
    //Dialogo Principal de la práctica 7.
    //MA. 31/10/2022
    //-------------------------------------------------------------------------
    public partial class DlgPractica7 : Form
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        Color ColorSeleccionado;
        Color FondoColorSeleccionado;

        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica7()
        {
            InitializeComponent();
            ColorSeleccionado = Color.Red;
            BtnColor.BackColor = ColorSeleccionado;
            FondoColorSeleccionado = Color.DarkSlateGray;
            BtnColorFondo.BackColor = FondoColorSeleccionado;
        }

        //-------------------------------------------------------------------------
        //Botón para dibujar.
        //-------------------------------------------------------------------------
        private void BtnDibujar_Click(object sender, EventArgs e)
        {
            Pen Pluma;
            PointF Punto1;
            PointF Punto2;
            PointF Punto3;
            PointF Punto4;
            Graphics Lienzo;
            float XInicial;
            float YInicial;
            float AnchoPluma;
            float Lado;

            //Prepara datos de trabajo.

            XInicial = float.Parse(TbxXInicial.Text);
            YInicial = float.Parse(TbxYInicial.Text);

            AnchoPluma = float.Parse(NudPluma.Value.ToString());

            Lado = float.Parse(TbxLado.Text);

            //Prepara pluma.

            Pluma = new Pen(ColorSeleccionado, AnchoPluma);

            //Calcula vectores X - Y

            Punto1 = new PointF(XInicial, YInicial);
            Punto2 = new PointF(XInicial, Lado + YInicial);
            Punto3 = new PointF(Lado + XInicial, Lado + YInicial);
            Punto4 = new PointF(Lado + XInicial, YInicial);

            PointF[] VectoresPoligono =
            {
                Punto1,
                Punto2,
                Punto3,
                Punto4,
            };

            //Dibujo el poligono.

            Lienzo = PnlLienzo.CreateGraphics();
            Lienzo.DrawPolygon(Pluma, VectoresPoligono);
        }

        //-------------------------------------------------------------------------
        //Muestra al usuario el díálogo de slección de color.
        //-------------------------------------------------------------------------
        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog DlgSelectorColor = new ColorDialog();

            DlgSelectorColor.AllowFullOpen = true;
            DlgSelectorColor.ShowHelp = true;
            DlgSelectorColor.Color = ColorSeleccionado;

            if (DlgSelectorColor.ShowDialog() == DialogResult.OK)
            {
                ColorSeleccionado = DlgSelectorColor.Color;
                BtnColor.BackColor = ColorSeleccionado;

                if (ColorSeleccionado.R < 60 && ColorSeleccionado.G < 60 && ColorSeleccionado.B < 60)
                {
                    BtnColor.ForeColor = Color.White;
                }
                else
                {
                    BtnColor.ForeColor = Color.Black;
                }
            }

        }

        private void BtnP72_Click(object sender, EventArgs e)
        {
            Pen Pluma;
            Graphics Lienzo;
            float XInicial;
            float YInicial;
            float AnchoPluma;
            float Lado;
            float Espirales;
            float Separador;

            //Prepara datos de trabajo.

            XInicial = PnlLienzo.Width / 2;
            YInicial = PnlLienzo.Height / 2;
            AnchoPluma = float.Parse(NudPluma.Value.ToString());
            Lado = float.Parse(TbxLado.Text);
            Espirales = float.Parse(TbxXInicial.Text);
            Separador = float.Parse(TbxYInicial.Text);
            Lienzo = PnlLienzo.CreateGraphics();

            //Prepara pluma.

            Pluma = new Pen(ColorSeleccionado, AnchoPluma);

            //Dibujar espiral

            for (int i = 0; i <= Espirales; i++)
            {
                Lienzo.DrawLine(Pluma, XInicial, YInicial, XInicial + Lado, YInicial);
                Lienzo.DrawLine(Pluma, XInicial + Lado, YInicial, XInicial + Lado, YInicial + Lado);
                Lienzo.DrawLine(Pluma, XInicial + Lado, YInicial + Lado, XInicial - Separador, YInicial + Lado);
                Lienzo.DrawLine(Pluma, XInicial - Separador, YInicial + Lado, XInicial - Separador, YInicial - Separador);
                YInicial = YInicial - Separador;
                XInicial = XInicial - Separador;
                //Lado = Lado + (Separador * 2);
                Lado = Lado + Separador + Separador;
            }
        }



        private void BtnColorFondo_Click(object sender, EventArgs e)
        {
            ColorDialog FondoColor = new ColorDialog();

            FondoColor.AllowFullOpen = true;
            FondoColor.ShowHelp = true;
            FondoColor.Color = FondoColorSeleccionado;

            if (FondoColor.ShowDialog() == DialogResult.OK)
            {
                FondoColorSeleccionado = FondoColor.Color;
                PnlLienzo.BackColor = FondoColorSeleccionado;
                BtnColorFondo.BackColor = FondoColorSeleccionado;

                if (FondoColorSeleccionado.R < 60 && FondoColorSeleccionado.G < 60 && FondoColorSeleccionado.B < 60)
                {
                    BtnColorFondo.ForeColor = Color.White;
                }
                else
                {
                    BtnColorFondo.ForeColor = Color.Black;
                }
            }
        }

        private void BtnP73_Click(object sender, EventArgs e)
        {
            //Dlg7Fibonacci Fibo = new Dlg7Fibonacci();
            //Fibo.Show();
        }

        private void CbxCambiarActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Practica;

            Practica = CbxCambiarActividad.SelectedIndex;

            if (Practica == 0)
            {
                LblXInicial.Text = "X Inicial";
                LblYInicial.Text = "Y Inicial";
                BtnDibujar.Visible = true;
                BtnP72.Visible = false;
                BtnP73.Visible = false;
                BtnSecuencia.Visible = false;
            }

            else if (Practica == 1)
            {
                LblXInicial.Text = "Espirales";
                LblYInicial.Text = "Separador";
                BtnDibujar.Visible = false;
                BtnP72.Visible = true;
                BtnP73.Visible = false;
                BtnSecuencia.Visible = false;
            }

            else if (Practica == 2)
            {
                LblXInicial.Text = "N/A";
                LblYInicial.Text = "N/A";
                LblLado.Text = "Anchura";
                BtnDibujar.Visible = false;
                BtnP72.Visible = false;
                BtnP73.Visible = true;
                BtnSecuencia.Visible = true;
            }
        }

        private void BtnSecuencia_Click(object sender, EventArgs e)
        {
            Dlg7Fibonacci Fibo = new Dlg7Fibonacci();
            Fibo.Show();
        }
    }
}
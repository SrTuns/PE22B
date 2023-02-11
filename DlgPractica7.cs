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
            Dlg7Fibonacci Fibo = new Dlg7Fibonacci();
            Fibo.Show();

            #region Intento 1
            //-------------------------------------------------------------------------
            //Intento 1.
            //-------------------------------------------------------------------------

            //Pen Pluma;
            //Pen Pluma2;
            //Graphics Lienzo;
            //float Anchura;
            //double Resultado;
            //double Resultado2;
            //double A;
            //double B;
            //double X;
            //double Y;

            //Anchura = float.Parse(TbxLado.Text.ToString());
            //Resultado = Anchura * 1.618;
            //Resultado2 = Resultado - Anchura;

            //A = Anchura / 1.618;
            //B = Anchura - Math.Round(A, 0);

            ////TbxAurea.Text = Resultado.ToString();
            ////TbxAurea2.Text = Resultado2.ToString();

            //A = Math.Round(A, 0);

            ////TbxAurea.Text = A.ToString();
            ////TbxAurea2.Text = B.ToString();



            //Pluma = new Pen(Color.Red);
            //Pluma2 = new Pen(Color.Blue);
            //Lienzo = PnlLienzo.CreateGraphics();
            ////Lienzo.DrawEllipse(Pluma, 40, 40, 40, 40);
            ////Lienzo.DrawCurve(Pluma, 40, 40, 40, 40);
            //Lienzo.DrawRectangle(Pluma2, (float)A, (float)A, (float)B, (float)B);
            ////Lienzo.DrawRectangle(Pluma, 370, 370, 230, 230);
            #endregion

            #region Intento 2
            //-------------------------------------------------------------------------
            //Intento 2.
            //-------------------------------------------------------------------------

            //Pen Pluma;
            //Graphics Lienzo;
            //float Anchura;
            //double PuntoAX = 0;
            //double PuntoAY = 0;
            //double PuntoBX = 0;
            //double PuntoBY = 0;
            //double A = 371;
            //double B = 229;
            //float X = 600;


            //Anchura = float.Parse(TbxLado.Text.ToString());
            //Lienzo = PnlLienzo.CreateGraphics();
            //Pluma = new Pen(Color.Red);

            //PuntoAY = A;
            //PuntoBX = A;

            //Lienzo.DrawLine(Pluma, (float)PuntoAX, (float)PuntoAY, (float)PuntoBX, (float)PuntoBY);

            //Point point1 = new Point((int)PuntoAX, (int)PuntoAY);
            //Point point3 = new Point(100, 100);
            //Point point2 = new Point((int)PuntoBX, (int)PuntoBY);
            //Point point4 = new Point(250, 50);
            //Point point5 = new Point(300, 100);
            //Point point6 = new Point(350, 200);
            //Point point7 = new Point(250, 250);
            //Point[] curvePoints = { point1, point3, point2 }; /*, point4, point5, point6, point7 };*/
            //Lienzo.DrawCurve(Pluma, curvePoints);

            //PuntoAY = 0;
            //PuntoBX = A;
            //PuntoBY = A;

            //Lienzo.DrawEllipse(Pluma, (float)PuntoAX, (float)PuntoAY, (float)PuntoBX, (float)PuntoBY);
            //Lienzo.DrawRectangle(Pluma, (float)PuntoAX, (float)PuntoAY, (float)PuntoBX, (float)PuntoBY);
            //Lienzo.DrawPie(Pluma, (float)PuntoAX, (float)PuntoAY, (float)(PuntoBX * 2), (float)(PuntoBY * 2), 180, 90);

            //PuntoAX = A;
            //PuntoBX = B;
            //PuntoBY = 229;

            //Lienzo.DrawRectangle(Pluma, (float)PuntoAX, (float)PuntoAY, (float)PuntoBX, (float)PuntoBY);

            //PuntoAX = (B * 2);
            //PuntoAY = (A * .618);
            //PuntoBX = 142;
            //PuntoBY = 142;

            //Lienzo.DrawRectangle(Pluma, (float)PuntoAX, (float)PuntoAY, (float)PuntoBX, (float)PuntoBY);

            #endregion

            #region Intento 3
            //-------------------------------------------------------------------------
            //Intento 3.
            //-------------------------------------------------------------------------

            // Pen Pluma;
            // //Pen Pluma2;
            // Graphics Lienzo;
            // float X;
            // float Y;
            // double Phi;
            // float Aux;
            // float Aux2;

            // Phi = 1.618;
            // X = PnlLienzo.Width / 2;
            // Y = PnlLienzo.Height / 2;
            // //X = 0;
            // //Y = 0;
            // Lienzo = PnlLienzo.CreateGraphics();
            // Pluma = new Pen(Color.Red);
            // Aux = 20;
            // Aux2 = float.Parse(TbxXInicial.Text);

            // //for (int i = 0; i < Aux2; i++)
            // //{

            // Lienzo.DrawLine(Pluma, X, Y, X - Aux, Y);
            // Lienzo.DrawLine(Pluma, X - Aux, Y, X - Aux, Y - Aux);
            //Lienzo.DrawLine(Pluma, X, Y, X - Aux, Y - Aux);
            // Lienzo.DrawLine(Pluma, X - Aux, Y - Aux, X - Aux, Y - (Aux * 2));
            // Lienzo.DrawLine(Pluma, X - Aux, Y - (Aux * 2), X + Aux, Y - (Aux * 2));
            //Lienzo.DrawLine(Pluma, X - Aux, Y - Aux, X + Aux, Y - (Aux * 2));
            // Lienzo.DrawLine(Pluma, X + Aux, Y - (Aux * 2), X + (Aux * 4), Y - (Aux * 2));
            // Lienzo.DrawLine(Pluma, X + (Aux * 4), Y - (Aux * 2), X + (Aux * 4), Y);
            //Lienzo.DrawLine(Pluma, X + Aux, Y - (Aux * 2), X + (Aux * 4), Y);
            // Lienzo.DrawLine(Pluma, X + (Aux * 4), Y, X + (Aux * 4), Y + (Aux * 2));
            // Lienzo.DrawLine(Pluma, X + (Aux * 4), Y + (Aux * 2), X - Aux, Y + (Aux * 2));
            //Lienzo.DrawLine(Pluma, X + (Aux * 4), Y, X - Aux, Y + (Aux * 2));
            // Lienzo.DrawLine(Pluma, X - Aux, Y + (Aux * 2), X - (Aux * 6), Y + (Aux * 2));
            // Lienzo.DrawLine(Pluma, X - (Aux * 6), Y + (Aux * 2), X - (Aux * 6), Y - (Aux * 2));
            //Lienzo.DrawLine(Pluma, X - Aux, Y + (Aux * 2), X - (Aux * 6), Y - (Aux * 2));
            // Lienzo.DrawLine(Pluma, X - (Aux * 6), Y - (Aux * 2), X - (Aux * 6), Y - (Aux * 8));
            // Lienzo.DrawLine(Pluma, X - (Aux * 6), Y - (Aux * 8), X + (Aux * 4), Y - (Aux * 8));
            //Lienzo.DrawLine(Pluma, X - (Aux * 6), Y - (Aux * 2), X + (Aux * 4), Y - (Aux * 8));
            // Lienzo.DrawLine(Pluma, X + (Aux * 4), Y - (Aux * 8), X + (Aux * 16), Y - (Aux * 8));
            // Lienzo.DrawLine(Pluma, X + (Aux * 16), Y - (Aux * 8), X + (Aux * 16), Y + (Aux * 2));
            // //Lienzo.DrawLine(Pluma, X + (Aux * 4), Y - (Aux * 8), X + (Aux * 16), Y + (Aux * 2));


            // Point point1 = new Point((int)(X + (Aux * 4)), (int)(Y - (Aux * 8)));
            // Point point2 = new Point((int)(X + (Aux * 16)), (int)(Y - (Aux * 8)));
            // Point point3 = new Point((int)(X + (Aux * 16)), (int)(Y + (Aux * 2)));

            // Point[] curvePoints = { point1, point2, point3 };
            // Lienzo.DrawCurve(Pluma, curvePoints);

            // //Lienzo.DrawLine(Pluma, X, Y, X - Aux, Y - Aux);
            // //Lienzo.DrawLine(Pluma, X - Aux, Y - (Aux * 2), X + (Aux * 2), Y + (Aux * 2));

            // //Aux = Aux + Aux;
            // //}
            #endregion

            //-------------------------------------------------------------------------
            //Intento 4.
            //-------------------------------------------------------------------------

            //int V0;
            //int V1;
            //int X;
            //int Y;
            //int Aux;
            Graphics Lienzo;
            //Pen Pluma;

            //V0 = 0;
            //V1 = 10;
            ////X = 0;
            ////Y = 0;
            //Y = 250;
            //X = 350;
            Lienzo = PnlLienzo.CreateGraphics();
            //Pluma = new Pen(Color.Red);
            ////X = int.Parse(TbxXInicial.Text);
            ////Y = int.Parse(TbxYInicial.Text);
            ////V1 = int.Parse(TbxLado.Text);


            #region Listo

            //////for (int i = 0; i < 6; i++)
            //////{
            //////Aux = V0;

            //////V0 = V1;
            //////V1 = Aux + V0;

            //////    //MessageBox.Show(V1.ToString());


            //////-------------------------------------------------------------------------
            //////BackUp.
            //////-------------------------------------------------------------------------
            ////////Lienzo.DrawLine(Pluma, X, Y, V1, Y);
            ////Lienzo.DrawRectangle(Pluma, X, Y, V1, V1);
            ////Lienzo.DrawRectangle(Pluma, X + V1, Y + V1, V1, -V1);
            ////Lienzo.DrawRectangle(Pluma, X, Y - (V1 * 2), (V1 * 2), (V1 * 2));
            ////Lienzo.DrawRectangle(Pluma, X - (V1 * 3), Y - (V1 * 2), (V1 * 3), (V1 * 3));
            ////Lienzo.DrawRectangle(Pluma, X - (V1 * 3), Y + V1, (V1 * 5), (V1 * 5));
            ////Lienzo.DrawRectangle(Pluma, X + (V1 * 2), Y - (V1 * 2), (V1 * 8), (V1 * 8));
            ////Lienzo.DrawRectangle(Pluma, X - (V1 * 3), Y - (V1 * 15), (V1 * 13), (V1 * 13));
            ////Lienzo.DrawRectangle(Pluma, X - (V1 * 24), Y - (V1 * 15), (V1 * 21), (V1 * 21));



            ////Lienzo.DrawPie(Pluma, X, Y - V1, V1 * 2, V1 * 2, 0, 90);
            ////Lienzo.DrawPie(Pluma, X - (V1 * 2), Y - (V1 * 2), V1 * 4, V1 * 4, 270, 90);
            ////Lienzo.DrawPie(Pluma, X - (V1 * 3), Y - (V1 * 2), V1 * 6, V1 * 6, 180, 90);
            ////Lienzo.DrawPie(Pluma, X - (V1 * 3), Y - (V1 * 4), V1 * 10, V1 * 10, 90, 90);
            ////Lienzo.DrawPie(Pluma, X - (V1 * 6), Y - (V1 * 10), V1 * 16, V1 * 16, 0, 90);
            ////Lienzo.DrawPie(Pluma, X - (V1 * 16), Y - (V1 * 15), V1 * 26, V1 * 26, 270, 90);
            ////Lienzo.DrawPie(Pluma, X - (V1 * 24), Y - (V1 * 15), (V1 * 42), (V1 * 42), 180, 90);



            ////    //X += V1;
            ////    Y += 100;
            ////    X += 100;
            ////}

            #endregion

            #region Intento 4.1
            ////Intento 4.1

            //int InicioGradosCirculo;
            //int FinGradosCirculo;
            //int Phi;
            //int AuxX;
            //int AuxY;
            //int Espacio;
            //int Curvas;

            //FinGradosCirculo = 90;
            //InicioGradosCirculo = 270;
            //Espacio = 10;
            //AuxX = 5;
            //AuxY = 5;

            //Curvas = int.Parse(NudPluma.Value.ToString());

            //////Lienzo.DrawPie(Pluma, X, Y - V1, V1 * 2, V1 * 2, 0, 90);
            //for (int i = 0; i < Curvas; i++)
            //{

            //    Aux = V0;

            //    V0 = V1;
            //    V1 = Aux + V0;

            //    Lienzo.DrawPie(Pluma, X - (Espacio * AuxX), Y - (Espacio * AuxY), (Espacio * V1), (Espacio * V1), InicioGradosCirculo, FinGradosCirculo);



            //    InicioGradosCirculo = InicioGradosCirculo - FinGradosCirculo;

            //    if (InicioGradosCirculo == 0)
            //    {
            //        InicioGradosCirculo = 270;
            //    }

            //    //V1 = (int)(V1 * .06);
            //}
        }
        #endregion

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
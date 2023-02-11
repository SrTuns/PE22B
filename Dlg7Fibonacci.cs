using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE22B_MAv2
{
    //-------------------------------------------------------------------------
    //Dialogo práctica 7.3 (Fibonacci).
    //MA. 31/10/2022
    //-------------------------------------------------------------------------
    public partial class Dlg7Fibonacci : Form
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        Color ColorCuadrado;
        Color ColorEspiral;
        Color ColorFondo;
        Graphics Lienzo;


        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public Dlg7Fibonacci()
        {
            InitializeComponent();
            ColorCuadrado = Color.Red;
            BtnCuadrado.BackColor = ColorCuadrado;
            ColorEspiral = Color.DarkSlateGray;
            BtnEspiral.BackColor = ColorEspiral;
            ColorFondo = Color.PaleTurquoise;
            BtnFondo.BackColor = ColorFondo;

            Lienzo = PbxLienzo.CreateGraphics();
        }

        //Obtener Secuencia de numeros con formula de suma 1 + 1 = 2 / 1 + 2 = 3...

        int SecuenciaFibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return (SecuenciaFibo(n - 1) + SecuenciaFibo(n - 2));
            }
        }

        //-------------------------------------------------------------------------
        //Botón para dibujar.
        //-------------------------------------------------------------------------

        private void BtnDibujar_Click(object sender, EventArgs e)
        {
            //Declaración de Variables.

            int X;
            int Y;
            int CantCuadros;
            int Espirales;
            int AnchoEspiral;
            int AnchoCuadrado;
            int Dibujo;
            float TcbZoom;
            float MultiplicadorZoom;
            float Zoom;
            Pen PlumaEspiral;
            Pen PlumaCuadrado;

            //Preparación de datos.

            AnchoEspiral = (int)NudEspiralGrosor.Value;
            AnchoCuadrado = (int)NudCuadradoGrosor.Value;

            X = int.Parse(TbxX.Text);
            Y = int.Parse(TbxY.Text);

            TcbZoom = TbZoom.Value;
            MultiplicadorZoom = (int)NudZoomMultiplicador.Value;
            Zoom = TcbZoom * MultiplicadorZoom;

            Dibujo = CbxDibujo.SelectedIndex;

            PlumaEspiral = new Pen(ColorEspiral, AnchoEspiral);
            PlumaCuadrado = new Pen(ColorCuadrado, AnchoCuadrado);

            Espirales = int.Parse(TbxCantEspirales.Text);
            CantCuadros = Espirales * 5;

            PbxLienzo.BackColor = ColorFondo;

            //Sistema de Limpieza Automática.

            if (CbAutoLimpieza.Checked == true)
            {
                Lienzo.Clear(BackColor);
            }

            //Creación de Espirales (Magia).

            for (int i = 1; i < CantCuadros; i++)
            {
                int Orientacion = i % 4;
                int Medida = (int)(SecuenciaFibo(i) * Zoom);
                int NumFibox1 = (int)(SecuenciaFibo(i - 1) * Zoom);
                int NumFibox2 = (int)(SecuenciaFibo(i - 2) * Zoom);

                //Switch Principal de creación de espirales.

                switch (Orientacion)
                {
                    case 0:
                        X = X + NumFibox1;

                        //Switch Secundario de selección de dibujado.

                        switch (Dibujo)
                        {
                            //0 = Ambos
                            //1 = Espirales
                            //2 = Cuadrados

                            //Prefix > Nombre00 > Primer Numero Switch Principal - Segundo Numero Switch Secundario

                            case 0:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                try
                                {
                                    Rectangle Rectangulo00 = new Rectangle(X - Medida, Y, Medida * 2, Medida * 2);
                                    float InicioAngulo00 = 270.0F;
                                    float FinalAngulo00 = 90.0F;
                                    Lienzo.DrawArc(PlumaEspiral, Rectangulo00, InicioAngulo00, FinalAngulo00);
                                }

                                catch
                                {

                                }
                                break;
                            case 1:
                                try
                                {
                                    Rectangle Rectangulo01 = new Rectangle(X - Medida, Y, Medida * 2, Medida * 2);
                                    float InicioAngulo01 = 270.0F;
                                    float FinalAngulo01 = 90.0F;
                                    Lienzo.DrawArc(PlumaEspiral, Rectangulo01, InicioAngulo01, FinalAngulo01);
                                }
                                catch
                                {

                                }
                                break;
                            case 2:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                break;
                        }

                        break;

                    case 1:
                        X = X - NumFibox2;
                        Y = Y + NumFibox1;

                        switch (Dibujo)
                        {
                            case 0:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                Rectangle Rectangulo10 = new Rectangle(X - Medida, Y - Medida, Medida * 2, Medida * 2);
                                float InicioAngulo10 = 0.0F;
                                float FinAngulo10 = 90.0F;
                                Lienzo.DrawArc(PlumaEspiral, Rectangulo10, InicioAngulo10, FinAngulo10);
                                break;

                            case 1:
                                Rectangle Rectangulo11 = new Rectangle(X - Medida, Y - Medida, Medida * 2, Medida * 2);
                                float InicioAngulo11 = 0.0F;
                                float FinAngulo11 = 90.0F;
                                Lienzo.DrawArc(PlumaEspiral, Rectangulo11, InicioAngulo11, FinAngulo11);
                                break;

                            case 2:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                break;
                        }
                        break;

                    case 2:
                        X = X - Medida;
                        Y = Y - NumFibox2;

                        switch (Dibujo)
                        {
                            case 0:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                Rectangle Rectangulo20 = new Rectangle(X, Y - Medida, Medida * 2, Medida * 2);
                                float InicioAngulo20 = 90.0F;
                                float FinAngulo20 = 90.0F;
                                Lienzo.DrawArc(PlumaEspiral, Rectangulo20, InicioAngulo20, FinAngulo20);
                                break;

                            case 1:
                                Rectangle Rectangulo21 = new Rectangle(X, Y - Medida, Medida * 2, Medida * 2);
                                float InicioAngulo21 = 90.0F;
                                float FinAngulo21 = 90.0F;
                                Lienzo.DrawArc(PlumaEspiral, Rectangulo21, InicioAngulo21, FinAngulo21);
                                break;

                            case 2:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                break;
                        }
                        break;

                    case 3:
                        Y = Y - Medida;

                        switch (Dibujo)
                        {
                            case 0:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                Rectangle Rectangulo30 = new Rectangle(X, Y, Medida * 2, Medida * 2);
                                float InicioAngulo30 = 180.0F;
                                float FinAngulo30 = 90.0F;
                                Lienzo.DrawArc(PlumaEspiral, Rectangulo30, InicioAngulo30, FinAngulo30);
                                break;

                            case 1:
                                Rectangle Rectangulo31 = new Rectangle(X, Y, Medida * 2, Medida * 2);
                                float InicioAngulo31 = 180.0F;
                                float FinAngulo31 = 90.0F;
                                Lienzo.DrawArc(PlumaEspiral, Rectangulo31, InicioAngulo31, FinAngulo31);
                                break;

                            case 2:
                                Lienzo.DrawRectangle(PlumaCuadrado, X, Y, Medida, Medida);
                                break;
                        }
                        break;
                }
            }
        }

        //-------------------------------------------------------------------------
        //Método.
        //-------------------------------------------------------------------------

        //Seleccionar método.

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Metodo;

            Metodo = comboBox1.SelectedIndex;

            if (Metodo == 0)
            {
                LblX.Visible = true;
                LblY.Visible = true;
                TbxX.Visible = true;
                TbxY.Visible = true;
                LblPuntero.Visible = false;
                LblXPuntero.Visible = false;
                LblYPuntero.Visible = false;
            }
            else if (Metodo == 1)
            {
                LblX.Visible = false;
                LblY.Visible = false;
                TbxX.Visible = false;
                TbxY.Visible = false;
                LblPuntero.Visible = true;
                LblXPuntero.Visible = true;
                LblYPuntero.Visible = true;
            }
        }

        //Selección de coordenadas vía doble click.

        private void PbxLienzo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TbxX.Text = e.X.ToString();
            TbxY.Text = e.Y.ToString();
            LblXPuntero.Text = "X = " + e.X.ToString();
            LblYPuntero.Text = "Y = " + e.Y.ToString();
        }

        //-------------------------------------------------------------------------
        //Color.
        //-------------------------------------------------------------------------

        //Seleccionar color para espiral.

        private void BtnEspiral_Click(object sender, EventArgs e)
        {
            ColorDialog DlgSelectorColor = new ColorDialog();

            DlgSelectorColor.AllowFullOpen = true;
            DlgSelectorColor.ShowHelp = true;
            DlgSelectorColor.Color = ColorEspiral;

            if (DlgSelectorColor.ShowDialog() == DialogResult.OK)
            {
                ColorEspiral = DlgSelectorColor.Color;
                BtnEspiral.BackColor = ColorEspiral;

                if (ColorEspiral.R < 60 && ColorEspiral.G < 60 && ColorEspiral.B < 60)
                {
                    BtnEspiral.ForeColor = Color.White;
                }
                else
                {
                    BtnEspiral.ForeColor = Color.Black;
                }
            }
        }

        //Seleccionar color para cuadrados

        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            ColorDialog DlgSelectorColor = new ColorDialog();

            DlgSelectorColor.AllowFullOpen = true;
            DlgSelectorColor.ShowHelp = true;
            DlgSelectorColor.Color = ColorCuadrado;

            if (DlgSelectorColor.ShowDialog() == DialogResult.OK)
            {
                ColorCuadrado = DlgSelectorColor.Color;
                BtnCuadrado.BackColor = ColorCuadrado;

                if (ColorCuadrado.R < 60 && ColorCuadrado.G < 60 && ColorCuadrado.B < 60)
                {
                    BtnCuadrado.ForeColor = Color.White;
                }
                else
                {
                    BtnCuadrado.ForeColor = Color.Black;
                }
            }
        }

        //Seleccionar color para fondo.

        private void BtnFondo_Click(object sender, EventArgs e)
        {
            ColorDialog FondoColor = new ColorDialog();

            FondoColor.AllowFullOpen = true;
            FondoColor.ShowHelp = true;
            FondoColor.Color = ColorFondo;

            if (FondoColor.ShowDialog() == DialogResult.OK)
            {
                ColorFondo = FondoColor.Color;
                PbxLienzo.BackColor = ColorFondo;
                BtnFondo.BackColor = ColorFondo;

                if (ColorFondo.R < 60 && ColorFondo.G < 60 && ColorFondo.B < 60)
                {
                    BtnFondo.ForeColor = Color.White;
                }
                else
                {
                    BtnFondo.ForeColor = Color.Black;
                }
            }
        }

        //-------------------------------------------------------------------------
        //Imagen.
        //-------------------------------------------------------------------------

        //Algoritmo para cargar imagen.

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirImagen = new OpenFileDialog();
            AbrirImagen.InitialDirectory = @"C:\\";
            AbrirImagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            AbrirImagen.Title = "Importar Imagen";

            if (AbrirImagen.ShowDialog() == DialogResult.OK)
            {
                PbxLienzo.ImageLocation = AbrirImagen.FileName;
                PbxLienzo.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Algoritmo para guardar imagen.

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image *.bmp|";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.Filter != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.PbxLienzo.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.PbxLienzo.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }

        //Algoritmo para escoger modo de imagen.

        private void CbxModoImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ModoImagen;

            ModoImagen = CbxModoImagen.SelectedIndex;

            switch (ModoImagen)
            {
                case 0:
                    PbxLienzo.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 1:
                    PbxLienzo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    PbxLienzo.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 3:
                    PbxLienzo.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 4:
                    PbxLienzo.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        //Botón para limpizar lienzo.

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Lienzo.Clear(BackColor);
        }

        private void BtnGirasol_Click(object sender, EventArgs e)
        {
            TbxX.Text = "560";
            TbxY.Text = "369";

            TbZoom.Value = 1;
            NudZoomMultiplicador.Value = 5;

            CbxModoImagen.SelectedIndex = 4;

            TbxCantEspirales.Text = "3";
        }

        private void BtnCookie_Click(object sender, EventArgs e)
        {
            TbxX.Text = "410";
            TbxY.Text = "181";

            TbZoom.Value = 1;
            NudZoomMultiplicador.Value = 5;

            CbxModoImagen.SelectedIndex = 3;

            TbxCantEspirales.Text = "3";
        }
    }
}
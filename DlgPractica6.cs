using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PE22B_MAv2
{
    //-------------------------------------------------------------------------
    //Dialogo Principal de la práctica 6.
    //MA. 17/10/2022
    //-------------------------------------------------------------------------
    public partial class DlgPractica6 : Form
    {
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica6()
        {
            InitializeComponent();
        }

        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            int Renglones;
            int Columnas;

            DgvPrincipal.Rows.Clear();
            DgvPrincipal.Columns.Clear();

            Renglones = int.Parse(TbxRenglones.Text);
            Columnas = int.Parse(TbxColumnas.Text);

            for (int i = 0; i < Columnas; i++)
            {
                DgvPrincipal.Columns.Add("Col", "C" + (i + 1));
            }

            for (int i = 0; i < Renglones; i++)
            {
                DgvPrincipal.Rows.Add();
            }
        }

        //-------------------------------------------------------------------------
        //Calcula la sumatoria del triángulo.
        //-------------------------------------------------------------------------
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int Renglones;
            int Columnas;
            int r;
            int c;
            Random Aleatorio;

            Aleatorio = new Random();

            //Recupera las dimenciones

            Renglones = int.Parse(TbxRenglones.Text);
            Columnas = int.Parse(TbxColumnas.Text);


            //Llenar con numeros aleatorios.

            //r = 0;

            //while (r <= Renglones - 1)
            //{
            //    c = 0;

            //    while (c <= Columnas - 1)
            //    {
            //        DgvPrincipal.Rows[r].Cells[c].Value = (r+1).ToString() + ", " + (c+1).ToString();
            //        DgvPrincipal.Rows[r].Cells[c].Value = Aleatorio.Next(100);

            //        c++;
            //    }

            //    r++;
            //}

            //Colorea el triángulo.

            r = 0;

            while (r <= Renglones - 1)
            {
                c = 0;

                while (c <= Columnas - 1)
                {
                    int AuxR;
                    
                    if (ChbInvertir.Checked)
                    {
                        AuxR = Renglones - r - 1;
                    }
                    else
                    {
                        AuxR = r;
                    }

                    DgvPrincipal.Rows[r].Cells[c].Value = Aleatorio.Next(100);
                    DgvPrincipal.Rows[AuxR].Cells[c].Style.BackColor = Color.GreenYellow;
                        
                    for (int i = 0; i < r; i++)
                    {
                       DgvPrincipal.Rows[AuxR].Cells[i].Style.BackColor = Color.White;
                       DgvPrincipal.Rows[AuxR].Cells[Columnas-i-1].Style.BackColor = Color.White;
                    }

                    //for (int i = 0; i < r; i++)
                    //{
                    //    DgvPrincipal.Rows[r].Cells[i].Style.BackColor = Color.White;
                    //}

                    c++;
                }

                r++;
            }

            long Sumatoria;

            Sumatoria = 0;

            for (int rr = 0; rr <= Renglones - 1; rr++)
            {
                for (int cc = 0; cc <= Columnas - 1; cc++)
                {
                    if (DgvPrincipal.Rows[rr].Cells[cc].Style.BackColor == Color.GreenYellow)
                    {
                        Sumatoria = Sumatoria + long.Parse(DgvPrincipal.Rows[rr].Cells[cc].Value.ToString());
                    }
                }
            }

            TbxSumatoria.Text ="Sumatoria amarilla: " +  Sumatoria.ToString();
        }
    }
}

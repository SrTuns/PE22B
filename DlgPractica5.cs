using System;
using System.Windows.Forms;

namespace PE22B_MAv2
{

    //-------------------------------------------------------------------------
    //Dialogo Principal de la práctica 5.
    //MA. 10/10/2022
    //-------------------------------------------------------------------------
    public partial class DlgPractica5 : Form
    {
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica5()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------
        //Botón de llamado de la matriz de la práctica 5.
        //-------------------------------------------------------------------------
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
                DgvPrincipal.Columns.Add("Col", "C" + (i+1));
            }

            for (int i = 0; i < Renglones; i++)
            {
                DgvPrincipal.Rows.Add();
            }

        }

        //-------------------------------------------------------------------------
        //Calcular la secuencia de Collatz.
        //-------------------------------------------------------------------------
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            long N;

            DgvPrincipal.Rows.Clear();
            DgvPrincipal.Columns.Clear();

            DgvPrincipal.Columns.Add("Col", "N");

            N = long.Parse(TbxCapturar.Text);

            Collatz(N);

            LblPasos.Text = (DgvPrincipal.RowCount - 1).ToString() + " pasos.";
        }

        //-------------------------------------------------------------------------
        //Función para resolver la secuencia de Collatz de forma recursiva.
        //-------------------------------------------------------------------------
        private void Collatz(long N)
        {
            long Resultado;

            DgvPrincipal.Rows.Add(N.ToString());

            if (N != 1)
            {
                //Si N es par...

                if (N % 2 == 0)
                {
                    Resultado = N / 2;
                }
                else
                {
                    Resultado = (N * 3) + 1;
                }

                Collatz(Resultado);
            }

        }
    }
}

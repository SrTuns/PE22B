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
    public partial class DlgPractica3 : Form
    {
        public DlgPractica3()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            DlgPrincipal DlgPrincipal = new DlgPrincipal();
            DlgPrincipal.Show();

            this.Close();
        }

        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            DlgPractica2 Practica2 = new DlgPractica2();
            Practica2.Show();

            this.Close();
        }

        private void BtnPractica4_Click(object sender, EventArgs e)
        {
            DlgPractica4 Practica4 = new DlgPractica4();
            Practica4.Show();

            this.Close();
        }

        //-------------------------------------------------------------------------
        //Algoritmo para evaluar un proyecto de inversión (VPN).
        //-------------------------------------------------------------------------
        private void P3BtnCalcular_Click(object sender, EventArgs e)
        {
            int NumFlujos;
            double Sumatoria;
            double TMAR;
            double InversionI;
            double VPN;
            double Auxiliar;

            //Valida datos capturados.

            if (P3TbxInversionI.Text == "")
            {
                MessageBox.Show("Capture la inversión inicial.");
                return;
            }

            if (!double.TryParse(P3TbxInversionI.Text, out Auxiliar))
            {
                MessageBox.Show("Solo se permiten numeros enteros o decimales.");
                P3TbxInversionI.Focus();
                return;
            }

            if (P3TbxTMAR.Text == "")
            {
                MessageBox.Show("Capture la tasa mínima aceptada de rendimiento.");
                return;
            }

            if (!double.TryParse(P3TbxTMAR.Text, out Auxiliar))
            {
                MessageBox.Show("Solo se permiten numeros enteros o decimales.");
                P3TbxTMAR.Focus();
                return;
            }

            //Obtiene valores de trabajo.

            InversionI = double.Parse(P3TbxInversionI.Text);
            TMAR = double.Parse(P3TbxTMAR.Text);
            TMAR = TMAR / 100;

            //Pregunta cuadros hay.

            NumFlujos = P3DgvFlujosEfectivo.Rows.Count - 1;
            Sumatoria = 0;

            for (int i = 0; i < NumFlujos; i++)
            {
                double ValorFuturo;
                double ValorPresente;

                ValorFuturo = double.Parse(P3DgvFlujosEfectivo.Rows[i].Cells[1].Value.ToString());
                ValorPresente = ValorFuturo / Math.Pow((1 + TMAR), i + 1);

                Sumatoria = Sumatoria + ValorPresente;

            }

            //Calcula el valor presente neto del proyecto.

            VPN = -InversionI + Sumatoria;
            VPN = Math.Round(VPN, 2);

            //Presenta al usuario los resultados.

            P3TbxResultado.Text = VPN.ToString();

            //Determina el color de fondo en virtud al resultado.

            if (VPN > 0)
            {
                P3TbxResultado.ForeColor = Color.Black;
                P3TbxResultado.BackColor = Color.LimeGreen;
            }
            else
            {
                P3TbxResultado.ForeColor = Color.White;
                P3TbxResultado.BackColor = Color.Red;
            }
        }

        private void P3BtnLimpiar_Click(object sender, EventArgs e)
        {
            P3TbxInversionI.Text = "";
            P3TbxTMAR.Text = "";
            P3TbxResultado.Text = "";
            P3TbxResultado.ForeColor = Color.White;
            P3TbxResultado.BackColor = Color.White;
            P3TbxInversionI.Text = "";
            P3DgvFlujosEfectivo.Rows.Clear();
            P3TbxInversionI.Focus();
        }
    }
}

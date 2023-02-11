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
    public partial class DlgPractica1 : Form
    {
        public DlgPractica1()
        {
            InitializeComponent();
        }

        private void BtnMenú_Click(object sender, EventArgs e)
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

        private void Mamaguevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola!, bienvenido seas!");
        }
    }
}

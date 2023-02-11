using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace PE22B_MAv2
{
    public partial class DlgPractica2 : Form
    {
        public DlgPractica2()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            DlgPrincipal DlgPrincipal = new DlgPrincipal();
            DlgPrincipal.Show();

            this.Close();
        }

        private void BtnPractica3_Click(object sender, EventArgs e)
        {
            DlgPractica3 Practica3 = new DlgPractica3();
            Practica3.Show();

            this.Close();
        }

        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            DlgPractica1 Practica1 = new DlgPractica1();
            Practica1.Show();

            this.Close();
        }

        //-------------------------------------------------------------------------
        //Llena datos de pruebas.
        //-------------------------------------------------------------------------
        private void P2BtnLlenar_Click(object sender, EventArgs e)
        {
            //Limpia los datos previos.
            P2DgvDatos.Rows.Clear();
            P2DgvDatos.Rows.Add();

            //Agregas renglones de datos de prueba.

            for (int i = 1; i <= 26; i++)
            {
                P2DgvDatos.Rows.Add();
                P2DgvDatos.Rows[i - 1].Cells[0].Value = i.ToString(); //
                P2DgvDatos.Rows[i - 1].Cells[1].Value = "Alumno" + i;

                if (i > 9)
                {
                    P2DgvDatos.Rows[i - 1].Cells[2].Value = "22-07-20" + i;
                    P2DgvDatos.Rows[i - 1].Cells[3].Value = "ABCD" + i + "0101";
                }
                else
                {
                    P2DgvDatos.Rows[i - 1].Cells[2].Value = "22-07-200" + i;
                    P2DgvDatos.Rows[i - 1].Cells[3].Value = "ABCD0" + i + "0101";
                }
            }

        }

        //-------------------------------------------------------------------------
        //Boton importar.
        //-------------------------------------------------------------------------
        private void P2BtnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog;
            DialogResult Resultado;
            String NombreArchivo;
            String RutaArchivo;

            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los Archivos (*.*)|*.*";
            OpenFileDialog.FilterIndex = 1;

            Resultado = OpenFileDialog.ShowDialog();

            if (Resultado == DialogResult.OK)
            {
                NombreArchivo = OpenFileDialog.SafeFileName.Substring(0, OpenFileDialog.SafeFileName.IndexOf("."));
                RutaArchivo = OpenFileDialog.FileName.Substring(0, OpenFileDialog.FileName.IndexOf(NombreArchivo) - 1);

                LeerArchivoExcel(RutaArchivo, NombreArchivo);
            }
        }

        //-------------------------------------------------------------------------
        //Algoritmo para leer el contenido de un archivo de Excel.
        //-------------------------------------------------------------------------
        private void LeerArchivoExcel(string RutaArchivo, string NombreArchivo)
        {
            _Application AppExcel;
            _Workbook LibroExcel;
            _Worksheet HojaExcel;
            double Codigo;
            string Nombre;
            string ApellidoP;
            string ApellidoM;
            DateTime FechaNacimiento;
            int i;

            //Crear objeto de interoperabilidad con Excel.

            AppExcel = new Microsoft.Office.Interop.Excel.Application();
            LibroExcel = AppExcel.Workbooks.Open(RutaArchivo + "\\" + NombreArchivo);

            //Localiza la hoja de trabajo.

            HojaExcel = LibroExcel.Sheets["Sheet1"];

            //Limpia datos previos de la tabla.

            P2DgvDatos.Rows.Clear();

            //Mientras encuentre códigos de alumnos.

            i = 2;
            while (((Range)HojaExcel.Cells[i, 1]).Value != null) // i = Renglon - 1 = Columna -*- Null es cuando detecta que no hay valor se termina y ya no escribe.
            {

                //Recupera y valida datos.

                Codigo = (double)((Range)HojaExcel.Cells[i, 1]).Value; //Convierte los valores de manera double
                Nombre = (string)((Range)HojaExcel.Cells[i, 4]).Value;

                if (((Range)HojaExcel.Cells[i, 2]).Value != null)
                {
                    ApellidoP = (string)((Range)HojaExcel.Cells[i, 2]).Value;
                }
                else
                {
                    ApellidoP = "";
                }

                if (((Range)HojaExcel.Cells[i, 3]).Value != null)
                {
                    ApellidoM = (string)((Range)HojaExcel.Cells[i, 3]).Value;
                }
                else
                {
                    ApellidoM = "";
                }

                if (((Range)HojaExcel.Cells[i, 5]).Value != null)
                {
                    FechaNacimiento = (DateTime)((Range)HojaExcel.Cells[i, 5]).Value;
                }
                else
                {
                    FechaNacimiento = DateTime.Now; //TODO
                }
                //Llena nuevo reglón de la tabla.

                P2DgvDatos.Rows.Add();
                P2DgvDatos.Rows[i - 2].Cells[0].Value = Codigo.ToString();
                P2DgvDatos.Rows[i - 2].Cells[1].Value = Nombre.ToString();
                P2DgvDatos.Rows[i - 2].Cells[2].Value = ApellidoP.ToString();
                P2DgvDatos.Rows[i - 2].Cells[3].Value = ApellidoM.ToString();
                P2DgvDatos.Rows[i - 2].Cells[4].Value = FechaNacimiento.ToString("dd/MM/yyyy");
                P2DgvDatos.Rows[i - 2].Cells[5].Value = GeneraRFC(ApellidoP, ApellidoM, Nombre, FechaNacimiento);

                i++;
            }

            //Terminar objeto de interoperabilidad con Excel.

            AppExcel.Quit();
        }

        //-------------------------------------------------------------------------
        //Algoritmo para generar el RFC de una persona.
        //-------------------------------------------------------------------------
        private string GeneraRFC(string ApellidoP, string ApellidoM,
            string Nombre, DateTime FechaNacimiento)
        {
            string RFC;
            string Letra;

            Letra = "";

            //Obtiene la primera letra del apellido paterno.

            RFC = ApellidoP.Substring(0, 1);

            //Obtiene la primera vocal del apellido paterno.

            for (int i = 1; i < ApellidoP.Length; i++)
            {
                Letra = ApellidoP.Substring(i, 1);

                if (Letra == "A" || Letra == "E" || Letra == "I" || Letra == "O" || Letra == "U")
                {
                    break;
                }
            }

            RFC = RFC + Letra;

            //Obtiene la primera letra del apellido materno.

            if (ApellidoM == "")
            {
                RFC = RFC + "X";
            }
            else
            {
                RFC = RFC + ApellidoM.Substring(0, 1);
            }

            //Obtiene la primera letra del nombre.

            RFC = RFC + Nombre.Substring(0, 1);

            //Agrega el año de nacimiento.

            RFC = RFC + FechaNacimiento.ToString("yy");

            //Agrega el mes de nacimiento.

            RFC = RFC + FechaNacimiento.ToString("MM");

            //Agrega el día de nacimiento.

            RFC = RFC + FechaNacimiento.ToString("dd");

            return RFC;
        }
    }
}

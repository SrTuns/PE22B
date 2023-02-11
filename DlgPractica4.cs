using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PE22B_MAv2
{
    //-------------------------------------------------------------------------
    //Dialogo de la práctica 4.
    //MA. 28/09/2022
    //-------------------------------------------------------------------------
    public partial class DlgPractica4 : Form
    {
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica4()
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

        private void BtnPractica5_Click(object sender, EventArgs e)
        {
            DlgPractica5 Practica5 = new DlgPractica5();
            Practica5.Show();

            this.Close();
        }

        //-------------------------------------------------------------------------
        //Obtiene las coordenadas de un lugar a través del API de Google Maps.
        //-------------------------------------------------------------------------
        private async void BtnObtenerCoordenadas_Click(object sender, EventArgs e)
        {
            //Valida datos de trabajo
            if (TbxLugar.Text == "")
            {
                return;
            }

            //Obtiene Coordenadas

            await GetCoordenadas();
        }

        //-------------------------------------------------------------------------
        //Obtiene las coordenadas geografcias de forma asincrona.
        //-------------------------------------------------------------------------
        public async Task GetCoordenadas()
        {
            //Declaración de variables.

            HttpClient ClienteHttp;
            Uri Direccion;
            HttpResponseMessage RespuestaHttp;
            string ContenidoHttp;
            string Descripcion;
            string Latitud;
            string Longitud;
            string Llave;
            string Lugar;
            string Status;
            XmlDocument DocumentoXml;
            XmlNodeList elemList;
            XmlElement bookElement;

            //Limpia posible datos previos.

            TbxLatitudGrados.Text = "";
            TbxLongitudGrados.Text = "";
            LblLatitudNS.Text = "";
            LblLongitudEO.Text = "";

            //Prepara datos de trabajo.

            Llave = "AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI";
            Lugar = TbxLugar.Text;

            //Consulta la API de geolocalización de Google Maps.

            try
            {
                ClienteHttp = new HttpClient();
                Direccion = new Uri("https://maps.googleapis.com/maps/api/geocode/");
                ClienteHttp.BaseAddress = Direccion;

                RespuestaHttp = await ClienteHttp.GetAsync("xml?address=" + Lugar + "&key=" + Llave);
                ContenidoHttp = await RespuestaHttp.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show("Sin conexión a internet: " + e.Message);
                return;
            }

            //Procesa la respuesta XML.

            DocumentoXml = new XmlDocument();
            DocumentoXml.LoadXml(ContenidoHttp);

            elemList = DocumentoXml.GetElementsByTagName("status");
            bookElement = (XmlElement)elemList[0];

            if (bookElement == null)
            {
                TbxLatitud.Text = "";
                TbxLongitud.Text = "";
                TbxDescripcion.Text = "¡Algo ocurrio y no se pudo ejecutar!";
                return;
            }

            Status = bookElement.InnerText;

            elemList = DocumentoXml.GetElementsByTagName("formatted_address");
            bookElement = (XmlElement)elemList[0];

            if (bookElement == null)
            {
                TbxLatitud.Text = "";
                TbxLongitud.Text = "";
                TbxDescripcion.Text = "¡Lugar no encontrado!";
                return;
            }

            Descripcion = bookElement.InnerText;

            elemList = DocumentoXml.GetElementsByTagName("location");
            bookElement = (XmlElement)elemList[0];
            Latitud = bookElement["lat"].InnerText;
            Longitud = bookElement["lng"].InnerText;

            //Presenta los resultados al usuario.

            TbxLatitud.Text = Latitud;
            TbxLongitud.Text = Longitud;
            TbxDescripcion.Text = Descripcion;
        }

        private async void TbxLugar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetCoordenadas();
            }
        }

        //-------------------------------------------------------------------------
        //Convierte coordenadas gregráficas decimales a GMS.
        //-------------------------------------------------------------------------

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double Latitud;
            double Longitud;
            int Grados;
            int Minutos;
            double Segundos;

            //Obtiene valores en decimal.

            Latitud = double.Parse(TbxLatitud.Text);
            Longitud = double.Parse(TbxLongitud.Text);

            //Procesa la conversión de latitud.

            ProcesaConversionCoordenada(Latitud, out Grados, out Minutos, out Segundos, LblLatitudNS, TbxLatitudGrados, "Sur", "Norte");

            //Procesa la conversión de longitud.

            ProcesaConversionCoordenada(Latitud, out Grados, out Minutos, out Segundos, LblLongitudEO, TbxLongitudGrados, "Oeste", "Este");
        }

        //-------------------------------------------------------------------------
        //Algoritmo para convertir coordenadas decimales a GMS.
        //-------------------------------------------------------------------------

        private void ConvierteDecimalesAGMS(double Valor, out int Grados, out int Minutos, out double Segundos) // X, Y1, Y2, Y3
        {
            Grados = (int)Valor;
            Valor = Math.Abs(Valor - Grados);
            Minutos = (int)(Valor * 60);
            Valor = Valor - (double)Minutos / 60;
            Segundos = (double)(Valor * 3600);
            Segundos = Math.Round(Segundos, 4);
        }

        //-------------------------------------------------------------------------
        //Procesa la conversión de coordenadas.
        //Valor = 
        //Grados = 
        //Minutos = 
        //-------------------------------------------------------------------------
        private void ProcesaConversionCoordenada(double Valor, out int Grados, out int Minutos, out double Segundos, 
            Label LblDireccion, TextBox TbxReceptor, string Cardinal1, string Cardinal2)
        {

            ConvierteDecimalesAGMS(Valor, out Grados, out Minutos, out Segundos);

            if (Grados < 0)
            {
                LblDireccion.Text = Cardinal1;
            }
            else
            {
                LblDireccion.Text = Cardinal2;
            }

            TbxReceptor.Text = Math.Abs(Grados).ToString() + "° " + Minutos.ToString() + "' " + Segundos.ToString() + "\"";
        }

        //-------------------------------------------------------------------------
        //Genera el archivo KML del lugar buscado.
        //-------------------------------------------------------------------------
        private void BtnGeneraKML_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            outputFile = new StreamWriter("C:\\Users\\PC\\Desktop\\" + TbxLugar.Text + ".kml");

            string[] lineas = {
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>",
                "<kml xmlns=\"http://www.opengis.net/kml/2.2\">",
                "  <Placemark>",
                "    <name>",
                "        " + TbxLugar.Text,
                "    </name>",
                "    <description>",
                "         " + TbxDescripcion.Text,
                "    </description>",
                "    <Point>",
                "        <extrude>",
                "           1",
                "        </extrude>",
                "        <altitudeMode>",
                "           relativeToGround",
                "        </altitudeMode>",
                "        <coordinates>",
                "           " + TbxLongitud.Text + "," + TbxLatitud.Text + "," + TbAlturaPunto.Value * 100,
                "        </coordinates>",
                "    </Point>",
                "  </Placemark>",
                "</kml>"};

            foreach (string linea in lineas)
            {
                outputFile.WriteLine(linea);
            }

            outputFile.Close();
        }

        double Altura;
        private void TbAlturaPunto_Scroll(object sender, EventArgs e)
        {
            //double Altura;

            Altura = TbAlturaPunto.Value * 100;

            LblAltura.Text = Altura.ToString();
        }
    }
}
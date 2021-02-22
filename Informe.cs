using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Informe : Form
    {
        public List<Monopatin> monopatines;
        public List<Cliente> clientes;
        public Informe()
        {
            InitializeComponent();
        }

        public Informe(List<Monopatin> monopatines, List<Cliente> clientes)
        {
            InitializeComponent();
            this.monopatines = monopatines;
            this.clientes = clientes;
        }

        private void Informe_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.EnableExternalImages = true;

            String asientos = "";
            /*
            foreach (Monopatin m in monopatines)
            {
                monopatines += "Asiento_" + a.columna + "_" + a.fila;
            }
            string ruta = Application.StartupPath + sala.ruta;

            

            
            /*Para cargar la imagen de manera dinámica, primero hemos de
            agregar un parámetro para la ruta. Luego insertamos en el informe
            una imagen, el origen de la imagen ha de ser “externo2 y en valor
            establecemos el parámetro.
            Luego insertamos la ruta de la imagen en el parámetro string
            "rutaImagen" siendo qrcode.png el código generado en el paso
            anterior (como se muestra continuación)*/
            
            
            


            ReportParameter[] parameters = new ReportParameter[2];

            string foto = Application.StartupPath + @"\Imagenes\cadiz.jpg";
            parameters[0] = new ReportParameter("logo", Application.StartupPath + @"\Imagenes\cadiz.jpg");

            float media = 0;
            foreach(Monopatin m in monopatines)
            {

                media = media + m.vecesAlquilado;

            }
            parameters[1] = new ReportParameter("Media", (media/monopatines.Count())+"");
            reportViewer1.LocalReport.SetParameters(parameters);



            /*         
         ReportParameter importe = new ReportParameter("Media", precio + "€", true);
         reportViewer1.LocalReport.SetParameters(importe);
*/
            /*
            Monopatin aa = new Monopatin(1, "marca1", 1, 1, 1);
            ReportParameter aaa = new ReportParameter("monopatin", precio + "€", true);
            reportViewer1.LocalReport.SetParameters(aaa);


            ReportParameter a = new ReportParameter("alquiler", precio + "€", true);
            reportViewer1.LocalReport.SetParameters(a);


            */






            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",monopatines ));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2",clientes));

            List<Monopatin> monopatins = new List<Monopatin>();

            foreach(Cliente c in clientes)
            {

                foreach(Monopatin m in c.listaMonopatines)
                {

                    monopatins.Add(m);
                }
            }
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3",monopatins));

            reportViewer1.RefreshReport();
        }
    }
}

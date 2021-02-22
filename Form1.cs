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
    public partial class Form1 : Form
    {

        public List<Monopatin> monopatines;
        public List<Cliente> clientes;
        public static int cont = 0;

        public Form1()
        {
            InitializeComponent();
            this.monopatines = new List<Monopatin>();
            this.clientes = new List<Cliente>();
        }

        public Form1(List<Monopatin> monopatines, List<Cliente> clientes)
        {
            InitializeComponent();
            this.monopatines = monopatines;
            this.clientes = clientes;

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            if (cont == 0)
            {

                monopatines.Add(new Monopatin(1, "marca1", 1, 1, 1));
                monopatines.Add(new Monopatin(2, "marca2", 2, 2, 2));
                monopatines.Add(new Monopatin(3, "marca3", 3, 3, 3));
                monopatines.Add(new Monopatin(4, "marca4", 4, 4, 4));
                monopatines.Add(new Monopatin(5, "marca5", 5, 5, 5));



                clientes.Add(new Cliente("nombre1", "apellido1", "dni1", 1, 1, new List<IMonopatin>()));
                clientes.Add(new Cliente("nombre2", "apellido2", "dni2", 2, 2, new List<IMonopatin>()));
                clientes.Add(new Cliente("nombre3", "apellido3", "dni3", 3, 3, new List<IMonopatin>()));
                clientes.Add(new Cliente("nombre4", "apellido4", "dni4", 4, 4, new List<IMonopatin>()));
                clientes.Add(new Cliente("nombre5", "apellido5", "dni5", 5, 5, new List<IMonopatin>()));




                for (int i = 0; i < 5; i++)
                {

                    clientes[i].listaMonopatines.Add(new Monopatin(i + 5, "marca" + (i + 5), i + 5, i + 5, i + 5));


                }
                cont++;

            }

            foreach (Monopatin m in monopatines)
            {

                if (m == null)
                {

                }
                else
                {

                    lb_monopatin.Items.Add(m);

                }
                
            }

            foreach (Cliente c in clientes)
            {

                lb_cliente.Items.Add(c);
            }



            
        }

        private void btn_toForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(monopatines,clientes);

            this.Hide();

            f2.Show();
        }

        private void lb_monopatin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Informe f1 = new Informe(monopatines, clientes);

            this.Hide();

            f1.Show();
        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {

            Monopatin monopatin_seleccionado = (Monopatin) lb_monopatin.SelectedItem;
            Cliente cliente_selecionado = (Cliente)lb_cliente.SelectedItem;

            if (cliente_selecionado.CompruebaAlquiler(monopatin_seleccionado))
            {

                cliente_selecionado.listaMonopatines.Add(monopatin_seleccionado);
                lb_monopatin.Items.Remove(monopatin_seleccionado);


            }
            

        }
    }
}


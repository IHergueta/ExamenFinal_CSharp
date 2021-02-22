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
    public partial class Form2 : Form
    {


        public List<Monopatin> monopatines;
        public List<Cliente> clientes;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Monopatin> monopatines, List<Cliente> clientes)
        {
            InitializeComponent();
            this.monopatines = monopatines;
            this.clientes = clientes;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            foreach(Cliente c in clientes)
            {

                cb_clientes.Items.Add(c);

            }
        }

        private void cb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            lb_monopatines.Items.Clear();

            Cliente cliente_selecionado = (Cliente)cb_clientes.SelectedItem;
            List<IMonopatin> monopatines_cliente = cliente_selecionado.listaMonopatines;

            foreach(Monopatin m in monopatines_cliente)
            {

                lb_monopatines.Items.Add(m);

            }
        }

        private void lb_monopatines_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_volver_Click(object sender, EventArgs e)
        {

            Cliente cliente_selecionado = (Cliente)cb_clientes.SelectedItem;
            Monopatin monopatin_selecionado = (Monopatin)lb_monopatines.SelectedItem;

            foreach(Cliente c in clientes)
            {

                if (c == cliente_selecionado)
                {
                    cliente_selecionado.listaMonopatines.Remove(monopatin_selecionado);
                    monopatines.Add(monopatin_selecionado);
                }
            }

            Form1 f1 = new Form1(monopatines, clientes);

            this.Hide();

            f1.Show();
        }
    }
}

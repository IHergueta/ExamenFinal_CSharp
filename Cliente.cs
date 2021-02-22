using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Cliente : ICliente
    {

        public String nombre { set; get; }
        public String apellido { set; get; }
        public String dni { set; get; }
        public int peso { set; get; }
        public int saldo { set; get; }
        public List<IMonopatin> listaMonopatines { set; get; }

        public Cliente(string nombre, string apellido, string dni, int peso, int saldo, List<IMonopatin> listaMonopatines)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.peso = peso;
            this.saldo = saldo;
            this.listaMonopatines = listaMonopatines;
        }

        public Cliente()
        {


        }

        public override string ToString()
        {
            return this.dni + " - " + this.nombre + " - " + this.peso + " - " + this.saldo;
        }

        public Boolean CompruebaAlquiler(IMonopatin monopatin)
        {
            if (peso > monopatin.pesaMaximo && saldo > monopatin.valor && monopatin.CompruebaEstado())
            {

                return true;
            }
            else
            {

                return false;

            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Monopatin : IMonopatin
    {

        public int id { set; get; }
        public String marca { set; get; }
        public int pesaMaximo { set; get; }
        public int valor { set; get; }
        public int vecesAlquilado { set; get; }


        public Monopatin(int id, string marca, int pesaMaximo, int valor, int vecesAlquilado)
        {
            this.id = id;
            this.marca = marca;
            this.pesaMaximo = pesaMaximo;
            this.valor = valor;
            this.vecesAlquilado = vecesAlquilado;
        }

        public Monopatin()
        {

        }

        public void setValor(int valor)
        {

            this.valor = valor;

        }

        public int getValor()
        {

            return this.valor;
        }

        public override string ToString()
        {
            return this.id + " - " + this.marca + " - " + this.pesaMaximo + " - " + this.valor;
        }

        public Boolean CompruebaEstado()
        {

            if (vecesAlquilado > 20)
            {

                return false;

            }
            else
            {

                return true;

            }

        }

    }
}

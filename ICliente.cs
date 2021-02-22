using System.Collections.Generic;

namespace ExamenFinal
{
    public interface ICliente
    {
        string apellido { get; set; }
        string dni { get; set; }
        List<IMonopatin> listaMonopatines { get; set; }
        string nombre { get; set; }
        int peso { get; set; }
        int saldo { get; set; }

        bool CompruebaAlquiler(IMonopatin monopatin);
        string ToString();
    }
}
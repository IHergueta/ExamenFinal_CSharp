namespace ExamenFinal
{
    public interface IMonopatin
    {
        int id { get; set; }
        string marca { get; set; }
        int pesaMaximo { get; set; }
        int valor { get; set; }
        int vecesAlquilado { get; set; }

        bool CompruebaEstado();
        int getValor();
        void setValor(int valor);
        string ToString();
    }
}
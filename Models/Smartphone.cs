namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        // TODO: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string Imei, int Memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = Imei;
            Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
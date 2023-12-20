namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero) : base(numero)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // Sobrescrever o método InstalarAplicativo da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma iOS");
        }
    }
}
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero) : base(numero)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // Sobrescrever o método InstalarAplicativo da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma Symbian");
        }
    }
}
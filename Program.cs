using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Testando a classe Iphone
        Iphone iphone = new Iphone("123456789", "iPhone 12", "Apple", 2022);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        // Testando a classe Nokia
        Nokia nokia = new Nokia("987654321", "Nokia 3310", "Nokia", 2000);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");

        Console.ReadLine();
    }
}
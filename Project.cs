using System;

// Classe abstrata Smartphone
abstract class Smartphone
{
    // Propriedades
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected int Memoria { get; set; }

    // Métodos abstratos
    public abstract void InstalarAplicativo(string nome);

    // Métodos concretos
    public void Ligar()
    {
        Console.WriteLine("Ligando o smartphone...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo uma ligação...");
    }
}

// Classe concreta Nokia, que herda de Smartphone
class Nokia : Smartphone
{
    // Implementação do método abstrato
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Nokia.");
    }
}

// Classe concreta iPhone, que herda de Smartphone
class Iphone : Smartphone
{
    // Implementação do método abstrato
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no iPhone.");
    }
}

class Program
{
    static void Main()
    {
        // TODO: Teste das classes
        Nokia nokia = new Nokia();
        nokia.Numero = "123456789";
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone();
        iphone.Numero = "987654321";
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}










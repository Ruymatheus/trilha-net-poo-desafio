using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Smartphone dispositivo = null;
        bool marcavalida = false;

        do
        {
            Console.WriteLine("Indique a marca do aparelho (nokia/iphone):");
            string marca = Console.ReadLine().ToLower();

            switch (marca)
            {
                case "nokia":
                    dispositivo = new Nokia("0", "0", "0", 0);
                    marcavalida = true;
                    break;
                case "iphone":
                    dispositivo = new Iphone("0", "0", "0", 0);
                    marcavalida = true;
                    break;
                default:
                    Console.WriteLine("Marca inválida.");
                    break;
            }
        } while (!marcavalida);

        Console.WriteLine("Forneça as informações do dispositivo:\n Modelo \n IMEI \n Memória \n Numero");
        string modelo = Console.ReadLine();
        string imei = Console.ReadLine();
        int memoria = int.Parse(Console.ReadLine());
        string numero = Console.ReadLine();
        dispositivo.Modelo = modelo;
        dispositivo.IMEI = imei;
        dispositivo.Memoria = memoria;
        dispositivo.Numero=numero;
        

        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1. Ligar");
        Console.WriteLine("2. Receber ligação");
        Console.WriteLine("3. Instalar aplicativo");
        Console.WriteLine("4. Imprimir informações");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                dispositivo.Ligar();
                break;
            case 2:
                dispositivo.ReceberLigacao();
                break;
            case 3:
                dispositivo.InstalarAplicativo("WhatsApp");
                break;
            case 4:
                dispositivo.ImprimirInformacoes();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}

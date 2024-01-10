namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Construtor que chama o construtor da classe base
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implementação específica para instalar aplicativos em um iPhone
        }
    }
}

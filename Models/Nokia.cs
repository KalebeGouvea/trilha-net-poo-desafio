namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescrito o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {   
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
        }
    }
}
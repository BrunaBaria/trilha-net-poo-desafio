namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //Implementado
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; }
        public string Modelo { get; }
        public string Imei { get; }
        public int Memoria { get; }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp}");
        }
    }
}
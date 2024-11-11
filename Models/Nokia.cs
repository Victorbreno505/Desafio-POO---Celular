namespace DesafioPOO.Models
{
    //Herdando a Classe Smartphone
    public class Nokia : Smartphone
    {
        //Construtor
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {}
    //Sobrescrevendo o método.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia.");
        }
    }
}
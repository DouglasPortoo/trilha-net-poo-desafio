namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private  string Imei;
        private string Modelo;
        private int Memoria;

        public string Numero {get;set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Imei=imei;
            Modelo= modelo;
            Memoria = memoria;
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
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string numero;

        public string GetNumero()
        {
            return numero;
        }

        public void SetNumero(string value)
        {
            numero = value;
        }

        private string modelo;

        private string GetModelo()
        {
            return modelo;
        }

        private void SetModelo(string value)
        {
            modelo = value;
        }

        private string imei;

        private string GetImei()
        {
            return imei;
        }

        private void SetImei(string value)
        {
            imei = value;
        }

        private int memoria;

        private int GetMemoria()
        {
            return memoria;
        }

        private void SetMemoria(int value)
        {
            memoria = value;
        }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            SetNumero(numero);
            SetModelo(modelo);
            SetImei(imei);
            SetMemoria(memoria);
            // TODO: Passar os parâmetros do construtor para as propriedades
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
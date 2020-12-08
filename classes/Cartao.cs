namespace Encapsulamento.classes
{
    public class cartao
    {

        private string numero;

        public string Numero{
            get{return numero;}
            set{numero = value;}
        }

        private string nomeTitular;

        private string bandeira;

        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        
        protected string token = "quertyui";

        private string cvv;

        protected float limite = 5000;

        public string RegistrarCompra(bool validado){
            return "";
        }

        public string ReceberNome(string nomeDigitado){
           return this.nomeTitular = nomeDigitado; 
        }

        public void exibirNome(){
            System.Console.WriteLine(this.nomeTitular);
        }

    }
}
namespace ExercicioCelular
{
    public class celular
    {
        public string cor;
        
        public string modelo;

        public float tamanho;

        public bool ligado = true;


        public bool Ligar(){
            return ligado = true;
        }

        public bool Desligar(){
            return ligado = false;
        }

        public string Chamando(){
            return "Ligando...";
        }
         public string Caiu(){
            return "Caixa Postal :(";
        }

         public string Mensagem(){
            return "Mensagem enviada!";
        }
    }
}
namespace Jogador
{
    public class JogadorAtaque : Jogador
    {
        public int IdadeAtaque(){
            return AnoAtual - dataNascimento;
        }
    }
}
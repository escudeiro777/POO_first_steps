namespace Jogador
{
    public class JogadorDefesa : Jogador
    {
        public int IdadeDefesa(){
            return AnoAtual - dataNascimento;
        }
    }
}
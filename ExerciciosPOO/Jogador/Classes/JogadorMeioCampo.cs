namespace Jogador
{
    public class JogadorMeioCampo : Jogador
    {
        public int IdadeMeioCampo(){
            return AnoAtual - dataNascimento;
        }
    }

}
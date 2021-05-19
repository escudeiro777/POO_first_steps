namespace AulaPersonagem
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;

        public int pontosVida;

        public int Atacar()
        {
            int dano = 10;
            return dano;
        }

        public int Defender()
        {
            int defesa = 2;
            return defesa;
        }

        public int CampoProtetor()
        {
            int defesa = 3;
            return defesa;
        }
    }
}
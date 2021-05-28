namespace Cafeteira.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;

        public string FazerCafe()
        {
            if (acucarDisponivel >= 10)
            {
                acucarDisponivel = acucarDisponivel - 10;
                return $"Café padrão feito! Aproveite!\n{acucarDisponivel}g de açúcar restante";
            }
            else
            {
                return $"A máquina só possui {acucarDisponivel}g de açúcar no momento. Tente outra quantidade ou informe um de nossos funcionários.";
            }
        }

        public string FazerCafe(int usuarioAcucar)
        {
            if (usuarioAcucar < acucarDisponivel)
            {
                acucarDisponivel = acucarDisponivel - usuarioAcucar;
                return $"Café personalizado feito! Aproveite!\n{acucarDisponivel}g de açúcar restante";
            }
            else
            {
                return $"A máquina só possui {acucarDisponivel}g de açúcar no momento. Tente outra quantidade ou informe um de nossos funcionários.";
            }
        }

        public string FazerCafePuro()
        {
            return "Café sem açúcar feito! Aproveite!";
        }
    }
}
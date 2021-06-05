namespace ClassesEstaticas.Classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.23f;

        public static float RealDolar(float valorRS)
        {
            return valorRS / cotacaoDolar;
        }

        public static float DolarReal(float valorUSD)
        {
            return valorUSD * cotacaoDolar;
        }
    }
}
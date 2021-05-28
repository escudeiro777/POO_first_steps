using System;
namespace Elevador
{
    public class ElevadorServico : Elevador
    {
        private int caixas;
        private int capacidadeCaixas = 6;

                public void ColocarCaixa()
        {
            if (caixas < capacidadeCaixas)
            {
                caixas = caixas + 1;
                Console.WriteLine("Colocaram mais uma caixa no elevador");
            }
            else
            {
                Console.WriteLine($"O elevador está lotado! {caixas} presentes!");
            }

        }
        public void TirarCaixa()
        {
            if (caixas > 0)
            {
                caixas = caixas - 1;
                Console.WriteLine("Uma caixa foi retirada do elevador");
            } else
            {
                 Console.WriteLine("O elevador está vazio.");
            }
        }
    }
}
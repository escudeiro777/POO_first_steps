using System;

namespace ConceitosNaPratica.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000f;

        public void Pagar()
        {
            float valor = this.valor;
            int vezes;

            if (valor > limite)
            {
                Console.WriteLine("O preço excedeu o limite do seu cartão");
            }
            else
            {
                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor de{valor:C2}? (Até 12x)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes} vezes, logo terá um juros de 5%.");
                        Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vezes de {(valor * 1.05) / vezes:C2}");
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes} vezes, logo terá um juros de 8%.");
                        Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} vezes de {(valor * 1.08) / vezes:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Só se pode parcelar até 12x");
                    }
                } while (vezes < 1 || vezes > 12);


            }
        }
    }
}
using System;
using ClassesEstaticas.Classes;

namespace ClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de moeda");

            Console.Write("Digite o valor em reais:");
            float valorEmReais = float.Parse(Console.ReadLine());

            Console.Write("Valor em U$: ");
            Console.WriteLine(Conversor.RealDolar(valorEmReais));
        }
    }
}

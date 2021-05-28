using System;
namespace Elevador
{
    public abstract class Elevador
    {
        private int andarAtual;
        private int totalAndar;
        private int capacidade;
        private int pessoasPresentes;

        public void Iniciar(int capacidadeElevador, int andarPredio)
        {
            andarAtual = 0;
            pessoasPresentes = 0;
            capacidade = capacidadeElevador;
            totalAndar = andarPredio;
        }
        
        public void Entrar()
        {
            if (pessoasPresentes < capacidade)
            {
                pessoasPresentes = pessoasPresentes + 1;
                Console.WriteLine("Mais uma pessoa entrou no elevador.");
            }
            else 
            {
                Console.WriteLine($"O elevador está lotado! {pessoasPresentes} pessoas presentes");
            }

        }
        public void Sair()
        {
            if (pessoasPresentes > 0)
            {
                pessoasPresentes = pessoasPresentes - 1;
                Console.WriteLine("Uma pessoa saiu do elevador.");
            } else
            {
                 Console.WriteLine("O elevador está vazio.");
            }
        }
        public void Subir()
        {
            if (andarAtual < totalAndar)
            {
                andarAtual = andarAtual + 1;
                Console.WriteLine("O elevador subiu um andar.");
            } else
            {
                Console.WriteLine("O elevador já se encontra no último andar, impossível subir.");
            }
        }

        public void Subir(int andarDesejado){
            if (andarDesejado > 0 && andarDesejado <= totalAndar)
            {
                andarAtual=andarDesejado;
                Console.WriteLine($"Indo para o {andarDesejado}º andar");
            }
        }
        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual = andarAtual - 1;
                Console.WriteLine("O elevador desceu um andar");
            } else
            {
                  Console.WriteLine("O elevador já se encontra no térreo, impossível descer.");
            }
        }
    }
}
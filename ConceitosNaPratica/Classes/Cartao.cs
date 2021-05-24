using System;

namespace ConceitosNaPratica.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a Bandeira do Cartão:");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o número do Cartão:");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do Cartão:");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do Cartão:");
            cvv = Console.ReadLine();

            return $"Cartão de número {Numero} salvo com sucesso!";
        }
    }
}
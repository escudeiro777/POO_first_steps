using MetodosConstrutores.Classes;
using System;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplos de métodos construtores:");

            Produtos p = new Produtos();
            Console.WriteLine($"Primeiro Produto(Construtor sem argumentos)");
            Console.WriteLine($"Código {p.Codigo}\nNome:{p.Nome}\nDescrição: {p.Descricao}\nEstoque: {p.Estoque}");
            
            Produtos p2 = new Produtos(456);
            Console.WriteLine($"Segundo Produto(Construtor com um argumento)");
            Console.WriteLine($"Código {p2.Codigo}\nNome:{p2.Nome}\nDescrição: {p2.Descricao}\nEstoque: {p2.Estoque}");

            Produtos p3 = new Produtos(152, "Maçã", "Maçã bonita",3);
            Console.WriteLine($"Terceiro Produto(Construtor com um argumento)");
            Console.WriteLine($"Código {p3.Codigo}\nNome:{p3.Nome}\nDescrição: {p3.Descricao}\nEstoque: {p3.Estoque}");
        }
    }
}

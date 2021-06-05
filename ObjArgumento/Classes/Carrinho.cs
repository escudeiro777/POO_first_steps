using System.Collections.Generic;
using System;
namespace ObjArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostrarPorduto()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{p.Preco:C2} - {p.Nome} ");
                    Console.ResetColor();
                }
            }
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"O total a pagar é:{ValorTotal:C2}");
            }
            else
            {
                Console.WriteLine("Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }
        public void AlterarItem(int _codigo, Produto novoProduto){
            carrinho.Find(cadaItem => cadaItem.Codigo == _codigo).Nome = novoProduto.Nome;
            carrinho.Find(cadaItem => cadaItem.Codigo == _codigo).Preco = novoProduto.Preco;
        }
    }
}
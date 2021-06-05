using System;
using System.Collections.Generic;
using Listas.Classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "Apple Watch", 3522.50f));
            produtos.Add(new Produto(1, "Xiaomi Watch", 1522.50f));
            produtos.Add(new Produto(1, "Zenfone ASUS", 2522.50f));
            produtos.Add(new Produto(1, "Samsung Galaxy S20", 4522.50f));
            produtos.Add(new Produto(1, "Motorola 68", 822.50f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone 12";
            iphone.Preco = 156156f;

            produtos.Add(iphone);

            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }

            produtos.RemoveAt(5);
            produtos.RemoveAll(item => item.Nome == "Apple Watch");

            Produto atualizar = produtos.Find(item => item.Codigo == 4);
            atualizar.Preco = 1247.00f;

            produtos.RemoveAll(item => item.Codigo == 4);
            produtos.Insert(3, atualizar);
        }
    }
}
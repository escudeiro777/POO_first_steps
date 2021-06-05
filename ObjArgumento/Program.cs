using System;
using ObjArgumento.Classes;
using System.Collections.Generic;
namespace ObjArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Xbox Series S", 1499f);
            Produto p2 = new Produto(2, "Xbox Series", 1399f);
            Produto p3 = new Produto(3, "Nintendo Switch", 1299f);
            Produto p4 = new Produto(4, "Playstation 5", 2499f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarPorduto();
        }
    }
}

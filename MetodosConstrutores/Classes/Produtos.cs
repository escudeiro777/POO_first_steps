namespace MetodosConstrutores.Classes
{
    public class Produtos
    {
        public Produtos(){

        }

        public Produtos(int codigoDoProduto){
            Codigo = codigoDoProduto;
        }

        public Produtos (int codigoDoProduto, string nomeProduto, string descricaoProduto, int nmrEstoque){
            Codigo = codigoDoProduto;
            Nome = nomeProduto;
            Descricao = descricaoProduto;
            Estoque = nmrEstoque;
        }

        public int Codigo {get; set;}
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        
        
    }
}
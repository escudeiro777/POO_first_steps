using System;


namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
|=====================================================|
|         Em qual posição você deseja jogar?          |
|=====================================================|
|                                                     |
|-> Atacante [A]                                      |
|-> Meio de campo [B]                                 |
|-> Defesa [D]                                        |
|=====================================================|

            ");
            string resposta = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual o nome do jogador?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o ano de nascimento do jogador?");
            int dataNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nacionalidade do jogador?");
            string nacionalidade = Console.ReadLine();
            Console.WriteLine("Qual o peso do jogador?");
            string peso = Console.ReadLine();
            Console.WriteLine("Qual a altura do jogador");
            string altura = Console.ReadLine();

            switch (resposta)
            {
                case "A":
                    JogadorAtaque ja = new JogadorAtaque();

                    ja.nome = nome;

                    ja.dataNascimento = dataNascimento;

                    ja.nacionalidade = nacionalidade;

                    ja.peso = peso;

                    ja.altura = altura;

                    int idadeAtacante = ja.IdadeAtaque();

                    if (idadeAtacante <= 35)
                    {
                        Console.WriteLine("Você ainda não pode se aposentar");
                    } else
                    {
                         Console.WriteLine("Você já pode se aposentar");
                    }
                    Console.WriteLine(ja.ImprimirDados());
                    break;

                case "B":
                    JogadorMeioCampo jmc = new JogadorMeioCampo();

                    jmc.nome = nome;

                    jmc.dataNascimento = dataNascimento;

                    jmc.nacionalidade = nacionalidade;

                    jmc.peso = peso;

                    jmc.altura = altura;

                    int IdadeMeioCampo= jmc.IdadeMeioCampo();
                     if (IdadeMeioCampo <= 38)
                    {
                        Console.WriteLine("Você ainda não pode se aposentar");
                    } else
                    {
                         Console.WriteLine("Você já pode se aposentar");
                    }
                    Console.WriteLine(jmc.ImprimirDados());
                    break;

                case "D":
                    JogadorDefesa jd = new JogadorDefesa();

                    jd.nome = nome;

                    jd.dataNascimento = dataNascimento;

                    jd.nacionalidade = nacionalidade;

                    jd.peso = peso;

                    jd.altura = altura; 

                    int idadeDefesa= jd.IdadeDefesa();
                     if (idadeDefesa <= 40)
                    {
                        Console.WriteLine("Você ainda não pode se aposentar");
                    } else
                    {
                         Console.WriteLine("Você já pode se aposentar");
                    }
                    Console.WriteLine(jd.ImprimirDados());
                    break;

                    default:
                    break;
            }
        }
    }
}

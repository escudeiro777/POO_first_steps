using System;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Elevador");
            ElevadorSocial es = new ElevadorSocial();
            ElevadorServico eserv = new ElevadorServico();
            string resposta;
            bool sairSistema = false;
            //---------------------------------------------------------------------------------------------//
            do
            {
                Console.WriteLine("Qual elevador você deseja utilizar?\n[1] Social\n[2] Serviço");
                string respostaElevador = Console.ReadLine();
                if (respostaElevador == "1")
                {
                    es.Iniciar(4, 5);
                    do
                    {
                        Console.WriteLine("O que você deseja executar?\n-> [1] Entrar\n-> [2] Sair\n-> [3] Subir\n-> [4] Descer\n-> [5]Sair do sistema");
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1":
                                es.Entrar();
                                break;
                            case "2":
                                es.Sair();
                                break;
                            case "3":
                                Console.WriteLine("Deseja escolher o andar de destino? (S/N)");
                                string respostaAndar = Console.ReadLine().ToUpper();

                                if (respostaAndar == "S")
                                {
                                    Console.WriteLine("Para qual andar você deseja ir?");
                                    int andarDesejado = int.Parse(Console.ReadLine());
                                    es.Subir(andarDesejado);
                                }
                                else
                                {
                                    es.Subir();
                                }

                                break;
                            case "4":
                                es.Descer();
                                break;
                            case "5":
                                Console.WriteLine("Deseja mesmo sair? Se sim, pressione X");
                                break;
                            default:
                                Console.WriteLine("Opção Inválida");
                                break;
                        }
                    } while (resposta != "5");

                }
                else if (respostaElevador == "2")
                {
                    eserv.Iniciar(4, 5);
                    do
                    {
                        Console.WriteLine("O que você deseja executar?\n-> [1] Entrar\n-> [2] Sair\n-> [3] Subir\n-> [4] Descer\n-> [5] Adicionar uma caixa\n-> [6] Tirar uma caixa\n-> [7] Sair do sistema");
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1":
                                eserv.Entrar();
                                break;
                            case "2":
                                eserv.Sair();
                                break;
                            case "3":
                                Console.WriteLine("Deseja escolher o andar de destino? (S/N)");
                                string respostaAndar = Console.ReadLine().ToUpper();

                                if (respostaAndar == "S")
                                {
                                    Console.WriteLine("Para qual andar você deseja ir?");
                                    int andarDesejado = int.Parse(Console.ReadLine());
                                    eserv.Subir(andarDesejado);
                                }
                                else
                                {
                                    eserv.Subir();
                                }

                                break;
                            case "4":
                                eserv.Descer();
                                break;
                            case "5":
                                eserv.ColocarCaixa();
                                break;
                            case "6":
                                eserv.TirarCaixa();
                                break;
                            case "7":
                                Console.WriteLine("Deseja mesmo sair? Se sim, pressione X");
                                break;
                            default:
                                Console.WriteLine("Opção Inválida");
                                break;
                        }
                    } while (resposta != "7");
                }
                string sair = Console.ReadLine().ToUpper();
                if (sair == "X")
                {
                    Console.WriteLine("Obrigado por utilizar nosso sistema!");
                    sairSistema = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            } while (!sairSistema);
        }
    }
}

using System;
using Cafeteira.Classes;

namespace Cafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe mc = new MaquinaCafe();
            bool sairSistema = false;

            do
            {
                Console.WriteLine($@"
|===================================================|
|         Super CafeteiraTabajaras Plus++           |
|===================================================|
|           Qual opção mais te atrai?               |
|---------------------------------------------------|
|                                                   |
|  -> [1] Café padrão (10g de açúcar)               |
|  -> [2] Café personalizado (Com ou sem açúcar)    | 
|  -> [3] Sair do sistema                           |
|                                                   |
|===================================================|

   -> A máquina possui {mc.acucarDisponivel}g de açúcar.");
                string respostaUsuario = Console.ReadLine();

                switch (respostaUsuario)
                {
                    case "1":
                        Console.WriteLine(mc.FazerCafe());
                        break;
                    case "2":
                        Console.WriteLine(@"
|================================================|
|         Super CafeteiraTabajaras Plus++        |
|================================================|
|               O que você deseja?               |
|------------------------------------------------|
|                                                |
|  -> [C] Café com açúcar                        |
|  -> [S] Café sem açúcar                        |
|                                                |
|================================================|");
                        string respostaAcucar = Console.ReadLine().ToUpper();
                        switch (respostaAcucar)
                        {
                            case "C":
                                Console.WriteLine($"Quanto açúcar você gostaria de adicionar?");
                                int usuarioAcucar = int.Parse(Console.ReadLine());
                                Console.WriteLine(mc.FazerCafe(usuarioAcucar));
                                break;
                            case "S":
                            Console.WriteLine(mc.FazerCafePuro());
                                break;

                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Obrigado por utilizar a Super CafeteiraTabajaras Plus++!\nAté o próximo café :)");
                        sairSistema = true;
                        break;
                    default:
                        break;
                }
            } while (!sairSistema);
        }
    }
}

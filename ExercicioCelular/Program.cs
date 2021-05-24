using System;
namespace ExercicioCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular1 = new celular();
            Console.WriteLine("Qual o cor do seu celular?");
            celular1.cor = Console.ReadLine();
            Console.WriteLine("Qual o modelo do seu celular?");
            celular1.modelo = Console.ReadLine();
            Console.WriteLine("Quantas polegadas tem seu celular?");
            celular1.tamanho = float.Parse(Console.ReadLine());

            Console.WriteLine("Deseja ligar o celular? (S/N)");
            string respostaUser = Console.ReadLine().ToUpper();

            if (respostaUser == "S")
            {
                celular1.Ligar();
            }
            else if (respostaUser == "N")
            {
                Console.WriteLine("Impossível de utilizar as funções do celular com ele desligado");
            }


            if (celular1.Ligar())
            {
                do
                {
                    Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |      O que você deseja fazer?     |
        |                                   |
        |   -> 1- Fazer uma ligação         |
        |   -> 2- Enviar mensagem           |
        |   -> 3- Ver especificações        |
        |   -> 4- Desligar                  |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (    █         (  )         ↩    )
          ---------------------------------
        ");
                    string respostaCelular = Console.ReadLine();
                    switch (respostaCelular)
                    {
                        case "1":
                            Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |         Fazer uma ligação         |
        |                                   |
        |    Para quem você deseja ligar?   |
        |                                   |
        |   1 -> Odirlei                    |
        |   2 -> Thiago                     |
        |   3 -> Bolsonaro                  |
        |   4 -> Dilma                      |
        |   5 -> Lula                       |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                            string respostaCall = Console.ReadLine();
                            switch (respostaCall)
                            {
                                case "1":
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |       Ligando para: Odirlei       |
        |                                   |
        |       {celular1.Chamando()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |        Chamada não atendida       |
        |                                   |
        |       {celular1.Caiu()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "2":
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |       Ligando para: Thiago        |
        |                                   |
        |       {celular1.Chamando()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |        Chamada não atendida       |
        |                                   |
        |       {celular1.Caiu()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "3":
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |       Ligando para: Bolsonaro     |
        |                                   |
        |       {celular1.Chamando()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |        Chamada não atendida       |
        |                                   |
        |       {celular1.Caiu()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "4":
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |       Ligando para: Dilma         |
        |                                   |
        |       {celular1.Chamando()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |        Chamada não atendida       |
        |                                   |
        |       {celular1.Caiu()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "5":
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |       Ligando para: Lula          |
        |                                   |
        |       {celular1.Chamando()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |                                   |
        |                                   |
        |        Chamada não atendida       |
        |                                   |
        |       {celular1.Caiu()}           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                default:
                                    break;
                            }

                            break;
                        case "2":
                            Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |        Mandar uma mensagem        |
        |                                   |
        |       Para quem você deseja       |
        |         mandar mensagem?          |
        |                                   |
        |   1 -> Odirlei                    |
        |   2 -> Thiago                     |
        |   3 -> Bolsonaro                  |
        |   4 -> Dilma                      |
        |   5 -> Lula                       |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                            string respostaMensagem = Console.ReadLine();
                            switch (respostaMensagem)
                            {
                                case "1":
                                    Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Odirlei        |
        |                                   |
        |  - Boua tarrrrdeeee!              |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine("Digite sua mensagem:");
                                    string mensagem = Console.ReadLine();

                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Odirlei        |
        |                                   |
        |  - Boua tarrrrdeeee!              |
        |                                   |
        |                      {mensagem} - |
        |                                   |
        |                                   |
        |            {celular1.Mensagem()}      |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");

                                    break;
                                case "2":
                                    Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Thiago         |
        |                                   |
        |  - Simples assim...               |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine("Digite sua mensagem:");
                                    string mensagem1 = Console.ReadLine();

                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Thiago         |
        |                                   |
        |  - Simples assim...               |
        |                                   |
        |                     {mensagem1} - |
        |                                   |
        |                                   |
        |            {celular1.Mensagem()}      |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "3":
                                    Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |          Chat com Bolsonaro       |
        |                                   |
        |  - Recusei 11 vezes a vacina      |
        |    e ainda sou #MITO              |
        |  - Só toma cuidado com a CPI      |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine("Digite sua mensagem:");
                                    string mensagem2 = Console.ReadLine();

                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |         Chat com Bolsonaro        |
        |                                   |
        |  - Recusei 11 vezes a vacina      |
        |    e ainda sou #MITO              |
        |  - Só toma cuidado com a CPI      |
        |                                   |
        |                      {mensagem2} -|
        |                                   |
        |            {celular1.Mensagem()}      |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "5":
                                    Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Lula           |
        |                                   |
        |  - Slc, a Dilma estocou vento     |
        |  - Mt loco, companheiro           |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine("Digite sua mensagem:");
                                    string mensagem3 = Console.ReadLine();

                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Lula           |
        |                                   |
        |  - Slc, a Dilma estocou vento     |
        |  - Mt loco, companheiro           |
        |                                   |
        |                                   |
        |                      {mensagem3} -|
        |                                   |
        |            {celular1.Mensagem()}      |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                case "4":
                                    Console.WriteLine(@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Dilma          |
        |                                   |
        |  - kkkkkkkkkkk logo me zuaram mas |
        |    consegui estocar o vento kkkkk |
        |    bando de troxa                 |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    Console.WriteLine("Digite sua mensagem:");
                                    string mensagem4 = Console.ReadLine();

                                    Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |           Chat com Dilma          |
        |                                   |
        |  - kkkkkkkkkkk logo me zuaram mas |
        |    consegui estocar o vento kkkkk |
        |    bando de troxa                 |
        |                                   |
        |                      {mensagem4} -|
        |                                   |
        |            {celular1.Mensagem()}      |
        | --------------------------------- |
        |Digite sua mensagem:               |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine($@" 
            
            ------------------------------
         (                                 )   
        (           @ --------              ) 
        |-----------------------------------|   
        |                                   |
        |      Configurações do Aparelho    |
        |                                   |
        |     Modelo: {celular1.modelo}     
        |                                   |
        |     Cor: {celular1.cor}           
        |                                   |
        |     Polegadas: {celular1.tamanho} 
        |                                   |
        |                                   |
        |                                   |
        |                                   |
        |-----------------------------------|
        (                                   )
         (     █        (  )       ↩      )
          ---------------------------------
        ");
                            break;
                        case "4":
                            Console.WriteLine("Até a próxima!");
                            celular1.Desligar();
                            break;
                        default:
                            break;
                    }

                } while (celular1.ligado);
            }
        }
    }
}
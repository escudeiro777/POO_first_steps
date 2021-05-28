using System;
namespace Sobrescrita.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine("MegaMan: ");
            Console.WriteLine(m.Correr());
            Console.WriteLine(m.Pular());

            Console.WriteLine("Zero: ");
            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());

        }

    }
}

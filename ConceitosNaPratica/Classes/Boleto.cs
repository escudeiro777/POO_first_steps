using System;

namespace ConceitosNaPratica.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarra;

        Random r = new Random();

        public void Registrar(){
            codigoDeBarra = r.Next(300000).ToString();
            Console.WriteLine($"Boleto gerado com o código {codigoDeBarra}");
            Console.WriteLine($"Boleto registrado com desconto, o valor atual a pagar é: {this.valor * 0.88:C2}");
        }
    }
}
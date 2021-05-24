using System;
namespace ConceitosNaPratica.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 600f;

        public void Pagar(){
            float valor = this.valor;

            if (valor > saldo)
            {
                Console.WriteLine("Você excedeu o saldo do cartão. Impossível realizar compra.");
            }else{
                Console.WriteLine($"O valor de {valor:C2} pago com sucesso");
            }
        }
    }
}
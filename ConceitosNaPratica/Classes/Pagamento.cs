using System;

namespace ConceitosNaPratica.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;
        protected float valor = 2599f;

        public string Cancelar(){
            return "Pagamento Cancelado";
        }
    }
}
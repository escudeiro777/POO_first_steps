using System;
namespace Jogador
{
    public class Jogador
    {
        public string nome;
        public int dataNascimento;
        public string nacionalidade;
        public string altura;
        public string peso;

        public int AnoAtual;

        
        public string ImprimirDados(){
            AnoAtual = DateTime.Now.Year;
            
            return @$"
O ano atual é: {AnoAtual};
O nome do jogador é: {nome}
A data de nascimento do jogador é: {dataNascimento}
A nacionalidade do jogador: {nacionalidade}
A altura do jogador é: {altura}
O peso do jogador é: {peso}
            
            
            ";
        }
    }
}
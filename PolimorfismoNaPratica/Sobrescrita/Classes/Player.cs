using System;
namespace Sobrescrita.Classes
{
    public class Player
    {
    private float Velocidade;

    private float ForcaPulo;

    public virtual string Correr (){
        return "O player correu!";
    }

    public virtual string Pular(){
        return "O player pulou!";
    }

    }
}
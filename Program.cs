using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem batman = new Personagem ();
            batman.armadura = "Hellbat";

            Console.WriteLine(batman.nome);

            Console.WriteLine("Usando a armadura "+batman.armadura);

            Console.WriteLine("Ataca causando um dano de "+batman.Atacar(10 , 2));
        }
    }
}

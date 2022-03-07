using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Factoty Method ------");

            Factory factory = new Factory();
 
            Console.WriteLine("liu kang| subzero| scorpion");
            Console.WriteLine("Escolha seu Personagem!!");

            string personagemEscolhido = Console.ReadLine();

            IPersonagem personagem = factory.EscolherPersonagem(personagemEscolhido);

            Console.WriteLine();
            Console.WriteLine("O Jogo comecará com ");
            personagem.Escolhido();

            Console.ReadKey();

        }
    }
}

using System;

namespace FactoryMethod.Personagens
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Scorpion Here!");
        }
    }
}

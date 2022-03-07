using System;

namespace FactoryMethod.Personagens
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Liu Kang Here!");
        }
    }
}

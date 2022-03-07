using System;

namespace FactoryMethod.Personagens
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("SubZero Here!");
        }
    }
}

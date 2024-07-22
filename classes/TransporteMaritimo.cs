using FactoryMethod.@interface;

namespace FactoryMethod.classes
{
    public class TransporteMaritimo : ITransporte
    {
        public void Transportar()
        {
            Console.WriteLine("O transporte será realizado pela água.");
        }
    }
}

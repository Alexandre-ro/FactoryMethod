using FactoryMethod.@interface;

namespace FactoryMethod.classes
{
    public class TransporteAereo : ITransporte
    {
        public void Transportar()
        {
            Console.WriteLine("O Transporte será realizado pelo ar.");
        }
    }
}

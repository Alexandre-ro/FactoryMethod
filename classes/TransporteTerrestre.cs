using FactoryMethod.@interface;

namespace FactoryMethod.classes
{
    public class TransporteTerrestre : ITransporte
    {
        public void Transportar()
        {
            Console.WriteLine("O Transporte será realizado pela terra.");
        }
    }
}

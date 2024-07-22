using FactoryMethod.classes;
using FactoryMethod.@interface;

namespace FactoryMethod
{
    public class FactoryTransport
    {
        //Instância a classe de acordo o parâmetro recebido
        public ITransporte CreateTransporte(string transporte)
        {
            switch (transporte)
            {
                case "terra": return new TransporteTerrestre();
                case "agua": return new TransporteMaritimo();
                case "ar": return new TransporteAereo();

                default: return new TransporteTerrestre();
            }
        }
    }
}

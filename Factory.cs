using FactoryMethod.Personagens;

namespace FactoryMethod
{
    public class Factory
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "liukang": return new LiuKang();
                case "subzero": return new SubZero();
                case "scorpion": return new Scorpion();

                default: return null;
            }

        }
    }
}

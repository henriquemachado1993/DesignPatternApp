using FactoryMethodLib.Enums;
using FactoryMethodLib.Interfaces;
using FactoryMethodLib.Personagens;

namespace FactoryMethodLib
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(Personagem personagem)
        {
            switch (personagem)
            {
                case Personagem.Wraith:
                    return new Wraith();
                case Personagem.Bangalore:
                    return new Bangalore();
                case Personagem.PathFinder:
                    return new PathFinder();
                default:
                    return null;
            }
        }
    }
}

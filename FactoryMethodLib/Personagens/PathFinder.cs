using FactoryMethodLib.Interfaces;
using System;

namespace FactoryMethodLib.Personagens
{
    public class PathFinder : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("PathFinder");
        }
    }
}

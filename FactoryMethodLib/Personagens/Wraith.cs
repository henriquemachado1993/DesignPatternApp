using FactoryMethodLib.Interfaces;
using System;

namespace FactoryMethodLib.Personagens
{
    public class Wraith : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Wraith");
        }
    }
}

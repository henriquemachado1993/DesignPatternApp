using FactoryMethodLib.Interfaces;
using System;

namespace FactoryMethodLib.Personagens
{
    public class Bangalore : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Bangalore");
        }
    }
}

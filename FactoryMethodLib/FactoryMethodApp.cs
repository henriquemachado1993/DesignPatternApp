using FactoryMethodLib.Enums;
using FactoryMethodLib.Interfaces;
using FactoryMethodLib.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethodLib
{
    public static class FactoryMethodApp
    {
        public static void Executar()
        {
            Console.WriteLine();
            Console.WriteLine("-------- Pattern Factory Method --------");
            Console.WriteLine();
            Console.WriteLine("Exemplo: Jogo Apex Legends");
            Console.WriteLine("");
            Console.WriteLine("Lendas: Wraith | Bangalore | PathFinder");

            FactoryMethod fm = new FactoryMethod();      
            
            IPersonagem jogador1 = fm.EscolherPersonagem(Personagem.Wraith);
            Console.WriteLine("");
            Console.WriteLine("Jogador 1:");
            jogador1.Escolhido();

            IPersonagem jogador2 = fm.EscolherPersonagem(Personagem.Bangalore);
            Console.WriteLine("");
            Console.WriteLine("Jogador 2:");
            jogador2.Escolhido();

            IPersonagem jogador3 = fm.EscolherPersonagem(Personagem.PathFinder);
            Console.WriteLine("");
            Console.WriteLine("Jogador 3:");
            jogador3.Escolhido();

        }
    }
}

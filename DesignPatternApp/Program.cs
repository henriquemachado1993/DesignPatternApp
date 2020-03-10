using System;
using SingletonLib;

namespace DesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pattern de Criação

            Console.WriteLine("-------- Pattern Singleton --------");
            Console.WriteLine();
            Console.WriteLine("Exemplo: Jogando Futebol");
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo");
            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("Jogador 2: Recebeu a bola");
            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("Jogador 3: Toca a bola para mim");
            
            Console.WriteLine();
            Console.WriteLine("-------- Pattern Abstract Factory --------");

            #endregion

            #region Pattern Estrutural

            #endregion

            #region Pattern Comportamental

            #endregion

            Console.ReadKey();
        }
    }
}

using System;
using AdapterLib;
using BuilderLib;
using FactoryMethodLib;
using PrototypeLib;
using SingletonLib;

namespace DesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pattern de Criação

            Console.WriteLine("########### PATTERNS DE CRIAÇÃO #############");
            Console.WriteLine("");
            
            SingletonApp.Executar();
            FactoryMethodApp.Executar();
            BuilderApp.Executar();
            PrototypeApp.Executar();

            #endregion

            #region Pattern Estrutural

            Console.WriteLine("########### PATTERNS ESTRUTURAL #############");
            Console.WriteLine("");

            AdapterApp.Executar();

            #endregion

            #region Pattern Comportamental

            Console.WriteLine("########### PATTERNS COMPORTAMENTAL #########");
            Console.WriteLine("");

            #endregion

            Console.ReadKey();
        }
    }
}

﻿using System;
using FactoryMethodLib;
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

            Console.ReadKey();

            #endregion

            #region Pattern Estrutural

            Console.WriteLine("########### PATTERNS ESTRUTURAL #############");
            Console.WriteLine("");

            #endregion

            #region Pattern Comportamental

            Console.WriteLine("########### PATTERNS COMPORTAMENTAL #########");
            Console.WriteLine("");

            #endregion

            Console.ReadKey();
        }
    }
}

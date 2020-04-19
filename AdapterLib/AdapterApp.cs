using AdapterLib.Interfaces;
using AdapterLib.Models;
using System;

namespace AdapterLib
{
    public static class AdapterApp
    {
        public static void Executar()
        {
            Console.WriteLine("-------- Pattern Adapter --------");
            Console.WriteLine();
            Console.WriteLine("Exemplo: ");

            TanqueInimigo rx2020 = new TanqueInimigo();
            RoboInimigo hm2020 = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(hm2020);

            Console.WriteLine(" +++ ROBO +++ ");
            hm2020.ReagirContraHumano("Henrique");
            hm2020.AndarParaFrente();
            hm2020.EsmagarComMaos();

            Console.WriteLine(" +++ TANQUE +++ ");
            rx2020.Pilotar("Jhon");
            rx2020.Movimenta();
            rx2020.ArmaFogo();

            Console.WriteLine(" +++ ROBO ADPTADO +++ ");
            roboAdapter.Pilotar("Fenix");
            roboAdapter.Movimenta();
            roboAdapter.ArmaFogo();

            Console.WriteLine("");
        }
    }
}

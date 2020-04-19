using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterLib.Models
{
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"O Robo Inimigo causou {danoAtaque} de dano com o ataque de Esmagar com as mãos.");
        }

        public void AndarParaFrente()
        {
            int movimento = this.gerador.Next(6) + 1;
            Console.WriteLine($"O Robo Inimigo andou {movimento} passos para frente");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine($"O Robo Inimigo vai contra {piloto}");
        }
    }
}

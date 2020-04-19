using AdapterLib.Interfaces;
using System;

namespace AdapterLib.Models
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        readonly Random gerador = new Random();

        public void ArmaFogo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"Tanque inimigo fez {danoAtaque} de dano!");
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(6) + 1;
            Console.WriteLine($"Tanque inimigo adou {movimento} passos!");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine($"{piloto} está no comando do tanque agora!");
        }
    }
}

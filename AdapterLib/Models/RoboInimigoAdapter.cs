using AdapterLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterLib.Models
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        readonly RoboInimigo robo;

        public RoboInimigoAdapter(RoboInimigo novoRobo)
        {
            this.robo = novoRobo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarParaFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}

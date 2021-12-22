using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public class Camino
    {
        public string CiudadDeOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public int Distancia { get; set; }

        public Camino(string origen, string destino, int distancia)
        {
            CiudadDeOrigen = origen;
            CiudadDestino = destino;
            Distancia = distancia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public class BusquedaEnAmplitud : Algoritmo
    {
        public override void Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino)
        {
            Queue<Camino> caminosSinExpandir = new Queue<Camino>();
            foreach (Camino camino in caminos.Where(x => x.CiudadDeOrigen.Equals(ciudadInicial) ||
            x.CiudadDestino.Equals(ciudadInicial)))
            {
                caminosSinExpandir.Enqueue(camino);
            }
            Camino caminoActual = caminosSinExpandir.Dequeue();
            while (!caminoActual.CiudadDeOrigen.Equals(ciudadDestino) && !caminoActual.CiudadDestino.Equals(ciudadDestino))
            {
                foreach (Camino camino in caminos.Where(x => (x.CiudadDeOrigen.Equals(caminoActual.CiudadDeOrigen) ||
                x.CiudadDestino.Equals(caminoActual.CiudadDeOrigen) || x.CiudadDeOrigen.Equals(caminoActual.CiudadDestino) ||
                x.CiudadDestino.Equals(caminoActual.CiudadDestino))))
                {
                    caminosSinExpandir.Enqueue(camino);
                }
                caminoActual = caminosSinExpandir.Dequeue();
            }
        }
    }
}

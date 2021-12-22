using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public class BusquedaEnProfundidad : Algoritmo
    {
        public override void Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino)
        {
            Stack<Camino> caminosSinExpandir = new Stack<Camino>();
            foreach (Camino camino in caminos.Where(x => x.CiudadDeOrigen.Equals(ciudadInicial) ||
            x.CiudadDestino.Equals(ciudadInicial)))
            {
                caminosSinExpandir.Push(camino);
            }
            Camino caminoActual = caminosSinExpandir.Pop();
            while (!caminoActual.CiudadDeOrigen.Equals(ciudadDestino) && !caminoActual.CiudadDestino.Equals(ciudadDestino))
            {
                foreach (Camino camino in caminos.Where(x => (x.CiudadDeOrigen.Equals(caminoActual.CiudadDeOrigen) ||
                x.CiudadDestino.Equals(caminoActual.CiudadDeOrigen) || x.CiudadDeOrigen.Equals(caminoActual.CiudadDestino) ||
                x.CiudadDestino.Equals(caminoActual.CiudadDestino))))
                {
                    caminosSinExpandir.Push(camino);
                }
                caminoActual = caminosSinExpandir.Pop();
            }
        }
    }
}

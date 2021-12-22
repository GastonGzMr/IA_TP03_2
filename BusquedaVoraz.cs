using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public class BusquedaVoraz: Algoritmo
    {
        public override bool Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino)
        {
            List<Camino> caminosSinExpandir = new List<Camino>();
            List<Camino> caminosExpandidos = new List<Camino>();
            foreach (Camino camino in caminos.Where(x => x.CiudadDeOrigen.Equals(ciudadInicial) ||
            x.CiudadDestino.Equals(ciudadInicial)))
            {
                caminosSinExpandir.Add(camino);
            }

            caminosSinExpandir = caminosSinExpandir.OrderBy(x => x.Distancia).ToList();
            Camino caminoActual = caminosSinExpandir.First();
            caminosSinExpandir.Remove(caminoActual);
            caminosExpandidos.Add(caminoActual);

            while (!caminoActual.CiudadDeOrigen.Equals(ciudadDestino) && !caminoActual.CiudadDestino.Equals(ciudadDestino))
            {
                foreach (Camino camino in caminos.Where(x => (x.CiudadDeOrigen.Equals(caminoActual.CiudadDeOrigen) ||
                x.CiudadDestino.Equals(caminoActual.CiudadDeOrigen) || x.CiudadDeOrigen.Equals(caminoActual.CiudadDestino) ||
                x.CiudadDestino.Equals(caminoActual.CiudadDestino))))
                {
                    if (!caminosExpandidos.Contains(camino))
                    {
                        caminosSinExpandir.Add(camino);
                    }
                }
                caminosSinExpandir = caminosSinExpandir.OrderBy(x => x.Distancia).ToList();
                caminoActual = caminosSinExpandir.First();
                caminosSinExpandir.Remove(caminoActual);
                caminosExpandidos.Add(caminoActual);
            }

            return (caminoActual.CiudadDeOrigen.Equals(ciudadDestino) || caminoActual.CiudadDestino.Equals(ciudadDestino));
        }
    }
}

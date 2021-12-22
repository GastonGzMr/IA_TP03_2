using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    class BusquedaAEstrella : Algoritmo
    {
        public Dictionary<string,int> DistanciasLineaRecta { get; set; }

        public BusquedaAEstrella()
        {
            DistanciasLineaRecta = new Dictionary<string, int>();
            DistanciasLineaRecta.Add("Arad", 366);
            DistanciasLineaRecta.Add("Craiova", 160);
            DistanciasLineaRecta.Add("Dobreta", 242);
            DistanciasLineaRecta.Add("Eforie", 161);
            DistanciasLineaRecta.Add("Fagaras", 178);
            DistanciasLineaRecta.Add("Giurgiu", 77);
            DistanciasLineaRecta.Add("Hirsova", 151);
            DistanciasLineaRecta.Add("Iasi", 226);
            DistanciasLineaRecta.Add("Lugoj", 244);
            DistanciasLineaRecta.Add("Mehadia", 241);
            DistanciasLineaRecta.Add("Neamt", 234);
            DistanciasLineaRecta.Add("Oradea", 380);
            DistanciasLineaRecta.Add("Pitesti", 98);
            DistanciasLineaRecta.Add("Rimnicu Vilcea", 193);
            DistanciasLineaRecta.Add("Sibiu", 253);
            DistanciasLineaRecta.Add("Timisoara", 329);
            DistanciasLineaRecta.Add("Urcizeni", 80);
            DistanciasLineaRecta.Add("Vaslui", 199);
            DistanciasLineaRecta.Add("Zerind", 374);
        }
        public override bool Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino)
        {
            List<Camino> caminosSinExpandir = new List<Camino>();
            List<Camino> caminosExpandidos = new List<Camino>();
            int distanciaRecorrida = 0;
            foreach (Camino camino in caminos.Where(x => x.CiudadDeOrigen.Equals(ciudadInicial) ||
            x.CiudadDestino.Equals(ciudadInicial)))
            {
                caminosSinExpandir.Add(camino);
            }

            caminosSinExpandir = caminosSinExpandir.OrderBy(x => DistanciasLineaRecta[x.CiudadDeOrigen]).ToList();
            Camino caminoActual = caminosSinExpandir.First();
            caminosSinExpandir.Remove(caminoActual);
            caminosExpandidos.Add(caminoActual);
            distanciaRecorrida += caminoActual.Distancia;
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
                caminosSinExpandir = caminosSinExpandir.OrderBy(x => distanciaRecorrida + DistanciasLineaRecta[x.CiudadDeOrigen]).ToList();
                caminoActual = caminosSinExpandir.First();
                caminosSinExpandir.Remove(caminoActual);
                caminosExpandidos.Add(caminoActual);
                distanciaRecorrida += caminoActual.Distancia;
            }

            return (caminoActual.CiudadDeOrigen.Equals(ciudadDestino) || caminoActual.CiudadDestino.Equals(ciudadDestino));
        }

        private double LineaRecta(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino)
        {
            
            return 0;
        }
    }
}

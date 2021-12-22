using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Camino> caminos = new List<Camino>
            {
                new Camino("Oradea","Zerind",71),
                new Camino("Oradea","Sibiu",151),
                new Camino("Zerind","Arad",75),
                new Camino("Arad","Sibiu",140),
                new Camino("Arad","Timisoara",118),
                new Camino("Timisoara","Lugoj",111),
                new Camino("Lugoj","Mehadia",70),
                new Camino("Mehadia","Dobreta",75),
                new Camino("Dobreta","Craiova",120),
                new Camino("Craiova","Pitesti",138),
                new Camino("Sibiu","Rimnicu Vilcea",80),
                new Camino("Sibiu","Fagaras",99),
                new Camino("Rimnicu Vilcea","Craiova",146),
                new Camino("Rimnicu Vilcea","Pitesti",97),
                new Camino("Pitesti","Bucarest",101),
                new Camino("Fagaras","Bucarest",211),
                new Camino("Giurgiu","Bucarest",90),
                new Camino("Bucarest","Urziceni",85),
                new Camino("Urziceni","Hirsova",98),
                new Camino("Hirsova","Eforie",86),
                new Camino("Urziceni","Vaslui",142),
                new Camino("Vaslui","Iasi",92),
                new Camino("Iasi","Neamt",87)
            };
            string ciudadInicial = "Arad";
            string ciudadDestino = "Bucarest";

            DateTime inicio;

            List<Algoritmo> algoritmos = new List<Algoritmo>()
            {
                new BusquedaEnAmplitud(),
                new BusquedaEnProfundidad()
            };

            foreach (Algoritmo algoritmo in algoritmos)
            {
                inicio = DateTime.Now;
                algoritmo.Resolver(caminos, ciudadInicial, ciudadDestino);
                Console.WriteLine("Algoritmo "+algoritmo.GetType().Name+" finalizó en "+
                    DateTime.Now.Subtract(inicio).TotalMilliseconds+" milisegundos.");
            }
            Console.ReadLine();
        }
    }
}

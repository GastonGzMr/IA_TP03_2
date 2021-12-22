using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public abstract class Algoritmo
    {
        public abstract bool Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino);
    }
}

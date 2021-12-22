using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public abstract class Algoritmo
    {
        public abstract void Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino);
    }
}

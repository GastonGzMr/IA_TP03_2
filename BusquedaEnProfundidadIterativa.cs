using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP03_2
{
    public class BusquedaEnProfundidadIterativa: Algoritmo
    {
        public override bool Resolver(IEnumerable<Camino> caminos, string ciudadInicial, string ciudadDestino)
        {
            bool resuelto = false;
            int i = 0;
            BusquedaEnProfundidadLimitada algoritmo;
            while (!resuelto)
            {
                i++;
                algoritmo = new BusquedaEnProfundidadLimitada(i);
                resuelto = algoritmo.Resolver(caminos, ciudadInicial, ciudadDestino);
            }
            return resuelto;
        }
    }
}

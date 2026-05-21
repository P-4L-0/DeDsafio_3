using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeDsafio3
{
    public class CArco
    {
        public CVertice Destino { get; set; }
        public double Peso { get; set; }
        public CArco Siguiente { get; set; }

        public CArco(CVertice destino, double peso)
        {
            Destino = destino;
            Peso = peso;
            Siguiente = null;
        }
    }
}

using DeDsafio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeDsafio3
{
    public class CVertice
    {
        public string Nombre { get; set; }
        public CArco PrimerArco { get; set; }
        public CVertice Siguiente { get; set; }

        public int x { get; set; }
        public int y { get; set; }

        // Variables Dijkstra
        public double Distancia { get; set; }
        public bool Visitado { get; set; }
        public CVertice Previo { get; set; }

        public CVertice(string nombre, int x, int y)
        {
            Nombre = nombre;
            PrimerArco = null;
            Siguiente = null;
            this.x = x;
            this.y = y;
        }
    }
}

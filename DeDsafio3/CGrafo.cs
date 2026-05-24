using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeDsafio3
{

    public class CGrafo
    {
        public CVertice PrimerVertice;

        public CGrafo()
        {
            PrimerVertice = null;
        }

        public void AgregarVertice(string nombre, int x, int y)
        {
            CVertice nuevo = new CVertice(nombre, x, y);
            if (PrimerVertice == null)
            {
                PrimerVertice = nuevo;
            }
            else
            {
                CVertice actual = PrimerVertice;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public CVertice BuscarVertice(string nombre)
        {
            CVertice actual = PrimerVertice;
            while (actual != null)
            {
                if (actual.Nombre == nombre) return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        public void AgregarArco(string origen, string destino, double peso)
        {
            CVertice nodoOrigen = BuscarVertice(origen);
            CVertice nodoDestino = BuscarVertice(destino);
            if (nodoOrigen != null && nodoDestino != null)
            {
                CArco nueva = new CArco(nodoDestino, peso);
                if (nodoOrigen.PrimerArco == null)
                {
                    nodoOrigen.PrimerArco = nueva;
                }
                else
                {
                    CArco actual = nodoOrigen.PrimerArco;
                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = nueva;
                }
            }
        }

        public string[] CalcularRutaOptima(string inicio, string fin)
        {
            CVertice nodoInicio = BuscarVertice(inicio);
            CVertice nodoFin = BuscarVertice(fin);
            if (nodoInicio == null || nodoFin == null) return null;

            CVertice actual = PrimerVertice;
            int totalNodos = 0;
            while (actual != null)
            {
                actual.Distancia = double.MaxValue;
                actual.Visitado = false;
                actual.Previo = null;
                actual = actual.Siguiente;
                totalNodos++;
            }
            nodoInicio.Distancia = 0;

            for (int i = 0; i < totalNodos; i++)
            {
                CVertice u = ObtenerMinimoNoVisitado();
                if (u == null || u.Distancia == double.MaxValue) break;

                u.Visitado = true;

                CArco arcoActual = u.PrimerArco;
                while (arcoActual != null)
                {
                    CVertice v = arcoActual.Destino;
                    if (!v.Visitado)
                    {
                        double nuevaDistancia = u.Distancia + arcoActual.Peso;
                        if (nuevaDistancia < v.Distancia)
                        {
                            v.Distancia = nuevaDistancia;
                            v.Previo = u;
                        }
                    }
                    arcoActual = arcoActual.Siguiente;
                }
            }
            return ReconstruirRuta(nodoFin);
        }

        private CVertice ObtenerMinimoNoVisitado()
        {
            CVertice minNodo = null;
            double minValor = double.MaxValue;
            CVertice actual = PrimerVertice;
            while (actual != null)
            {
                if (!actual.Visitado && actual.Distancia < minValor)
                {
                    minValor = actual.Distancia;
                    minNodo = actual;
                }
                actual = actual.Siguiente;
            }
            return minNodo;
        }

        private string[] ReconstruirRuta(CVertice destino)
        {
            if (destino.Previo == null && destino.Distancia != 0) return null;
            int contador = 0;
            CVertice actual = destino;
            while (actual != null)
            {
                contador++;
                actual = actual.Previo;
            }

            string[] ruta = new string[contador];
            actual = destino;
            for (int i = contador - 1; i >= 0; i--)
            {
                ruta[i] = actual.Nombre;
                actual = actual.Previo;
            }
            return ruta;
        }

        public string[] RecorridoDFS(string inicio)
        {
            CVertice nodoInicio = BuscarVertice(inicio);
            if (nodoInicio == null) return null;

            CVertice actual = PrimerVertice;
            while (actual != null)
            {
                actual.Visitado = false;
                actual = actual.Siguiente;
            }

            List<string> ruta = new List<string>();
            //limpia y empieza la recursividad
            DFS_Recursivo(nodoInicio, ruta);
            return ruta.ToArray(); //retornamos en formato de arrgelo
        }

        private void DFS_Recursivo(CVertice u, List<string> ruta)
        {
            u.Visitado = true;
            ruta.Add(u.Nombre);

            CArco arcoActual = u.PrimerArco;
            while (arcoActual != null)
            {
                if (!arcoActual.Destino.Visitado)
                {
                    DFS_Recursivo(arcoActual.Destino, ruta);
                }
                arcoActual = arcoActual.Siguiente;
            }
        }
    }
}


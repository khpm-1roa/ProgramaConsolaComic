using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arbol2_1
{
    class Manejador
    {
        internal int NumerosHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            var totalHojas = 0;
            foreach (var hijoActual in nodo.Hijos)
            {
                totalHojas += NumerosHojas(hijoActual);

            }

            return totalHojas;
        }
        internal int NumerosNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalNodos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                totalNodos += NumerosNodos(nodoActual);
            }
            return totalNodos + 1;
        }
        internal int NumerosNiveles(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            var nivelHijos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumerosNiveles(nodoActual);
                if (nivelHijos < nivelActual)
                    nivelHijos = nivelActual;
            }
            return ++nivelHijos;
        }
        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
        internal string ImprimirArbolInfijo(Nodo nodo)
        {
            
            if (!nodo.Hijos.Any())
                return nodo.Valor;


            return $"( {ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])})";
        }
        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"({nodo.Valor} {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])})";
        }
        internal string ImprimirArbolPostFijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $" ({ImprimirArbolPostFijo(nodo.Hijos[0])} {ImprimirArbolPostFijo(nodo.Hijos[1])} {nodo.Valor})";


        }

        internal object Resultado(Nodo raiz)
        {
            throw new NotImplementedException();
        }
    }
}

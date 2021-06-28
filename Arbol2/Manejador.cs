using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arbol2
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
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
            return $"( {ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])})";
        }

        internal object Resultado(Nodo raiz)
        {
            throw new NotImplementedException();
        }
    }
}

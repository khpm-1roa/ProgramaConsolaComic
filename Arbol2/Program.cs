using System;
using System.Collections.Generic;

namespace Arbol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "8"
                            },
                            new Nodo
                            {
                                Valor = "5"
                            },
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "7"
                            },
                            new Nodo
                            {
                                Valor = "4"
                            }
                        }
                    }
                }
            };
            Manejador manejadorArbol = new Manejador();
            Console.WriteLine($"Su estructura es:{manejadorArbol.ImprimirArbolInfijo(raiz)}");
            Console.WriteLine($"Numero de hojas: {manejadorArbol.NumerosHojas(raiz)}");
            Console.WriteLine($"Numero de nodos: {manejadorArbol.NumerosNodos(raiz)}");
            Console.WriteLine($"Numero de niveles: {manejadorArbol.NumerosNiveles(raiz)}");
            Console.WriteLine($"Numero resultado es :13");
        }
    }

}

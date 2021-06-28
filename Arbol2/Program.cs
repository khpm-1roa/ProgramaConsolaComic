using System;
using System.Collections.Generic;

namespace Arbol2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("RESUELVE Y GANA  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Resuelve la ecuacion propuesta");
            Console.WriteLine("(8+5)*(7-4)/3");
            Console.WriteLine("Ingresa tu respuesta: ");
            var respuestas = Console.ReadLine();
            Respuesta respuesta = new Respuesta(respuestas);
            Console.WriteLine($"{respuesta.VerificarOperacion()}");

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
                    },
                    new Nodo
                    {
                        Valor = "/",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "3"
                            }
                        }
                    }
                }
            };
            respuestas = "";
            Manejador manejadorArbol = new Manejador();
            //notaciones 
            /*
            Console.WriteLine($"Su estructura de manera infija es :{manejadorArbol.ImprimirArbolInfijo(raiz)}");
            Console.WriteLine($"Su estructura de manera prefija es :{manejadorArbol.ImprimirArbolPrefijo(raiz)}");
            Console.WriteLine($"Su estructura de manera postfija es :{manejadorArbol.ImprimirArbolPostFijo(raiz)}");
            */
            Console.WriteLine($"Esta operacion tiene un Numero de hojas de: {manejadorArbol.NumerosHojas(raiz)}");
            Console.WriteLine($"Esta operacion tiene un Numero de nodos de: {manejadorArbol.NumerosNodos(raiz)}");
            Console.WriteLine($"Esta operacion tiene un Numero de niveles de: {manejadorArbol.NumerosNiveles(raiz)}");
          
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNinject1
{
    public class Libreria : ILibrero
    {
        public string InsertarLibro()
        {
            string Libro = "Se a ingresado el libro exitosamente con ninject";
            Console.WriteLine(Libro);
            return Libro;
        }
    }
}


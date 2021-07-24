using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNinject1
{
    public class Libro
    {
        ILibrero LibroUnidad;
        public Libro(ILibrero objetoLibrero)
        {
            LibroUnidad = objetoLibrero;
        }
        public void IngresoLibro()
        {
            LibroUnidad.InsertarLibro();
        }
    }
}

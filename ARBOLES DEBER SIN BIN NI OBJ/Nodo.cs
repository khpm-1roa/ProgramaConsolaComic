using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol2_1
{

    public class Nodo
    {
        public string ID { get; set; }
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}

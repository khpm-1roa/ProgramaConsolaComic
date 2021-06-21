using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraConsola.models
{
    class Personajes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ColorPiel { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string ColorCabello { get; set; }
        public string Nacionalidad { get; set; }
        public string EstiloCabello { get; set; }
        public string Genero { get; set; }
        public string PertenecePandilla { get; set; }
        public virtual string Saludar()
        {
            return $"El personaje {this.Nombre} con el apellido {this.Apellido} te esta saludando";
        }
        public virtual string Caminar()
        {
            return $"El personaje {this.Nombre}con el apellido {this.Apellido} y color de piel {this.ColorPiel} esta caminando";
        }
        public virtual string Correr()
        {
            return $"El personaje{this.Nombre}con el apellido {this.Apellido} y color de piel {this.ColorPiel} y la altura de {this.Altura} esta corriendo";
        }
        public virtual string Agacharse()
        {
            return $"El personaje {this.Nombre} con el apellido {this.Apellido} y color de piel {this.ColorPiel} y la altura de {this.Altura} y un peso de {this.Peso} esta agachandose";
        }
        public virtual string Disparar()
        {
            return $"El personaje  {this.Nombre} con el apellido {this.Apellido} y color de piel {this.ColorPiel} y la altura de {this.Altura} y un peso de {this.Peso} que pertenece ala pandilla llamada {this.PertenecePandilla} esta disparando";
        }
    }
}

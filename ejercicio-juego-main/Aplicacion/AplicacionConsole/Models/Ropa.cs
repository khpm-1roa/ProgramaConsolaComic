using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraConsola.models
{
    class Ropa
    {
        public string Zapatos{ get; set; }
        public string Pantalon { get; set; }
        public string Camiseta{ get; set; }
        public string Sudadera{ get; set; }
        public string Chompa { get; set; }
        public string Gorra { get; set; }
        public string Cubrebocas { get; set; }
        public string Guantes { get; set; }
        public string Cadenas { get; set; }
        public string Gafas  { get; set; }
        public virtual string Usar()
        {
            return $"tu personaje tiene zapatos marca {this.Zapatos} y un pantalon color {this.Pantalon}y lo esta usando ";
        }
        public virtual string Sacar()
        {
            return $"tu personaje tiene zapatos marca {this.Zapatos}  y un pantalon color {this.Pantalon}y un color de camiseta {this.Camiseta}y estas prendas se las saco ";
        }
        public virtual string Modificar()
        {
            return $"tu personaje tiene zapatos marca {this.Zapatos} y un pantalon color {this.Pantalon}y un color de camiseta {this.Camiseta} y una sudadera de color {this.Sudadera} y estas prendas las van a modificar";
        }
        public virtual string Guardar()
        {
            return $"tu personaje tiene zapatos marca {this.Zapatos} y un pantalon color {this.Pantalon}y un color de camiseta {this.Camiseta} y una sudadera de color {this.Sudadera} con un color de chompa {this.Chompa} las van a guardar ";
        }
        public virtual string Regalar()
        {
            return $"tu personaje tiene zapatos marca {this.Zapatos}y un pantalon color {this.Pantalon}y un color de camiseta {this.Camiseta} y una sudadera de color {this.Sudadera} con un color de chompa {this.Chompa} las van a regalar "; 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraConsola.models
{
    class Vehiculos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Matricula { get; set; }
        public string Transmision { get; set; }
        public string Kilometraje { get; set; }
        public string Direccion { get; set; }
        public string NumRuedas { get; set; }

        /* public virtual string GenerarHistoria()
         {
             return $"El vehiculo {this.Nombre} del la marca {this.Marca} esta acelerandose continuamente y tiene  valores tantos y tantos ";
         }*/
        public virtual string Encender()
        {
            return $"El vehiculo {this.Nombre} esta encendido con la marca de {this.Marca} el modelo {this.Modelo} y del color {this.Color} esta frenando  ";
        }

        public virtual string Acelerar()
        {
            return $"El vehiculo {this.Nombre} del la marca {this.Marca} y del color {this.Color} con la matricula {this.Matricula}esta acelerandose";
        }

        public virtual string Frenar()
        {
            return $"El vehiculo {this.Nombre} del la marca {this.Marca} el modelo {this.Modelo} y del color {this.Color} con la matricula {this.Matricula} con un kilometraje de {this.Kilometraje} esta frenando";
        }

        public virtual string Chocar()
        {
            return $"El vehiculo {this.Nombre} con la marca de {this.Marca} y el modelo {this.Modelo}  del color {this.Color}  con la matricula {this.Matricula} esta chocado";
        }

        public virtual string Apagar()
        {
            return $"El vehiculo {this.Nombre} con la marca de {this.Marca} el modelo {this.Modelo} y  del color {this.Color} y  con la matricula {this.Matricula} y con la direccion {this.Direccion}  esta apagado";
        }

    }
}

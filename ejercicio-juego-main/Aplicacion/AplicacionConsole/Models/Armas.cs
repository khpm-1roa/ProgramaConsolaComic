using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraConsola.models
{
    class Armas
    {
        public string Nombre { get; set; }
        public string Tamaño { get; set; }
        public string Skin { get; set; }
        public string Color { get; set; }
        public string Municiones  { get; set; }
        public string NumeroBalas { get; set; }
        public string FirmaMuerte { get; set; }
        public string Silenciador { get; set; }
        public string Mira { get; set; }
        public string VelocidadCarga { get; set; }

        public virtual string Obtener()
        {
            return $"tu arma con el nombre de {this.Nombre} ha sido obtenida  ";
        }
        public virtual string Usar()
        {
            return $"tu arma con el nombre de {this.Nombre} y el tamaño {this.Tamaño} y la skin {this.Skin}  se esta usando  ";
        }
        public virtual string Recargar()
        {
            return $"tu arma  con el nombre de {this.Nombre} y el tamaño {this.Tamaño} y la skin {this.Skin} y el color {this.Color} se esta recargando    ";
        }
        public virtual string Modificar()
        {
            return $"tu arma  con el nombre de {this.Nombre} y el tamaño {this.Tamaño} y la skin {this.Skin} y el color {this.Color} y con las municiones {this.Municiones} se esta modificando  ";
        }
        public virtual string Disparar()
        {
            return $"tu arma  con el nombre de {this.Nombre} y el tamaño {this.Tamaño} y la skin {this.Skin} y el color {this.Color} y con las municiones {this.Municiones} con un numero de balas de {this.NumeroBalas} se esta disparando  ";
        }
    }
}

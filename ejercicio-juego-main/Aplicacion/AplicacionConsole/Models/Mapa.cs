using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraConsola.models
{
    class Mapa
    {
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Clima { get; set; }
        public string Temperatura { get; set; }
        public string Velocidad { get; set; }
        public string Montañas { get; set; }
        public string Trafico { get; set; }
        public string Gente { get; set; }
        public string ColorCielo { get; set; }
        public string TemaJuego  { get; set; }

        public virtual string Crear()
        {
            return $"tu mapa con el pais {this.Pais} y ciudad {Ciudad} ha sido creado correctamente  ";
        }
        public virtual string Usar()
        {
            return $"tu mapa con el pais {this.Pais} y ciudad {Ciudad} con el clima {this.Clima} esta en usabilidad  ";
        }
        public virtual string Modificar()
        {
            return $"tu mapa con el pais {this.Pais} y ciudad {Ciudad}con el clima {this.Clima} y una temperatura de {this.Temperatura} ha sido modificado ";
        }
        public virtual string Eliminar()
        {
            return $"tu mapa con el pais {this.Pais} y ciudad {Ciudad} con el clima {this.Clima} y una temperatura de {this.Temperatura} y con uan velocidad de juego de {this.Velocidad} se ha eliminado exitosamente  ";
        }
        public virtual string Actualizar()
        {
            return $"tu mapa con el pais {this.Pais} y ciudad {Ciudad} con el clima {this.Clima} y una temperatura de {this.Temperatura} y con uan velocidad de juego de {this.Velocidad} con un nivel de trafico {this.Trafico} ha sido actualizado exitosamente  ";
        }
    }
}

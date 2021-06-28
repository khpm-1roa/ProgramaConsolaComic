using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol2_1
{
    class Respuesta
    {
        public Respuesta(string respuestas)
        {
            Respuestas = respuestas;
        }
        internal string VerificarOperacion()
        {
            var resultadoPositivo = "RESPUESTA CORRECTA.";
            var resultadoNegativo = "RESPUESTA INCORRECTA.";

            if (Respuestas != null && Respuestas == "13")
                return resultadoPositivo + "Felicidades Tu nivel de conociminto es exelente  :)";
            else
                return resultadoNegativo + "No nos llame nosotros lo llamamos";
        }
        public string Respuestas { get; set; }
    }
}

using System;
using PrimeraConsola.models;

namespace PrimeraConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                for (var i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
            //variables 
            var Carro = new Vehiculos();
            var Mapa = new Mapa();
            var Ropa = new Ropa();
            var Armas = new Armas();
            var Personaje = new Personajes();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************Bienvenido a GTA *************************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Ingrese los datos de su vehiculo favorito de GTA");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el nombre del vehiculo");
            Carro.Nombre = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el marca del vehiculo");
            Carro.Marca = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el modelo del vehiculo");
            Carro.Modelo = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el Color del vehiculo");
            Carro.Color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el Matricula del vehiculo");
            Carro.Matricula = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese la transmision del vehiculo");
            Carro.Transmision = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el kilometraje del vehiculo");
            Carro.Kilometraje = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese la direccion del vehiculo");
            Carro.Direccion = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el numero de ruedas  del vehiculo");
            Carro.NumRuedas = Console.ReadLine();
            //metodos de el vehiculo
            Console.WriteLine(Carro.GenerarHistoria());
            Console.WriteLine(Carro.Encender());//toma solo la primera propiedas
            Console.WriteLine(Carro.Acelerar());//debe tomar la primera y la seg7ujnda
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());

            //personaje favorito
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese los datos de su personaje favorito de GTA");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el nombre de su personaje");
            Personaje.Nombre = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el apellido  de su personaje ");
            Personaje.Apellido = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color de piel   de su personaje ");
            Personaje.ColorPiel = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese la altura  de su personaje ");
            Personaje.Apellido = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el peso de su personaje ");
            Personaje.Peso = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el  color de cabello   de su personaje ");
            Personaje.ColorCabello = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese la nacionalidad de su personaje ");
            Personaje.Nacionalidad = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el estilo de cabello  de su personaje ");
            Personaje.EstiloCabello = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el genero  de su personaje ");
            Personaje.Genero = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  un nombre de una pandilla  de su personaje ");
            Personaje.PertenecePandilla = Console.ReadLine();
            //-------metodos de personaje --------
            Console.WriteLine(Carro.Encender());
            Console.WriteLine(Carro.Acelerar());
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());

            //clase ropa
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese los datos de su ropa favorita de GTA");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese la marca de sus zapatos favoritos  para el personaje");
            Ropa.Zapatos = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color del pantalon  favoritos  para el personaje");
            Ropa.Pantalon = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color de su camiseta  del su personaje");
            Ropa.Camiseta = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color de su camiseta  del su personaje");
            Ropa.Camiseta = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color de su sudadera ");
            Ropa.Sudadera = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color de su chompa ");
            Ropa.Chompa = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el color de su gorra  ");
            Ropa.Gorra = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese desea llevar cubrebocas");
            Ropa.Cubrebocas = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese desea usar guantes  ");
            Ropa.Guantes = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese desea usar cadenas ");
            Ropa.Cadenas = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese desea llevar lentes de sol   ");
            Ropa.Gafas = Console.ReadLine();
            //-------metodos de la ropa  --------
            Console.WriteLine(Carro.Encender());
            Console.WriteLine(Carro.Acelerar());
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());

            //clase de armas
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese los datos de sus armas");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el nombre de su arma ");
            Armas.Nombre = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el tamaño de su arma ");
            Armas.Nombre = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el color de su skin para su arma ");
            Armas.Skin = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el color de su arma ");
            Armas.Color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el numero de municones para  su arma ");
            Armas.Municiones = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el numero de balas para  su arma ");
            Armas.NumeroBalas = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese   su frase de firma de muerte  ");
            Armas.FirmaMuerte = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese   si desea tener sileciador para  su arma ");
            Armas.Silenciador = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese el nivel de mira  para  su arma ");
            Armas.Mira = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  la velocidad de carga  para  su arma ");
            Armas.VelocidadCarga = Console.ReadLine();
            //-------metodos de las armas  --------
            Console.WriteLine(Carro.Encender());
            Console.WriteLine(Carro.Acelerar());
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());

            //clase mapa 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese los datos de su mapa de juego");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el nombre del pais donde se desarrollara  ");
            Mapa.Pais = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el nombre de la ciudad  ");
            Mapa.Ciudad= Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el tipo de clima  ");
            Mapa.Clima = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  la temperatura   ");
            Mapa.Temperatura = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  la velocidad de juego  ");
            Mapa.Velocidad = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese desea tener un paisaje de montañas   ");
            Mapa.Montañas = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el nivel de trafico ");
            Mapa.Trafico = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el nivel de personas   ");
            Mapa.Gente = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el color del cielo   ");
            Mapa.ColorCielo = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese  el tema de juego que desea  ");
            Mapa.TemaJuego = Console.ReadLine();
            //-------metodos del mapa  --------
            Console.WriteLine(Carro.Encender());
            Console.WriteLine(Carro.Acelerar());
            Console.WriteLine(Carro.Frenar());
            Console.WriteLine(Carro.Chocar());
            Console.WriteLine(Carro.Apagar());

            //finalizacion del programa 
            Console.WriteLine(" ");
            Console.WriteLine("Toque cualquer tecla para culminar el progrma");
            Console.ReadKey();

        }
    }
}

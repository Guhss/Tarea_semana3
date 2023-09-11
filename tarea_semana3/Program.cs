using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de batalla por turnos.");

            Console.Write("Ingresa la cantidad de enemigos Melee: ");
            int cantidadEnemigosMelee = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa la cantidad de enemigos de Rango: ");
            int cantidadEnemigosRango = Convert.ToInt32(Console.ReadLine());

            Juego juego = new Juego(cantidadEnemigosMelee, cantidadEnemigosRango);
            juego.IniciarJuego();

        }


    }
}

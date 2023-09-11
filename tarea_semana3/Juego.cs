using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana3
{
    internal class Juego
    {
        private Jugador jugador;
        private List<Enemigo_melee> enemigosMelee;
        private List<Enemigo_rango> enemigosRango;

      

        public void IniciarJuego()
        {
            while (true)
            {
                Console.WriteLine("Turno del jugador:");
                Console.WriteLine($"Vida del jugador: {jugador.ObtenerVida()}");
                Console.WriteLine("Elige a qué enemigo quieres atacar (0 para terminar turno):");

                

                if (TodosEnemigosDerrotados())
                {
                    Console.WriteLine("¡Has ganado! Todos los enemigos han sido derrotados.");
                    break;
                }
            }
        }

       

        private bool TodosEnemigosDerrotados()
        {
            foreach (var enemigo in enemigosMelee)
            {
                if (enemigo.EstaVivo())
                {
                    return false;
                }
            }

            foreach (var enemigo in enemigosRango)
            {
                if (enemigo.EstaVivo())
                {
                    return false;
                }
            }

            return true;
        }
    }


}

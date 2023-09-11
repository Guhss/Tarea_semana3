using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana3
{
    internal class Jugador
    {
        private int vida;
        private int dano;

        public Jugador(int vida, int dano)
        {
            if (vida <= 100 && dano <= 100)
            {
                this.vida = vida;
                this.dano = dano;
            }
            else
            {
                Console.WriteLine("La vida y el daño no pueden superar 100.");
            }
        }

        public void RecibirDano(int cantidad)
        {
            vida -= cantidad;
        }

        public int ObtenerDano()
        {
            return dano;
        }

        public int ObtenerVida()
        {
            return vida;
        }
    }
}

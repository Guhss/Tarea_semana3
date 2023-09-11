using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana3
{
    internal class Enemigo_melee
    {
        private int vida;
        private int dano;

        public Enemigo_melee(int vida, int dano)
        {
            this.vida = vida;
            this.dano = dano;
        }

        public void RecibirDanio(int cantidad)
        {
            vida -= cantidad;
        }

        public int ObtenerDano()
        {
            return dano;
        }

        public bool EstaVivo()
        {
            return vida > 0;
        }
    }
}

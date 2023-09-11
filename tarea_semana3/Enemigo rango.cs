using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana3
{
    internal class Enemigo_rango
    {
        private int vida;
        private int dano;
        private int balas;

        public Enemigo_rango(int vida, int dano, int balas)
        {
            this.vida = vida;
            this.dano = dano;
            this.balas = balas;
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

        public bool PuedeAtacar()
        {
            return balas > 0;
        }

        public void Disparar()
        {
            if (PuedeAtacar())
            {
                balas--;
            }
        }
    }
}

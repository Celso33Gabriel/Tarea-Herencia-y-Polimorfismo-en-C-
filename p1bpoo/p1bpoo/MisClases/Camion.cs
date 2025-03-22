using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{

    class Camion : Vehiculo
    {
        private int capacidadCarga = 1000;
        private int cargaActual = 0;
        private bool tieneRemolque = false;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto / 2);
            Console.WriteLine("El camión acelera lentamente debido a su peso.");
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("El camión ha frenado con precaución.");
        }

        public void Cargar(int peso)
        {
            if (cargaActual + peso <= capacidadCarga)
            {
                cargaActual += peso;
                Console.WriteLine("Carga añadida. Peso actual: {0} KG", cargaActual);
            }
            else
            {
                Console.WriteLine("No se puede añadir más carga.");
            }
        }
    }
}
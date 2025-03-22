using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{

    class AutoDeCombustion : Vehiculo
    {
        private int nivelCombustible = 100;
        private string tipoCombustible = "Gasolina";
        private int capacidadTanque = 50;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            nivelCombustible -= 2;
            Console.WriteLine("Nivel de combustible: {0}%", nivelCombustible);
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("El auto de combustión ha frenado.");
        }

        public void CargarCombustible()
        {
            nivelCombustible = 100;
            Console.WriteLine("Tanque lleno.");
        }
    }
}


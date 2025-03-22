using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{

    class Motocicleta : Vehiculo
    {
        private bool tieneCasco = true;
        private string tipoMoto = "Deportiva";
        private int cilindrada = 600;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto * 2);
            Console.WriteLine("La motocicleta acelera más rápido!");
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("La motocicleta ha frenado de golpe.");
        }

        public void RealizarCaballito()
        {
            Console.WriteLine("Haciendo un caballito!");
        }
    }
}
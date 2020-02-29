using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_Classes
{
    class Cilindro : Circulo
    {
        // propriedades
        private int altura;

        // getters e setters
        public int Altura
        {
            get { return altura; }
            set
            {
                if (value >= 0)
                    altura = value;
            }
        }

        // Construtores
        public Cilindro() : base(2)
        {
            altura = 1;
        }

        public Cilindro(int valorRaio, int valorAltura) : base(valorRaio)
        {
            altura = valorAltura;
        }

        // Métodos
        public double getAreaCilindro()
        {
            return 2 * Math.PI * Raio * (altura + Raio);
        }

        public double getVolume()
        {
            return base.getArea() * altura;
        }
    }
}


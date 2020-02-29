using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_Classes
{
    class Circulo
    {
        // Propriedades
        private int raio;

        // Construtores
        public Circulo()
        {
            raio = 1;
        }

        public Circulo(int valor)
        {
            raio = valor;
        }

        // Getters e Setters
        public int Raio { 
            get => raio;
            set 
            {
                if(value >= 0)
                    raio = value;
            }
        }

        /*
        public int Raio
        {
            get { return raio; }
            set { 
                if(value >= 0)
                    raio = value; 
            }
        }
        */

        //Métodos
        public double getPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }


    }
}

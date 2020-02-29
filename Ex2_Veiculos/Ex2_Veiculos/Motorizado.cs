using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Veiculos
{
    class Motorizado : Veiculo
    {
        // Atributos
        private int cilindrada, potencia;

        // getters e setters
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public int Potencia { get => potencia; set => potencia = value; }

        // Construtores
        public Motorizado(): base("Sem dono", 4)
        {
            cilindrada = 1000;
            potencia = 75;
        }

        public Motorizado(string dono, int NrRodas, int Cilindrada, int Potencia)
            :base(dono, NrRodas)
        {
            this.cilindrada = Cilindrada;
            this.potencia = Potencia;
        }

        public override void acelerar()
        {
            velocidade += 10;
        }

        public override void travar()
        {
            if (velocidade > 0)
                velocidade -= 10;
        }
    }
}

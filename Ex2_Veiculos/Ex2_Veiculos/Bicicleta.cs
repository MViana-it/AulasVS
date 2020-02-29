using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Veiculos
{
    class Bicicleta : Veiculo
    {
        // Construtores
        public Bicicleta(): base("Sem dono", 2){ }

        public Bicicleta(string dono) : base(dono, 2) { }

        public Bicicleta(string dono, int rodas) : base(dono, rodas) { }

        public override void acelerar()
        {
            velocidade++;
        }

        public override void travar()
        {
            if (velocidade > 0)
                velocidade--;
        }
    }
}

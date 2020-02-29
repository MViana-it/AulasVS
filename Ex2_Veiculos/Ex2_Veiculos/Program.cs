using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta GT = new Bicicleta();
            Bicicleta GT2 = new Bicicleta("Mário Viana", 3);

            Motorizado fiat = new Motorizado();
            Motorizado BMW = new Motorizado("Rui", 4, 3000, 400);

            Console.WriteLine("Velocidade atual de GT: " + GT.getVelocidade());
            GT.acelerar();
            Console.WriteLine("Velocidade atual de GT: " + GT.getVelocidade());
            GT.acelerar();
            Console.WriteLine("Velocidade atual de GT: " + GT.getVelocidade());
            GT.travar();
            Console.WriteLine("Velocidade atual de GT (a travar): " + GT.getVelocidade());

            Console.WriteLine("\n\nVelocidade atual de BMW: " + BMW.getVelocidade());
            BMW.acelerar();
            Console.WriteLine("Velocidade atual de BMW: " + BMW.getVelocidade());
            BMW.acelerar();
            Console.WriteLine("Velocidade atual de BMW: " + BMW.getVelocidade());
            BMW.travar();
            Console.WriteLine("Velocidade atual de BMW (a travar): " + BMW.getVelocidade());
            Console.ReadKey();
        }
    }
}

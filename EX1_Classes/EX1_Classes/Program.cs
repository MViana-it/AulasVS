using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            Circulo c2 = new Circulo(20);
           
            Console.WriteLine("Raio do círculo C1: " + c1.Raio);
            Console.WriteLine("Área de C1: " + c1.getArea() +
                "\nPerímetro de C1: " + c1.getPerimetro());

            Console.WriteLine("Raio do círculo C2: " + c2.Raio);
            Console.WriteLine("Área de C2: " + c2.getArea() +
                "\nPerímetro de C2: " + c2.getPerimetro());

            Cilindro cl1 = new Cilindro();
            Cilindro cl2 = new Cilindro(4, 7);

            Console.WriteLine("\nDados do cilindro 1: " + 
                "\nÁrea: " + cl1.getAreaCilindro() +
                "\nVolume: " + cl1.getVolume() + 
                 "\nÁrea da base: " + cl1.getArea() +
                 "\nPerímetro da base: " +  cl1.getPerimetro());

            Console.WriteLine("\nDados do cilindro 2: " +
                "\nÁrea: " + cl2.getAreaCilindro() +
                "\nVolume: " + cl2.getVolume() +
                 "\nÁrea da base: " + cl2.getArea() +
                 "\nPerímetro da base: " + cl2.getPerimetro());

            Console.ReadKey();
        }
    }
}

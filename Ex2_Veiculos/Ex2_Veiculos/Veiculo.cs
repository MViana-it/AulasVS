using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Veiculos
{
    abstract class Veiculo
    {
        // atributos
        private string dono;
        private int rodas;
        protected int velocidade;

        // getters e setters
        public string Dono { get => dono; set => dono = value; }
        public int Rodas { get => rodas; set => rodas = value; }

        // Construtores
        public Veiculo()
        {
            dono = "Sem dono";
            rodas = 4;
            velocidade = 0;
        }

        public Veiculo(string nome, int nrRodas)
        {
            this.dono = nome;
            this.rodas = nrRodas;
            velocidade = 0;
        }

        public int getVelocidade()
        {
            return velocidade;
        }

        // Métodos abstratos
        public abstract void acelerar();
        public abstract void travar();

    }
}

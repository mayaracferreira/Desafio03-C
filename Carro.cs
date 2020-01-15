using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class Carro
    {

        private int portas { get; set; }

        private int ano { get; set; }


        public Carro(string marca, string modelo, string placa, string cor, float km, Boolean ligado, int litrosCombustivel, int velocidade, double preco, int portas, int ano) :
            base(marca, modelo, placa, cor, km, ligado, litrosCombustivel, velocidade, preco)

        {

            this.portas = portas;
            this.ano = ano;
        }

        public void status()
        {
            base.status();

            Console.WriteLine("Quantidade de portas:" + this.portas);
            Console.WriteLine("Ano do carro: " + this.ano);

        }
    }
}


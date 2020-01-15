using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class Aviao
    {

        private string tipo { get; set; }
        private string uso { get; set; }

        public Aviao(string marca, string modelo, string placa, string cor, float km, Boolean ligado, int litrosCombustivel, int velocidade, double preco, string tipo, string uso) :
            base(marca, modelo, placa, cor, km, ligado, litrosCombustivel, velocidade, preco)

        {
            this.tipo = tipo;
            this.uso = uso;
        }

        public void status()
        {
            base.status();
            Console.WriteLine("Tipo do avião:" + this.tipo);
            Console.WriteLine("Uso do avião:" + this.uso);
        }
    }
}

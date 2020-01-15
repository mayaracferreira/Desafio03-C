using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class Veiculo
    {
        private string marca { get; set; }
        private string modelo { get; set; }

        private string placa { get; set; }

        private string cor { get; set; }

        private float Km { get; set; }

        private Boolean ligado { get; set; }

        private int litrosCombustivel { get; set; }

        private int velocidade { get; set; }

        private double preco { get; set; }


        public Veiculo(string marca, string modelo, string placa, string cor, float km, Boolean ligado, int litrosCombustivel, int velocidade, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.Km = km;
            this.ligado = ligado;
            this.litrosCombustivel = litrosCombustivel;
            this.velocidade = velocidade;
            this.preco = preco;
        }
        public void status()
        {
            Console.WriteLine("Marca do veiculo:" + this.marca);
            Console.WriteLine("modelo: " + this.modelo);
            Console.WriteLine("placa: " + this.placa);
            Console.WriteLine("cor: " + this.cor);
            Console.WriteLine("Quilometragem: " + this.Km + "km");
            Console.WriteLine("Está ligado? " + this.ligado);
            Console.WriteLine("Velocidade: " + this.velocidade);
            Console.WriteLine("Preço: " + this.preco);
        }
        public void acelerar()
        {
            if (this.ligado == true)
            {
                this.velocidade += 20;
                this.litrosCombustivel -= 1;
            }


            else
            {
                Console.WriteLine("Não é possível acelar, o veículo está desligado.");
            }

        }
        public void abastecer(int lts)
        {
            if (this.litrosCombustivel + lts > 100)
            {
                Console.WriteLine("O veiculo excedeu o limite de combustivel de 100 lts");
                Console.WriteLine("Quantidade de combustivel atual: " + this.litrosCombustivel);
            }


            else
            {

                this.litrosCombustivel += lts;
                Console.WriteLine("O veículo foi abastecido com : " + this.litrosCombustivel + " litros de combustivel");

            }
        }


        public void frear()
        {
            if (this.ligado == true && this.velocidade > 0)
            {
                this.velocidade -= 10;
            }

            else
            {
                Console.WriteLine("O veículo está parado");
            }
        }
        public void pintar(String cor)
        {
            this.cor = cor;
            Console.WriteLine("A cor do veículo foi alterada para: " + this.cor);
        }

        public void ligar()
        {
            if (this.ligado == true)
            {
                Console.WriteLine("O veículo já está ligado.");
            }
            else
            {
                this.ligado = true;
                Console.WriteLine("Ligando o veículo.");

            }
        }

        public void desligar()
        {
            if (this.ligado == false)
            {
                Console.WriteLine(" O Veículo está desligado.");
            }

            else
            {
                this.ligado = false;
                Console.WriteLine("Desligando o veículo");
            }

        }
    }
}    
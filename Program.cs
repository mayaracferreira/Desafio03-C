using System;

namespace Desafio03
{
    class Program
    {



            static void Main(string[] args)
            {


            Carro c1 = new Carro("honda", "city", "FAM4334", "cinza", 10, true, 50, 10, 38000, 4, 2016);

            Aviao a1 = new Aviao("booing", "773", "5555", "branco", 10, true, 50, 100, 80000, "comercial", "corporativo");



            c1.status();
            Console.WriteLine("---------------------------------------");
            a1.status();

            }




    }

}

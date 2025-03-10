using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos1.Model;

namespace FixacaoConceitosBasicos1
{
    class Testes
    {
        public static void executarTestes() {

            Console.WriteLine("\n==== SOMA ====");
            Console.WriteLine(SomaDoisNumeros.Somar(2, 5));

            Console.WriteLine("\n==== CONVERSÃO METROS -> MM ====");
            Console.WriteLine(MetrosMilimetros.Converter(2.5));

            Console.WriteLine("\n==== AUMENTO ====");
            Console.WriteLine(CalculaAumento.Calcular(1400, 200));

            Console.WriteLine("\n==== Desconto ====");
            Console.WriteLine(CalculaDesconto.Calcular(1000, 10));

            Console.WriteLine("\n==== Aluguel de carro ====");
            Console.WriteLine(CalculaAluguelCarro.Calcular(5, 0, 80));

        }
    }
}

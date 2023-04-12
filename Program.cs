using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b;
            double h;
            double a;

            // Entrada de Dados
            Console.Write("Informe a base do Triângulo: ");
            b=double.Parse(Console.ReadLine());
            Console.Write("Informe a altura do Triângulo: ");
            h=double.Parse(Console.ReadLine());
            // Operação
            a = b * h / 2;

            Console.WriteLine("O valor da base do Triângulo é {0}, e sua altura é {1}, com isso, sua área é igual a {2}", b, h, a);

        }
    }
}

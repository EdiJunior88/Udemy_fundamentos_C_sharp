using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Padaria do Seu Jorge / v1.0 ==========");
            Console.WriteLine("\nPreço dos alimentos:\n");
            Console.WriteLine("Chocolate = R$30.00");
            Console.WriteLine("Refrigerante = R$50.00");
            Console.WriteLine("Bolo = R$45.00");
            Console.WriteLine("Sorvete = R$60.00");
            Console.WriteLine("Pao = R$15.00\n");
            Console.WriteLine("=================================================");
            Console.WriteLine("\nPreço dos alimentos com ajuste de 25%:\n");

            PrecoFinal();

            Console.ReadLine();
        }

        static void PrecoFinal()
        {
            double Chocolate = 30;
            double Refrigerante = 50;
            double Bolo = 45;
            double Sorvete = 60;
            double Pao = 15;

            double resultado1 = (0.25 * Chocolate) + Chocolate;
            double resultado2 = (0.25 * Refrigerante) + Refrigerante;
            double resultado3 = (0.25 * Bolo) + Bolo;
            double resultado4 = (0.25 * Sorvete) + Sorvete;
            double resultado5 = (0.25 * Pao) + Pao;

            Console.WriteLine($"Chocolate = R${resultado1:0.00}");
            Console.WriteLine($"Refrigerante = R${resultado2:0.00}");
            Console.WriteLine($"Bolo = R${resultado3:0.00}");
            Console.WriteLine($"Sorvete = R${resultado4:0.00}");
            Console.WriteLine($"Pao = R${resultado5:0.00}");
        }
    }
}

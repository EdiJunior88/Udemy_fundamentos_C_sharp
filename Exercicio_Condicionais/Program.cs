using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2 : Estruturas Condicionais - perguntas

            /*
             1.Crie um Programa em C# que receba três números do usuário, informe na tela qual 
            é o MENOR deles ou exiba se eles são iguais.
             */

            Console.Write("Digite o primeiro número: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------------");

            if (valor1 > valor2)
            {
                Console.Write("O menor número é: " + valor2);
            }
            else if (valor1 > valor3)
            {
                Console.Write("O menor número é: " + valor3);
            }
            else if (valor2 > valor1)
            {
                Console.Write("O menor número é: " + valor1);
            }
            else if (valor2 > valor3)
            {
                Console.Write("O menor número é: " + valor3);
            }
            else if (valor3 > valor1)
            {
                Console.Write("O menor número é: " + valor1);
            }
            else if (valor3 > valor2)
            {
                Console.Write("O menor número é: " + valor2);
            }
            else if (valor1 == valor2 && valor1 == valor3)
            {
                Console.Write("Os números " + valor1 + "," + valor2 + "," + valor3 + " são iguais!");
            }
            else
            {
                Console.Write("A operação falhou! Tente novamente.");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retorno_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            GerarPreço(60);
            GerarPreço(30);
            GerarPreço(20);
            GerarPreço(-20);
            GerarPreço(-20223);
            GerarPreço(-3);
            Console.ReadLine();
            */

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(10, 20, 30);
            int soma3 = Somar(100, 200, 300);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            Console.ReadLine();
        }

       /* static void exibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Guia do Programador");
            Console.WriteLine("Victor Lima");
        }
       */

        /*
        static void GerarPreço(int preco)
        {
            int precoABS = Math.Abs(preco); //Math.Abs - Retorna o valor absoluto de um número especificado.
            int valorFinal = precoABS + (2 * precoABS);
            Console.WriteLine("Valor Final: " + valorFinal);
        }
       */

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            gerarPreco(60);
            gerarPreco(30);
            gerarPreco(20);
            gerarPreco(-20);
            gerarPreco(-20223);
            gerarPreco(-3);
            Console.ReadLine();
        }

        static void exibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Guia do programador!");
            Console.WriteLine("Victor Lima");
        }

        static void gerarPreco(int preco)
        {
            int precoABS = Math.Abs(preco);
            int valorFinal = precoABS + (2 * precoABS);
            Console.WriteLine("Valor Final: " + valorFinal);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capturar_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }
}

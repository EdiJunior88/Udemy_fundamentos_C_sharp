using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Funcoes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Exibindo os Resultados =======\n");
            float Recebe_area = Pizza(30);
            Console.WriteLine($"A área da pizza deve ser de aproximadamente: {Recebe_area}cm");

            Console.ReadLine();
        }

        //CRIANDO UMA FUNÇÃO
        static float Pizza(int raio)
        {
            float pi = 3.14f;
            float area = pi * (raio * raio);
            return area;
        }
    }
}

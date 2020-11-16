using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Funcoes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Exibindo os Resultados =======\n");
            float Recebe_area = Praça(250, 350);
            Console.WriteLine($"A área do terreno deve ser de aproximadamente: {Recebe_area}m²");

            Console.ReadLine();
        }

        //CRIANDO UMA FUNÇÃO
        static float Praça(int Base, int Altura)
        {
            int area = (Base * Altura) / 2;
            return area;
        }
    }
}

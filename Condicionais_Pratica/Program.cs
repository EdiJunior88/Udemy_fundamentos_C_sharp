using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 2;

            if(a < b) //SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou Elseif!");
            }
            else //SE NÃO
            {
                Console.WriteLine("É mentira!");
            }

            Console.ReadLine();
        }
    }
}

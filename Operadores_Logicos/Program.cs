using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            int c = 200;

            if (a < b || a > c) //SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou ElseIf!");
            }
            else //SE NÃO
            {
                Console.WriteLine("É mentira!");
            }

            Console.ReadLine();
        }
    }
}

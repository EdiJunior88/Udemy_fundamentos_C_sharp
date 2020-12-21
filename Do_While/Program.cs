using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador2 = 0;

            do
            {
                Console.WriteLine("do while!");
                contador2++;
            }
            while (contador2 < 20);

            Console.WriteLine("FIM DA LINHA!");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeclararVariaveis_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var cor_favorita = "vermelho";
            var modeloDoProduto = 2323;
            */

            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 2323232332;

            Console.WriteLine(cor_favorita);

            cor_favorita = 3235232.568f;

            Console.WriteLine(cor_favorita);

            Console.ReadLine();
        }
    }
}

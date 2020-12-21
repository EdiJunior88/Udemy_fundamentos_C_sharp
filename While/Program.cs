using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador < 20) //Enquanto for verdade faça
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("Rodando o while!");
                //contador = contador + 1;
                //contador += 1;
                contador++;
            }

            Console.WriteLine("FIM DA LINHA!");
            Console.ReadLine();
        }
    }
}

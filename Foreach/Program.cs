using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Victor", "Lima", "Guia do prog", "Formação", "Node", "Curso de C#", "Udemy!" };

            foreach(string palavra in palavras) //Para cada (foreach) palavra no array palavras, repita o bloco de código
            {
                Console.WriteLine(palavra);
            }

            Console.WriteLine("FIM DA LINHA!");
            Console.ReadLine();
        }
    }
}

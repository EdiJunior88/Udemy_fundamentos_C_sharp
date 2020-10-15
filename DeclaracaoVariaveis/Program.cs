using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracaoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int -  -156 como 32334
            //Float -  -15.6 como 232.132
            //Bool - True ou False
            //String - "adadadasdsdasd"
            //Char - 'a'

            //A-Z
            //0-9
            //@ $ . (não pode usar caracteres especiais)
            //_
            // class, using, static (não pode usar palavras reservadas)

            int segundaGuerraMundial = 1942;
            string corFavorita = "azul";
            float velocidadeF1 = 294.48f;
            bool segundaGuerraMundialAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            corFavorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Cor {Azul, Verde, Amarelo, Vermelho}
        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaDaCarla = Cor.Azul;

            Console.WriteLine((Cor)2);
            Console.WriteLine(corFavoritaDaCarla);

            Console.ReadLine();
        }
    }
}

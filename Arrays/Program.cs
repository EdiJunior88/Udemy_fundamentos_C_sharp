using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Sea of Thieves";
            string produto2 = "FIFA";
            string produto3 = "Minecraft";
            string produto4 = "Half-Life";
            string produto5 = "Portal";
            string produto6 = "CS";

            string[] produtos = new string[5] {
                "Sea of Thieves", // índice 0
                "FIFA", // índice 1
                "Minecraft", // índice 2
                "Half-Life", // índice 3
                "Portal" // índice 4
            };

            int[] valores =
            {
                40,
                50,
                60,
                70,
                20
            };

            produtos[1] = "FIFA 2021";

            Console.WriteLine(produtos[1]);

            Console.ReadLine();
        }
    }
}

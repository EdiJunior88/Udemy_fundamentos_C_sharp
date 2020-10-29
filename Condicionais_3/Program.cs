using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercício 2 : Estruturas Condicionais - perguntas

            /*
             3. Guilherme é chefe do setor de T.I de sua empresa e precisa que você ajude-o a
            criar um programa usando a linguagem C# que receba os chamados dos usuários
            classificando e exibindo na tela o seu nível de urgência, sendo de 0-3 "BAIXO", 
            maior que 3 até 6 "MÉDIO", maior que 6 até 9 "ALTO", para os demais casos é 
            considerado "GRAVE".
             */

            Console.WriteLine("********* SISTEMA ABERTURA DE CHAMADOS (SAC v1.0) **********");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t\t0-3 BAIXO\n\t\t3-6 MÉDIO\n\t\t6-9 ALTO\n\t\t9 em diante GRAVE");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Digite o nível do seu chamado: ");

            int valor = Convert.ToInt32(Console.ReadLine());
           
            if (valor == 0 || valor == 1 || valor == 2 || valor == 3)
            {
                Console.Write("\nChamado nível " + valor + " = BAIXO");
            }
            else if (valor == 4 || valor == 5 || valor == 6)
            {
                Console.Write("\nChamado nível " + valor + " = MÉDIO");
            }
            else if (valor == 7 || valor == 8 || valor == 9)
            {
                Console.Write("\nChamado nível " + valor + " = ALTO");
            }
            else
            {
                Console.Write("\nChamado nível " + valor + " = GRAVE");
            }

            Console.ReadLine();
        }
    }
}

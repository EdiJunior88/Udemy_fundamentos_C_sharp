using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Switch
{
    enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Detelar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());

            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETE! DELE IMEDIATAMENTE!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar é muito bom!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }

            Console.ReadLine();
        }
    }
}

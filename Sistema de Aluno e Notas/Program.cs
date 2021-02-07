using System;

namespace Revisao
{

    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            Console.WriteLine("Bem Vindo ao Sistema de Notas !");
            do
            {
                
                Console.WriteLine("Escolha uma das opções abaixo para continuar :");
                opc();
                opt = Convert.ToInto32(Console.WriteLine());
                Console.WriteLine($"A opção Escolhida foi {opt}");

                switch (opt)
                {
                    case "1":
                        Console.WriteLine($"Escolheu a Opção de numero {opt}");
                        break;
                    case "2":
                        Console.WriteLine($"Escolheu a Opção de numero {opt}");
                        break;
                    case "3":
                        Console.WriteLine($"Escolheu a Opção de numero {opt}");
                        break;
                    case "4":
                        Console.WriteLine($"Escolheu a Opção de numero {opt}");
                        break;
                    default:
                        //throw new ArgumentNullException();
                        break;

                }   
            }while(opt != "5");
        }

        private static void opc()
        {
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Inserir Notas para Aluno");
            Console.WriteLine("3 - Deletar Aluno Cadastrado");
            Console.WriteLine("4 - Deletar Notas Colocada");
            Console.WriteLine("5 - SAIR");
        }
    }
}

using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá,por favor informe a quantidade de andares do elevador?");
            int qtdeAndares = int.Parse(Console.ReadLine());
            Console.WriteLine("Olá,por favor informe a capacidade de pessoas do elevador?");
            int capacidade = int.Parse(Console.ReadLine());

            var elevador = new Elevador(qtdeAndares, capacidade);
            bool continuar = true;
            do
            {

                Console.WriteLine(@"Escolha uma opção:
                 1 - Entrar  
                 2 - Sair 
                 3 - Finalizar Programa
                ");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();


                switch (opcaoEscolhida)
                {
                    case "1": elevador.Entrar(); break;
                    case "2": elevador.Sair(); break;
                    case "3": continuar = false; break;
                    default:
                        Console.WriteLine("Escolha não válida.");
                        break;
                }


            }
            while (continuar);
           

        }

    }
}


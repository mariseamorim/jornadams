using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public Elevador(int totalAndares, int capacidade)
        {
            TotalAndares = totalAndares;
            Capacidade = capacidade;
            AndarAtual = 0;

        }

        public int TotalAndares { get; set; }
        public int Capacidade { get; set; }
        public int AndarAtual { get; private set; }

        public int TotalPessoas { get; private set; }

        public void Entrar()
        {
            if (TotalPessoas >= Capacidade)
                Console.WriteLine("Aguarde!capacidade de pessoas já atingida");
            else
            {
                Console.WriteLine("Escolha o andar:");

                int andarEscolhido = int.Parse(Console.ReadLine());

                if (andarEscolhido < 0 || andarEscolhido > TotalAndares)
                    Console.WriteLine("Andar informado é inválido!");
                else
                {
                    if (andarEscolhido > AndarAtual && andarEscolhido <= TotalAndares)
                        Subir(andarEscolhido);
                    if (andarEscolhido < AndarAtual && andarEscolhido <= TotalAndares)
                        Descer(andarEscolhido);
                    if (AndarAtual == andarEscolhido)
                        Console.WriteLine("Você já está no andar escolhido!");


                    AndarAtual = andarEscolhido;
                }
            }



        }

        public void Sair()
        {
            if (TotalPessoas > 0)
            {
                TotalPessoas--;
                Console.WriteLine("Saindo....");
            }
            else
            {
                Console.WriteLine("Elevador vazio....");
            }

        }

        public void Subir(int andarEscolhido)
        {
            TotalPessoas++;
            Console.WriteLine("Subindo...");
            Thread.Sleep(1000);
            Console.WriteLine($"Chegamos ao andar {andarEscolhido}...");

        }
        public void Descer(int andarEscolhido)
        {
            TotalPessoas++;
            Console.WriteLine("Descendo...");
            Thread.Sleep(1000);
            if(andarEscolhido == 0)
                Console.WriteLine($"Chegamos ao andar térreo...");
            else
                Console.WriteLine($"Chegamos ao andar {andarEscolhido}...");
        }
    }
}

using System;
using ProjetoElevador.Models;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variável
            string op_2;

            //instanciando a classe
            Elevador AndarNovo = new Elevador();

            //andar atual
            Console.WriteLine("Insira o andar atual do elevador: \n");
            AndarNovo.Andar = int.Parse(Console.ReadLine());

            //total de andares
            Console.WriteLine("Insira o total de andares: ");
            AndarNovo.TotalAndares = int.Parse(Console.ReadLine());

            //capacidade total
            Console.WriteLine("Insira a capacidade total do elevador: ");
            AndarNovo.Capacidade = int.Parse(Console.ReadLine());

            //quantidade de pessoas
            Console.WriteLine("Insira a quantidade de pessoas presente no elevador: ");
            AndarNovo.QuantAtual = int.Parse(Console.ReadLine());

            //limpa a tela
            Console.Clear();

            do
            {
                //exibe as opções
                Console.WriteLine("Insira a opção desejada:\n1 - Inicializar\n2 - Entrar pessoa\n3 - Sair pessoa\n4 - Subir\n5-Descer\n");

                int op = int.Parse(Console.ReadLine());

                
                switch (op)
                {
                    case 1:
                        AndarNovo.Inicializar(AndarNovo.Capacidade, AndarNovo.TotalAndares);
                        break;
                    case 2:
                        AndarNovo.QuantAtual = AndarNovo.Entrar(AndarNovo.QuantAtual, AndarNovo.Capacidade);
                        break;
                    case 3:
                        AndarNovo.QuantAtual = AndarNovo.Sair(AndarNovo.QuantAtual);
                        break;
                    case 4:
                        AndarNovo.Andar = AndarNovo.Subir(AndarNovo.Andar, AndarNovo.TotalAndares);
                        break;
                    case 5:
                        AndarNovo.Andar = AndarNovo.Descer(AndarNovo.Andar);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Deseja realizar outra operação? (Sim/Não)");
                op_2 = Console.ReadLine();
                Console.Clear();
            } while (string.Compare(op_2,"Sim") == 0);
            //enquanto a segunda opção for igual a "Sim ele realiza as operações, caso contrário encerra a execução
        }
    }
}

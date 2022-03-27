using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    public class Elevador
    {
        //PROPRIEDADES
        //andar atual do elevador
        public int Andar { get; set; }
        //o total de andares
        public int TotalAndares { get; set; }
        //capacidade do elevador
        public int Capacidade { get; set; }
        //Quantidade de pessoas presentes no elevador atualmente
        public int QuantAtual { get; set; }

        //METODOS

        //Inicializar - exibe a capacidade e o total de andares do prédio
        public void Inicializar(int Capacidade, int TotalAndares)
        {
            Console.WriteLine("A capacidade total do elevador é {0} e o prédio possui {1} andares\n",Capacidade,TotalAndares);
        }

        //Entrar - Adiciona pessoas ao elevador
        public int Entrar(int pessoas, int capacidade)
        {
            //quantidade de pessoas que irão entrar
            Console.WriteLine("Insira quantas pessoas irão entrar no elevador");
            int entrar = int.Parse(Console.ReadLine());

            //caso a quantidade de pessoas que entra seja maior que a capacidade permitida
            if((entrar+pessoas) > capacidade)
            {
                Console.WriteLine("A quantidade de pessoas excede a capacidade do elevador\n");
            }

            //caso a quantiodade que entra seja menor que a capacidae permitida
            else if ((entrar + pessoas) < capacidade)
            {
                Console.WriteLine("Há {0} pessoas no elevador", entrar+pessoas);
            }

            return entrar + pessoas;

        }

        //Sair - remove pessoas do elevador
        public int Sair(int pessoas)
        {
            int sai = 0;
            //caso tenha pessoas no elevador
            if (pessoas != 0)
            {
                //quantas pessoas irão sair
                Console.WriteLine("Insira quantas pessoas irão sair: ");
                sai = int.Parse(Console.ReadLine());
                //se a quantidade de pessoas que sai for igual a quantidade de pessoas presentes no elevador
                if (sai >= pessoas) Console.WriteLine("Elevador vazio\n");
                //se a quantidade for menor que que a quantidade de pessoas presentes
                else if (sai < pessoas) Console.WriteLine("Há {0} pessoas no elevador", pessoas - sai);
            }
            //se não houver pessoas no elevador
            else Console.WriteLine("Não hà pessoas para sair do elevador\n");

            return pessoas - sai;
        }

        //Subir - adiciona andares ao andar atual
        public int Subir(int Andar, int TotalAndares)
        {
            int sobe;
            //enquanto os andares para subir forem maiores que o total de andares
            do
            {
                Console.WriteLine("Insira quantos andares o elevador irá subir: ");
                sobe = int.Parse(Console.ReadLine());

                if ((sobe + Andar) > TotalAndares) Console.WriteLine("Andar inválido");

            } while ((sobe + Andar) > TotalAndares);

            //se o andar for diferente do total de andares
            if ((sobe + Andar) < TotalAndares) Console.WriteLine("Andar atual: {0}º andar\n", sobe + Andar);
            //se for o ultimo andar está na cobertura
            else if ((sobe + Andar) == TotalAndares) Console.WriteLine("Andar atual: Cobertura");

            return sobe + Andar;
        }

        //Descer - remove um andar do andar total
        public int Descer(int Andar)
        {
            int desce = 0;
            //enquanto o andar for menor que 0
            do
            {
                Console.WriteLine("Insira quantos andares o elevador irá descer: ");
                desce = int.Parse(Console.ReadLine());

                if ((Andar - desce) < 0) Console.WriteLine("Andar inválido");
            } while ((Andar-desce) < 0);

            // se o andar for maior que 0
            if ((Andar - desce) > 0) Console.WriteLine("Andar atual: {0}º andar\n", Andar - desce);
            //se o andar for igual a 0
            else if ((Andar - desce) == 0) Console.WriteLine("Andar atual: Térreo");

            return Andar - desce;
        }
 

    }
}

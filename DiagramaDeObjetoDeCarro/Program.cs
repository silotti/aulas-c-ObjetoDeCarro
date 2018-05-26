using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeObjetoDeCarro
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<Acessorios> acessorios = new List<Acessorios>();

            Console.WriteLine("Digite a placa do veiculo: ");
            String placa = Console.ReadLine();
            Console.WriteLine("Digite o nome do veiculo: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite a cor do veiculo: ");
            String cor = Console.ReadLine();
            Console.WriteLine("Digite o tipo do veiculo: ");
            String tipo = Console.ReadLine();
            Console.WriteLine("Quantos acessoiros ele possui? ");
            int quantidade = int.Parse(Console.ReadLine());
           
            for(int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o nome do acessorio {0}: " , (i + 1));
                String nome1 = Console.ReadLine();
                Console.WriteLine("Digite o codigo do acessorio {0}: " , (i + 1));
                String codigo = Console.ReadLine();
                Acessorios acessorio = new Acessorios(nome1, codigo);
                acessorios.Add(acessorio);

            }

            Carro carro = new Carro(placa, nome, cor,tipo,acessorios);



            Console.WriteLine(carro);

            Console.ReadKey();





        }
    }
}

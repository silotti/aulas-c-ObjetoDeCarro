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

            Console.WriteLine("Placa do veiculo: ");
            String placa = Console.ReadLine();
            Console.WriteLine("Nome do veiculo: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Cor do veiculo: ");
            String cor = Console.ReadLine();
            Console.WriteLine("Tipo do veiculo: ");
            String tipo = Console.ReadLine();
            
                Console.WriteLine("Nome do acessorio : " );
                String nome1 = Console.ReadLine();
                Console.WriteLine("Codigo do acessorio : ");
                String codigo = Console.ReadLine();
                Acessorios acessorio = new Acessorios(nome1, codigo);
                acessorios.Add(acessorio);

   
            Carro carro = new Carro(placa, nome, cor,tipo,acessorios);

            Console.WriteLine(carro);

            Console.ReadKey();


        }
    }
}

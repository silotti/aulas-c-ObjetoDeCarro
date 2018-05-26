using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeObjetoDeCarro
{
    class  Carro
    {
        public String placa { get; set; }

        public String nome { get; set; }

        public String cor { get; set; }

        public String tipo { get; set; }

        public List<Acessorios> acessorios = new List<Acessorios>();

        public Carro(String placa,String nome,String cor, String tipo, List<Acessorios> acessorios)
        {
            this.placa = placa;
            this.nome = nome;
            this.cor = cor;
            this.tipo = tipo;
            this.acessorios = acessorios;
        }

        public override string ToString()
        {
            String result = "Placa: " + this.placa + "\nNome: " + this.nome + "\nCor: " + this.cor + "\nTipo: " + this.tipo + "\nAcessorios: \n\n   ";
            this.acessorios.ForEach(s => result+= s.nome + "\n   " + s.codigo + "\n   ");
            
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaDeObjetoDeCarro
{
    class Acessorios
    {
        public String nome { get; set; }

        public String codigo { get; set; }

        public Acessorios(String nome , String codigo)
        {
            this.nome = nome;
            this.codigo = codigo;

        }

        public override string ToString()
        {
            return "\nNome: " + this.nome + "\nCodigo: " + this.codigo;
        }
    }
}

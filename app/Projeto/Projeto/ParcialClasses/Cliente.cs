using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Cliente : Pessoa
    {
        public Cliente(string nome, string telemovel, string nif)
        {
            this.Nome = nome;
            this.Telemovel = telemovel;
            this.NumContribuinte = nif;
            this.TotalGasto = 0D;
            this.Pedido = new HashSet<Pedido>();
        }

        public override string ToString()
        {
            return $"{Nome} - {Telemovel} - ({NumContribuinte})";
        }
    }
}

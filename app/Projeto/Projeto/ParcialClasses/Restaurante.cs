using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Restaurante
    {
        public Restaurante(string nome)
        {
            this.Nome = nome;
            this.Trabalhador = new HashSet<Trabalhador>();
            this.ItemMenu = new HashSet<ItemMenu>();
            this.Pedido = new HashSet<Pedido>();
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}

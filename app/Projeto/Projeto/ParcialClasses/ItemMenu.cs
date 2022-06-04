using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class ItemMenu
    {
        public ItemMenu(string nome, double preco, string ingredientes, string estado, string fotografia)
        {
            this.Restaurante = new HashSet<Restaurante>();
            this.Pedido = new HashSet<Pedido>();
            this.Nome = nome;
            this.Preco = preco;
            this.Ingredientes = ingredientes;
            this.Ativo = estado;
            this.Fotografia = fotografia;
        }

        public override string ToString()
        {
            return $"{Nome} - {Preco}€";
        }
    }
}

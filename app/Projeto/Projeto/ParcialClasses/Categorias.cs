using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    using System;
    using System.Collections.Generic;

    public partial class Categoria
    {
        public Categoria(string nome)
        {
            this.Nome = nome;
            this.Ativo = "Ativo";
            this.ItemMenu = new HashSet<ItemMenu>();
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}

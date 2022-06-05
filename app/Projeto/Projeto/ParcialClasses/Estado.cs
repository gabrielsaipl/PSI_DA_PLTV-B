using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Estado
    {
        public Estado(string estadoo)
        {
            this.Pedido = new HashSet<Pedido>();
            this.Estadoo = estadoo;
        }

        public override string ToString()
        {
            return $"{Estadoo}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class MetodoPagamento
    {
        public MetodoPagamento(string metodopagamento)
        {
            this.MetodoPagament = metodopagamento;
            this.Ativo = "Ativo";
            this.Pagamento = new HashSet<Pagamento>();

        }
        public override string ToString()
        {
            return $"{MetodoPagament}";
        }
    }

}

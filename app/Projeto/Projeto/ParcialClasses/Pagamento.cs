using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Pagamento
    {
        public Pagamento() { }
        
        public Pagamento(double valor)
        {
            this.Valor = valor;
        }

        public override string ToString()
        {
            return $"{Valor}€ - {MetodoPagamento.MetodoPagament}";
        }
    }
}

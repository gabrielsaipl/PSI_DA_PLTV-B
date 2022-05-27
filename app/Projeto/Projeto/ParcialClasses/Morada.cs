using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Morada
    {
        public Morada() { }
        public Morada(string pais, string cidade, string codPostal, string rua)
        {
            this.Pais = pais;
            this.Cidade = cidade;
            this.CodPostal = codPostal;
            this.Rua = rua;
        }

        public override string ToString()
        {
            return $"{Pais} - {Cidade} - {CodPostal} - {Rua}";
        }
    }
}

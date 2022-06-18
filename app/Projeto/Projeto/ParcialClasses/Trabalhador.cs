using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Trabalhador : Pessoa
    {
        public Trabalhador(string nome, string telemovel, double salario, string posicao)
        {
            this.Pedido = new HashSet<Pedido>();
            this.Ativo = true;
            this.Nome = nome;
            this.Telemovel = telemovel;
            this.Salario = salario;
            this.Posicao = posicao;
        }
        
        /// <summary>
        /// Escreve se o trabalhador está em serviço ou fora de serviço
        /// </summary>
        public string estado()
        {
            if (this.Ativo) return "Em serviço";
            else return "Fora de serviço";
        }

        public override string ToString()
        {
            return $"{Nome} - {Telemovel} - {Posicao}";
        }
    }
}

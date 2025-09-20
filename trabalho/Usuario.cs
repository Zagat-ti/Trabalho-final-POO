using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_Geladeira
{
    public class Usuario
    {
        protected string nome;
        protected string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public Usuario()
        {
        }

        public Usuario(string nome, string telefone)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome é obrigatório!!!");
            }

            if (string.IsNullOrEmpty(telefone))
            {
                throw new ArgumentException("O número é obrigatório!!!");
            }

            this.Nome = nome;
            this.Telefone = telefone;
        }


    }
}

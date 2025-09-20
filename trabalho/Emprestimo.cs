using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_Geladeira
{
    public class Emprestimo 
    {
        protected string item;
        protected string quantidade;
        protected string telefone;
        protected string dono;

        public string Item { get => item; set => item = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Dono { get => dono; set => dono = value; }

        public Emprestimo() { }
        public Emprestimo(string item, string quantidade, string telefone, string dono)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("O item é obrigatório!!!");
            }

            if (string.IsNullOrEmpty(quantidade))
            {
                throw new ArgumentException("O número é obrigatório!!!");
            }

            if (string.IsNullOrEmpty(telefone))
            {
                throw new ArgumentException("O número do usuário é obrigatório!!!");
            }

            if (string.IsNullOrEmpty(dono))
            {
                throw new ArgumentException("O dono do item é obrigatório!!!");
            }

            this.Item = item;
            this.Quantidade = quantidade;
            this.Telefone = telefone;
            this.Dono = dono;

        }


    }
}

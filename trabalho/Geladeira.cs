using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Trabalho_Final_Geladeira
{

    public class Geladeira 
    {
        protected string item;
        protected string quantidade;
        protected string localizacao;

        public string Item { get => item; set => item = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }

        public Geladeira() { }
        public Geladeira(string item, string quantidade, string localizacao) 
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("O item é obrigatório!!!");
            }

            if (string.IsNullOrEmpty(quantidade))
            {
                throw new ArgumentException("O número é obrigatório!!!");
            }
            this.Item = item;
            this.Quantidade = quantidade;
            this.Localizacao = localizacao;
        }
    }
}

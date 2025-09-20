using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Final_Geladeira;
using Trabalho_Final_Geladeira.infra;

namespace trabalho.infra
{
    internal class GeladeiraRepo
    {
        public bool Add(Geladeira geladeira)
        {


            var conn = new DbConnection();

            string query = @"INSERT INTO public.geladeira(
	                        item, quantidade, localizacao)
	                        VALUES (@item, @quantidade, @localizacao);";

            var result = conn.Connection.Execute(sql: query, param: geladeira);

            MessageBox.Show("Item cadastrado com sucesso!");
            conn.Dispose();
            return result == 1;

        }

        public bool Update(Geladeira geladeira)
        {
            using (var conn = new DbConnection())
            {
                string query = @"UPDATE public.geladeira
                         SET quantidade = @quantidade, localizacao = @localizacao
                         WHERE item = @item;";

                var result = conn.Connection.Execute(query, geladeira);

                return result == 1; 
            }
        }

        public bool Delete(string item)
        {
            using (var conn = new DbConnection())
            {
                string query = @"DELETE FROM public.geladeira WHERE item = @item;";
                var result = conn.Connection.Execute(query, new { Item = item });
                return result == 1; 
            }
        }



        public List<Geladeira> Get()
        {


            var conn = new DbConnection();

            string query = @"SELECT * FROM geladeira;";

            var geladeira = conn.Connection.Query<Geladeira>(sql: query);

            conn.Dispose();
            return geladeira.ToList();
        }


    }

}


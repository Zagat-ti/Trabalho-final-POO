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
    internal class EmprestimoRepo
    {

        public bool Add(Emprestimo emprestimos)
        {


            var conn = new DbConnection();

            string query = @"INSERT INTO public.emprestimos(
	                        Item, Quantidade, Telefone, Dono)
	                        VALUES (@Item, @Quantidade, @Telefone, @Dono);";

            var result = conn.Connection.Execute(sql: query, param: emprestimos);

            MessageBox.Show("Empréstimo cadastrado com sucesso!");
            conn.Dispose();
            return result == 1;
            
        }

        public bool Update(Emprestimo emprestimo)
        {
            using (var conn = new DbConnection())
            {
                string query = @"UPDATE public.emprestimos
                         SET quantidade = @quantidade, dono = @dono,
                         item = @item WHERE telefone = @telefone;";

                var result = conn.Connection.Execute(query, emprestimo);

                return result == 1; 
            }
        }

        public bool Delete(string item)
        {
            using (var conn = new DbConnection())
            {
                string query = @"DELETE FROM public.emprestimos WHERE item = @item ";
                var result = conn.Connection.Execute(query, new { Item = item });
                return result == 1; 
            }
        }


        public List<Emprestimo> Get()
        {


            var conn = new DbConnection();

            string query = @"SELECT * FROM emprestimos;";

            var emprestimos= conn.Connection.Query<Emprestimo>(sql: query);

            conn.Dispose();
            return emprestimos.ToList();
        }

    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_Geladeira.infra
{
    internal class UsuarioRepo
    {
        public bool Add(Usuario usuario)
        {

            
            var conn = new DbConnection();
                
            string query = @"INSERT INTO public.usuarios(
	                        nome, telefone)
	                        VALUES (@nome, @telefone);";

            var result = conn.Connection.Execute(sql: query, param: usuario);

            MessageBox.Show("Usuário cadastrado com sucesso!");
            conn.Dispose();
            return result == 1;

        }

        public bool Update(Usuario usuario)
        {
            using (var conn = new DbConnection())
            {
                string query = @"UPDATE public.usuarios SET telefone = @Telefone WHERE nome = @Nome;";

                
                var result = conn.Connection.Execute(query, usuario);

                return result == 1; 
            }
        }

        public bool Delete(string telefone)
        {
            using (var conn = new DbConnection())
            {
                string query = @"DELETE FROM public.usuarios WHERE telefone = @telefone;";

                
                var result = conn.Connection.Execute(query, new { Telefone= telefone });

                return result == 1; 
            }
        }

        public List<Usuario> Get()
        {
           

            var conn = new DbConnection();

            string query = @"SELECT * FROM usuarios;";

            var usuario = conn.Connection.Query<Usuario>(sql: query);

            conn.Dispose();
            return usuario.ToList();
        }


    }
}

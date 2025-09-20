using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho.infra;
using Trabalho_Final_Geladeira;
using Trabalho_Final_Geladeira.infra;

namespace trabalho
{
    public partial class Form1 : Form
    {
        public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();
        public List<Geladeira> Geladeiras { get; private set; } = new List<Geladeira>();
        public List<Emprestimo> Emprestimos { get; private set; } = new List<Emprestimo>();


        public Form1()
        {
            InitializeComponent();
            lbLocNum.Visible = false;
            cbLoc.Visible = false;
            tbSeuNum.Visible = false;
            lbDon.Visible = false;
            tbDon.Visible = false;
            btRel.Visible = true;
            tbNumQtd.Visible = false;
            cbLoc.Text = "Selecione uma opção abaixo";
            mtbNumE.Visible = false;
            ObterUsuarios();
            ObterGeladeira();
            ObterEmprestimos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarGeladeira();
            CarregarEmprestimos();
        }

        private void CarregarUsuarios()
        {
           
            lv_Usu.Items.Clear();

            var repository = new UsuarioRepo();
            var listaDeUsuarios = repository.Get(); 

            foreach (var usuario in listaDeUsuarios)
            {
               
                var item = new ListViewItem(new string[] { usuario.Nome, usuario.Telefone});
                lv_Usu.Items.Add(item);
            }
        }

        private void CarregarGeladeira()
        {
            
            lv_Gel.Items.Clear();

            var repository = new GeladeiraRepo();
            var listaDeItens = repository.Get();

            foreach (var geladeira in listaDeItens)
            {
                var item = new ListViewItem(new string[] { geladeira.Item, geladeira.Quantidade, geladeira.Localizacao });
                lv_Gel.Items.Add(item);
            }
        }

        private void CarregarEmprestimos()
        {
            
            lv_Emp.Items.Clear();

            var repository = new EmprestimoRepo();
            var listaDeEmprestimos = repository.Get();

            foreach (var emprestimo in listaDeEmprestimos)
            {
                var item = new ListViewItem(new string[] { emprestimo.Item, emprestimo.Quantidade, emprestimo.Telefone });
                lv_Emp.Items.Add(item);
            }
        }

        private void ObterEmprestimos()
        {
            var repository = new EmprestimoRepo();
            Emprestimos = repository.Get();
            foreach (var emprestimo in Emprestimos)
            {
                lv_Emp.Items.Add(new ListViewItem(new string[] { emprestimo.Item, emprestimo.Quantidade, emprestimo.Telefone, emprestimo.Dono }));
            }
        }

        private void ObterGeladeira()
        {
            var repository = new GeladeiraRepo();
            Geladeiras = repository.Get();
            foreach (var geladeira in Geladeiras)
            {
                lv_Gel.Items.Add(new ListViewItem(new string[] { geladeira.Item, geladeira.Quantidade, geladeira.Localizacao }));
            }
        }
        private void ObterUsuarios()
        {
            var repository = new UsuarioRepo();
            Usuarios = repository.Get();
            foreach (var usuario in Usuarios)
            {
                lv_Usu.Items.Add(new ListViewItem(new string[] { usuario.Nome, usuario.Telefone }));
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            lbNomIte.Text = "Nome";
            lbNumQtd.Text = "Telefone";
            mtbNumU.Mask = "(00) 00000-0000";
            lbLocNum.Visible = false;
            mtbNumU.Visible = true;
            mtbNumE.Visible = false;
            cbLoc.Visible = false;
            tbSeuNum.Visible = false;
            lbDon.Visible = false;
            tbDon.Visible = false;
            btRel.Visible = true;
            tbNumQtd.Visible = false;
        }

        private void rbGeladeira_CheckedChanged(object sender, EventArgs e)
        {
            lbNomIte.Text = "Item";
            lbNumQtd.Text = "Quantidade";
            lbLocNum.Text = "Localização";

            lbLocNum.Visible = true;
            cbLoc.Visible = true;
            tbSeuNum.Visible = false;
            lbDon.Visible = false;
            tbDon.Visible = false;
            btRel.Visible = true;
            tbNumQtd.Visible = true;
            mtbNumE.Visible = false;
            mtbNumU.Visible = false;
        }

        private void rbEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            lbNomIte.Text = "Item";
            lbNumQtd.Text = "Quantidade";
            lbLocNum.Text = "Seu Número";
            lbLocNum.Visible = true;
            mtbNumE.Mask = "(00) 00000-0000";
            cbLoc.Visible = false;
            tbSeuNum.Visible = true;
            lbDon.Visible = true;
            tbDon.Visible = true;
            btRel.Visible = true;
            tbNumQtd.Visible = true;
            mtbNumU.Visible = false;
            mtbNumE.Visible = true;
            tbSeuNum.Visible = false;
        }

        private void btGra_Click(object sender, EventArgs e)
        {
            if (rbUsuario.Checked)
            {

                try
                {
                    var nome = tbNomIte.Text;
                    var telefone = mtbNumU.Text;

                    foreach (var item in Usuarios)
                    {
                        if (item.Nome == nome || item.Telefone== telefone)
                        {
                            MessageBox.Show("Usuário já cadastrado!");
                            return;
                        }
                    }

                    var usuario = new Usuario(nome, telefone);
                    Usuarios.Add(usuario);

                    var repository = new UsuarioRepo();
                    repository.Add(usuario);

                    lv_Usu.Items.Add(new ListViewItem(new string[] { usuario.Nome, usuario.Telefone }));

                    tbNomIte.Clear();
                    mtbNumE.Clear();
                    mtbNumU.Clear();
                    tbNumQtd.Clear();
                    tbSeuNum.Clear();
                    tbDon.Clear();
                    cbLoc.Text = "Selecione uma opção abaixo";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            if (rbGeladeira.Checked)
            {
                try
                {
                    var item = tbNomIte.Text;
                    var quantidade = tbNumQtd.Text;
                    var localizacao = cbLoc.Text;

                    if (string.IsNullOrEmpty(item))
                    {
                        MessageBox.Show("O nome do item é obrigatório!!!");
                        return;
                    }

                    if (string.IsNullOrEmpty(localizacao) || localizacao == "Selecione uma opção abaixo")
                    {
                        MessageBox.Show("A localização é obrigatória!!!");
                        return;
                    }

                    var geladeira = new Geladeira(item, quantidade, localizacao);

                    var repository = new GeladeiraRepo();
                    repository.Add(geladeira);

                    lv_Gel.Items.Add(new ListViewItem(new string[] { geladeira.Item, geladeira.Quantidade, geladeira.Localizacao }));


                    tbNomIte.Clear();
                    tbNumQtd.Clear();
                    tbSeuNum.Clear();
                    mtbNumE.Clear();
                    mtbNumU.Clear();
                    tbDon.Clear();
                    cbLoc.Text = "Selecione uma opção abaixo";
                }
                catch (FormatException)
                {
                    MessageBox.Show("A quantidade deve ser um número válido!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (rbEmprestimo.Checked)
            {
                try
                {
                    var item = tbNomIte.Text;
                    var quantidade = tbNumQtd.Text;
                    var telefone = mtbNumE.Text;
                    var dono = tbDon.Text;
                    if (string.IsNullOrEmpty(item))
                    {
                        MessageBox.Show("O nome do item é obrigatório!!!");
                        return;
                    }
                    if (string.IsNullOrEmpty(telefone) || telefone == "(  )      -")
                    {
                        MessageBox.Show("Seu número é obrigatório!!!");
                        return;
                    }
                    if (string.IsNullOrEmpty(dono))
                    {
                        MessageBox.Show("O número do dono é obrigatório!!!");
                        return;
                    }
                    var emprestimo = new Emprestimo(item, quantidade, telefone, dono);

                    var repository = new EmprestimoRepo();
                    repository.Add(emprestimo);

                    lv_Emp.Items.Add(new ListViewItem(new string[] { emprestimo.Item, emprestimo.Quantidade, emprestimo.Telefone, emprestimo.Dono }));


                    tbNomIte.Clear();
                    tbNumQtd.Clear();
                    tbSeuNum.Clear();
                    mtbNumE.Clear();
                    mtbNumU.Clear();
                    tbDon.Clear();
                    cbLoc.Text = "Selecione uma opção abaixo";
                }
                catch (FormatException)
                {
                    MessageBox.Show("A quantidade deve ser um número válido!!!");
                }
                catch (Exception ex)
                {
                        MessageBox.Show(ex.Message);  

                }
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (rbUsuario.Checked)
            {
                try
                {
                    var telefone = mtbNumU.Text; 

                    var repository = new UsuarioRepo();

                    if (repository.Delete(telefone))
                    {
                        CarregarUsuarios();
                        MessageBox.Show("Usuário deletado com sucesso!");
                        tbNomIte.Clear();
                        tbNumQtd.Clear();
                        tbSeuNum.Clear();
                        mtbNumE.Clear();
                        mtbNumU.Clear();
                        tbDon.Clear();
                        cbLoc.Text = "Selecione uma opção abaixo";
                    }
                    else
                    {
                        MessageBox.Show("Falha ao deletar o usuário. Verifique se o número existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            if (rbGeladeira.Checked)
            {
                try
                {
                    var item = tbNomIte.Text; 
                    var repository = new GeladeiraRepo();
                    if (repository.Delete(item))
                    {
                        CarregarGeladeira();
                        MessageBox.Show("Item da geladeira deletado com sucesso!");
                        tbNomIte.Clear();
                        tbNumQtd.Clear();
                        tbSeuNum.Clear();
                        mtbNumE.Clear();
                        mtbNumU.Clear();
                        tbDon.Clear();
                        cbLoc.Text = "Selecione uma opção abaixo";
                    }
                    else
                    {
                        MessageBox.Show("Falha ao deletar o item. Verifique se o item existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    
                }
            }
            if (rbEmprestimo.Checked)
            {
                try
                {
                    var item = tbNomIte.Text;
                    var quantidade = tbNumQtd.Text;
                    var repository = new EmprestimoRepo();
                    if (repository.Delete(item))
                    {
                        CarregarEmprestimos();
                        MessageBox.Show("Empréstimo deletado com sucesso!");
                        tbNomIte.Clear();
                        tbNumQtd.Clear();
                        tbSeuNum.Clear();
                        mtbNumE.Clear();
                        mtbNumU.Clear();
                        tbDon.Clear();
                        cbLoc.Text = "Selecione uma opção abaixo";
                    }
                    else
                    {
                        MessageBox.Show("Falha ao deletar o empréstimo. Verifique se o item e a quantidade existem.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btAtt_Click(object sender, EventArgs e)
        {
            if (rbUsuario.Checked)
            {

                try
                {
                    var nome = tbNomIte.Text;
                    var telefone = mtbNumU.Text;

                    var usuarioParaAtualizar = new Usuario(nome, telefone);
                    var repository = new UsuarioRepo();

                    if (repository.Update(usuarioParaAtualizar))
                    {
                        CarregarUsuarios();
                        tbNomIte.Clear();
                        tbNumQtd.Clear();
                        tbSeuNum.Clear();
                        mtbNumE.Clear();
                        mtbNumU.Clear();
                        tbDon.Clear();
                        cbLoc.Text = "Selecione uma opção abaixo";
                        MessageBox.Show("Usuário atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o usuário. Verifique se o número existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }
            if (rbGeladeira.Checked)
            {
                try
                {
                    var item = tbNomIte.Text;
                    var quantidade = tbNumQtd.Text;
                    var localizacao = cbLoc.Text;

                    
                    var geladeiraParaAtualizar = new Geladeira(item, quantidade, localizacao);
                    var repository = new GeladeiraRepo();

                    if (repository.Update(geladeiraParaAtualizar))
                    {
                        CarregarGeladeira();
                        tbNomIte.Clear();
                        tbNumQtd.Clear();
                        tbSeuNum.Clear();
                        mtbNumE.Clear();
                        mtbNumU.Clear();
                        tbDon.Clear();
                        cbLoc.Text = "Selecione uma opção abaixo";
                        MessageBox.Show("Item da geladeira atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o item. Verifique se o item existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            if (rbEmprestimo.Checked)
            {
                try
                {
                    var item = tbNomIte.Text;
                    var quantidade = tbNumQtd.Text;
                    var telefone = mtbNumE.Text;
                    var dono = tbDon.Text;
                    
                    var emprestimoParaAtualizar = new Emprestimo(item, quantidade, telefone, dono);
                    var repository = new EmprestimoRepo();
                    if (repository.Update(emprestimoParaAtualizar))
                    {
                        CarregarEmprestimos();
                        tbNomIte.Clear();
                        tbNumQtd.Clear();
                        tbSeuNum.Clear();
                        mtbNumE.Clear();
                        mtbNumU.Clear();
                        tbDon.Clear();
                        cbLoc.Text = "Selecione uma opção abaixo";
                        MessageBox.Show("Empréstimo atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o empréstimo. Verifique se o item e a quantidade existem.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btRel_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarGeladeira();
            CarregarEmprestimos();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


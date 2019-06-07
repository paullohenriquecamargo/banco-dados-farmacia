using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProdutosHigienicoRepositorio
    {
        string CadeiadeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65982\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<ProdutosHigienico> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtos_higienicos";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<ProdutosHigienico> produtosHigienicos = new List<ProdutosHigienico>();

            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];

                ProdutosHigienico produtosHigienico = new ProdutosHigienico();
                produtosHigienico.Id = Convert.ToInt32(linha["id"]);
                produtosHigienico.Nome = linha["nome"].ToString();
                produtosHigienico.Categoria = linha["categoria"].ToString();
                produtosHigienicos.Add(produtosHigienico);

            }
            conexao.Close();
            return produtosHigienicos;

        }
        public ProdutosHigienico ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM produtos_higienicos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if(dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                ProdutosHigienico produtosHigienico = new ProdutosHigienico();
                produtosHigienico.Id = Convert.ToInt32(linha["id"]);
                produtosHigienico.Nome = linha["nome"].ToString();
                produtosHigienico.Categoria = linha["categoria"].ToString();

                return produtosHigienico;
            }
            return null;
        }
        public void Inserir(ProdutosHigienico produtosHigienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produtos_higienicos (nome,categoria) VALUES (@NOME, @CATEGORIA)";
            comando.Parameters.AddWithValue("@NOME", produtosHigienico.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", produtosHigienico.Categoria);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public void Apagar(int id){
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM produtos_higienicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Atualizar(ProdutosHigienico produtosHigienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE produtos_higienicos SET 
nome = @NOME,
categoria = @CATEGORIA
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produtosHigienico.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", produtosHigienico.Categoria);
            comando.Parameters.AddWithValue("@ID", produtosHigienico.Id);
            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
}

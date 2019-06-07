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
    public class CosmeticoRepositorio
    {
        string CadeiadeConexao = @"";
        
        public List<Cosmetico> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM cosmeticos";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Cosmetico> cosmeticos = new List<Cosmetico>();

            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Cosmetico cosmetico = new Cosmetico();
                cosmetico.Id = Convert.ToInt32(linha["id"]);
                cosmetico.Nome = linha["nome"].ToString();
                cosmetico.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                cosmetico.Quantidade = Convert.ToInt32(linha["quantidade"]);
                cosmetico.Marca = linha["marca"].ToString();
                cosmetico.Valor = Convert.ToDecimal(linha["valor"]);

                cosmeticos.Add(cosmetico);                    
            }
            conexao.Close();
            return cosmeticos;
        }
        public Cosmetico ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM cosmeticos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if(dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                Cosmetico cosmetico = new Cosmetico();
                cosmetico.Id = Convert.ToInt32(linha["id"]);
                cosmetico.Nome = linha["nome"].ToString();
                cosmetico.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                cosmetico.Quantidade = Convert.ToInt32(linha["quantidade"]);
                cosmetico.Marca = linha["marca"].ToString();
                cosmetico.Valor = Convert.ToDecimal(linha["valor"]);


                return cosmetico;
            }
            return null;
        }
        public void Inserir(Cosmetico cosmetico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO cosmeticos (nome, data_vencimento, quantidade , marca, valor) 
VALUES (@NOME, @DATA_VENCIMENTO, @QUANTIDADE, @MARCA)";
            comando.Parameters.AddWithValue("@NOME", cosmetico.Nome);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", cosmetico.DataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", cosmetico.Quantidade);
            comando.Parameters.AddWithValue("@MARCA", cosmetico.Marca);
            comando.Parameters.AddWithValue("@VALOR", cosmetico.Valor);

            comando.ExecuteNonQuery();
            conexao.Close();

        }
        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM cosmeticos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Atualizar(Cosmetico cosmetico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE cosmeticos SET
nome = @NOME,
data_vencimento = @DATA_VENCIMENTO,
quantidade = @QUANTIDADE,
marca = @MARCA,
valor = @VALOR
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", cosmetico.Nome);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", cosmetico.DataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", cosmetico.Quantidade);
            comando.Parameters.AddWithValue("@MARCA", cosmetico.Marca);
            comando.Parameters.AddWithValue("@VALOR", cosmetico.Valor);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}

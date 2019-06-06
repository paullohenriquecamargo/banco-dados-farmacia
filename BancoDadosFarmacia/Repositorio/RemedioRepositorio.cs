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
    public class RemedioRepositorio
    {
        string CadeiadeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65982\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        /*Método que irá retornar os dados 
         * dos remédios (List<Remedio>) da tabela remedios
         */

        public List<Remedio> ObterTodos()
        {

            //Cria a conexao com o banco de dados

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            // Cria o comando para ser executado no bd
            //e diz para este comando qual é a conexao que esta 
            //aberta 

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios";

            //Cira a tabela em memória para poder obter
            //os dados que são retornados do bd executando
            // o comando no bd

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            //Cria uma lista de remedios para adicionar os remedios no bd 

            List<Remedio> remedios = new List<Remedio>();

            //Percorre todos os registros lidos do bd 

            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                //Cria um objeto com as informações
                //obtidas no bd
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["eh_generico"]);
                remedio.Categoria = linha["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["eh_solido"]);
                remedio.ContraIndicacoes = linha["contra_indicacoes"].ToString();
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(linha["precisa_receita"]);
                // Adiciona o objeto que foi criado a lista de filmes
                remedios.Add(remedio);
                
            }
            //Fecha a conexao do bd 
            conexao.Close();
            // Retorna a lista de filmes 
            return remedios;
        }

        public Remedio ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM remedios WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if (dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["eh_generico"]);
                remedio.Categoria = linha["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["eh_solido"]);
                remedio.ContraIndicacoes = linha["contra_indicacoes"].ToString();
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(linha["precisa_receita"]);

                return remedio;
            }
            return null;
        }

        public void Inserir(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO remedios (nome, eh_generico, categoria, eh_solido, contra_indicacoes, bula, faixa, precisa_receita)" +
                " VALUES (@NOME, @EH_GENERICO, @CATEGORIA, @EH_SOLIDO, @CONTRA_INDICACOES, @BULA, @FAIXA, @PRECISA_RECEITA)";

            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@EH_GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@EH_SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@CONTRA_INDICACOES", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@PRECISA_RECEITA", remedio.PrecisaReceita);

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
            comando.CommandText = "DELETE FROM remedios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void Atualizar(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiadeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE remedios SET 
nome = @NOME,
eh_generico = @EH_GENERICO,
categoria = @CATEGORIA,
eh_solido = @EH_SOLIDO,
contra_indicacoes = @CONTRA_INDICACOES,
bula = @BULA,
faixa = @FAIXA,
precisa_receita = @PRECISA_RECEITA
WHERE id = @ID";
            
            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@EH_GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);    
            comando.Parameters.AddWithValue("@EH_SOLIDO", remedio.Solido);
            comando.Parameters.AddWithValue("@CONTRA_INDICACOES", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@PRECISA_RECEITA", remedio.PrecisaReceita);
            comando.Parameters.AddWithValue("@ID", remedio.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}

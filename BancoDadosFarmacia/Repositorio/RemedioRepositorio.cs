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

    }
}

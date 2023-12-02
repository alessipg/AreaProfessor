using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Cmce;

namespace AreaProfessor
{
    internal class AreaProfessorDAO
    {
        private MySqlConnection connection;
        private List<Pontuacao> pontuacoes;
        private string data_source = "datasource=localhost;username=root;password=;database=jogo";
        public AreaProfessorDAO()
        {

        }

        public List<Pontuacao> buscarTodos()
        {
            pontuacoes = new List<Pontuacao>();
            try
            {
                connection = new MySqlConnection(data_source);
                string sql = "SELECT * FROM PONTUACAO";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pontuacao pontuacao = new Pontuacao
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Fase1 = reader.GetInt32(2),
                        Fase2 = reader.GetInt32(3),
                        Data = reader.GetString(5).Substring(0,10),
                        Tempo = reader.GetString(4).Substring(3),
                        Obs = reader.GetString(6),

                    };
                    // Converter o tempo para segundos
                    int tempo = int.Parse(pontuacao.Tempo.Substring(0, 2)) * 60 + int.Parse(pontuacao.Tempo.Substring(3, 2));

                    // Definir pesos para as fases e tempo
                    double pesoFase1 = 0.4; // 40%
                    double pesoFase2 = 0.4; // 40%
                    double pesoTempo = 0.2; // 20%

                    // Calcular pontuação parcial para cada componente
                    double pontuacaoFase1 = pontuacao.Fase1 * pesoFase1;
                    double pontuacaoFase2 = pontuacao.Fase2 * pesoFase2;

                    // Normalizar o tempo para atingir 100 pontos para 10 minutos (600 segundos)
                    double pontuacaoTempo = (Math.Max(0,600-tempo) *0.2)* pesoTempo; // Normalização invertida

                    // Calcular pontuação final
                    double pontuacaoFinal = pontuacaoFase1 + pontuacaoFase2 + pontuacaoTempo;

                    // Garantir que a pontuação final esteja no intervalo de 0 a 100
                    pontuacaoFinal = (int)Math.Max(0, Math.Min(100, pontuacaoFinal));

                    // Atribuir a pontuação final
                    pontuacao.Total = pontuacaoFinal.ToString();

                    pontuacoes.Add(pontuacao);
                }
            }
            catch (Exception ex)
            {
                throw new DBException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return pontuacoes;
        }
        public void cadastrar(Pontuacao pontuacao)
        {
            try
            {
                connection = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();
                connection.Open();
                cmd.Connection = connection;

                // Converter a string de data para o formato correto
                DateTime dataConvertida = DateTime.ParseExact(pontuacao.Data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                cmd.CommandText = "INSERT INTO PONTUACAO (nome_aluno, fase1, fase2, tempo, data, obs) VALUES(@nome, @fase1, @fase2, @tempo, @data, @obs)";
                cmd.Parameters.AddWithValue("@nome", pontuacao.Nome);
                cmd.Parameters.AddWithValue("@fase1", pontuacao.Fase1);
                cmd.Parameters.AddWithValue("@fase2", pontuacao.Fase2);
                cmd.Parameters.AddWithValue("@tempo", pontuacao.Tempo);
                cmd.Parameters.AddWithValue("@data", dataConvertida.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@obs", pontuacao.Obs);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void excluir(int id)
        {
            try
            {
                connection = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "DELETE FROM pontuacao WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void editar(Pontuacao pontuacao)
        {
            try
            {
                connection = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();
                connection.Open();
                cmd.Connection = connection;
                // Converter a string de data para o formato correto
                DateTime dataConvertida = DateTime.ParseExact(pontuacao.Data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                cmd.CommandText = "UPDATE pontuacao SET nome_aluno = @nome,fase1=@fase1,fase2=@fase2,tempo=@tempo,data=@data,obs=@obs WHERE id = @id";
                cmd.Parameters.AddWithValue("@nome", pontuacao.Nome);
                cmd.Parameters.AddWithValue("@fase1", pontuacao.Fase1);
                cmd.Parameters.AddWithValue("@fase2", pontuacao.Fase2);
                cmd.Parameters.AddWithValue("@tempo", pontuacao.Tempo);
                cmd.Parameters.AddWithValue("@data", dataConvertida.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@obs", pontuacao.Obs);
                cmd.Parameters.AddWithValue("@id", pontuacao.Id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
    internal class DBException : Exception
    {
        public DBException(string message) : base(message)
        {
        }
    }
}


using HopeBus.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class PassagemViagemMySql : MySqlBase
    {
        public void InserirRelacao(int idPassagem, int idViagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO passagem_viagem(id_passagem,id_viagem)" +
                "VALUES @id_passagem, @id_viagem;");

                comando.Parameters.Add("id_passagem", idPassagem);
                comando.Parameters.Add("id_viagem", idViagem);

                comando.Connection = conexao;
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                finally
                {
                    comando.Connection.Close();
                }
            }
        }

        public void ExcluirRelacao(int idPassagem, int idViagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("DELETE FROM passagem_viagem WHERE " +
                "id_passagem=@id_passagem AND id_viagem=@id_viagem;");

                comando.Parameters.Add("id_passagem", idPassagem);
                comando.Parameters.Add("id_viagem", idViagem);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                finally { comando.Connection.Close(); }
            }
        }
    }
}

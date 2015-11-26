using HopeBus.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class ClientePassagemMySql : MySqlBase
    {
        public void InserirRelacao(int idCliente, int idPassagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cliente_passagem(id_cliente,id_passagem)" +
                "VALUES @id_cliente, @id_passagem;");

                comando.Parameters.Add("id_cliente", idCliente);
                comando.Parameters.Add("id_passagem", idPassagem);

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

        public void ExcluirRelacao(int idCliente, int idPassagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("DELETE FROM cliente_passagem WHERE " +
                "id_cliente=@id_cliente AND id_passagem=@id_passagem;");

                comando.Parameters.Add("id_cliente", idCliente);
                comando.Parameters.Add("id_passagem", idPassagem);

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

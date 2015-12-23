using HopeBus.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    public class ClientePassagemMySql : MySqlBase
    {
        public void InserirRelacao(int idCliente, int idPassagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cliente_passagem(id_cliente,id_passagem)" +
                "VALUES(@id_cliente, @id_passagem);");

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

        public void ExcluiRelacao(int idPassagem)
        {
            using(MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand("DELETE FROM cliente_passagem WHERE " +
                "id_passagem=@id_passagem;");
                
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

        public List<Agendamento> ObtemAgendamentos()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("select p.data, c.nome, c.identidade, v.origem, v.destino, v.horario from passagem p inner join cliente_passagem cp on cp.id_passagem = p.id inner join cliente c on c.id = cp.id_cliente inner join viagem v inner join passagem_viagem pv on v.id = pv.id_viagem");
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<Agendamento> agendamentos = new List<Agendamento>();
                    
                    while (reader.Read())
                    {
                        Agendamento agendamento = new Agendamento(reader);
                        agendamentos.Add(agendamento);
                    }
                    return agendamentos;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                finally
                {
                    comando.Connection.Close();
                }
                return null;
            }
        }

    }
}

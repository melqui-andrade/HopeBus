using HopeBus.domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.services
{
    class ClienteMySql : MySqlBase
    {

        public ClienteDomain ObtemCliente(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cliente WHERE id=@id;");
                comando.Parameters.Add("id", id);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain(reader);
                        return cliente;
                    }
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

        public List<ClienteDomain> ObtemClientes()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cliente;");
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<ClienteDomain> clientes = new List<ClienteDomain>();
                    while (reader.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain(reader);
                        clientes.Add(cliente);
                    }
                    return clientes;
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

        /// <summary>
        /// Busca Clientes que possuam o parâmetro passado em qualquer um dos campos
        /// </summary>
        /// <param name="parametro">Texto que deseja procurar</param>
        /// <returns>Lista de clientes que satisfaçam a busca</returns>
        public List<ClienteDomain> BuscaClientes(String parametro)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                StringBuilder querry = new StringBuilder("SELECT c.* FROM cliente c WHERE");

                querry.Append(" c.nome LIKE '%@parametro%' OR");
                querry.Append(" c.cpf=@parametro OR");
                querry.Append(" c.identidade=@parametro OR");
                querry.Append(" c.tipo=@parametro;");

                MySqlCommand comando = new MySqlCommand(querry.ToString());
                comando.Parameters.Add("parametro", parametro);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<ClienteDomain> clientes = new List<ClienteDomain>();
                    while (reader.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain(reader);
                        clientes.Add(cliente);
                    }
                    return clientes;
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

        public void SalvaCliente(ClienteDomain cliente)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                //Cliente possui um ID, logo se trata de um update
                if (cliente.ID > 0)
                {
                    comando.CommandText = "UPDATE cliente SET nome=@nome,cpf=@cpf,identidade=@identidade," +
                    "telefone=@telefone,tipo=@tipo WHERE id=@id;";
                    comando.Parameters.Add(new MySqlParameter("nome",cliente.Nome));
                    comando.Parameters.Add(new MySqlParameter("cpf", cliente.CPF));
                    comando.Parameters.Add(new MySqlParameter("identidade", cliente.Identidade));
                    comando.Parameters.Add(new MySqlParameter("telefone", cliente.Telefone));
                    comando.Parameters.Add(new MySqlParameter("tipo", cliente.Tipo));
                    comando.Parameters.Add(new MySqlParameter("id", cliente.ID));

                    comando.Connection = conexao;
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
                //Cliente não possui um ID, logo se trata de uma insersão
                else
                {
                    comando.CommandText = "INSERT INTO cliente(nome,cpf,identidade,telefone,tipo) VALUES(" +
                        "@nome,@cpf,@identidade,@telefone,@tipo);SELECT LAST_INSERT_ID();";

                    comando.Parameters.Add(new MySqlParameter("nome", cliente.Nome));
                    comando.Parameters.Add(new MySqlParameter("cpf", cliente.CPF));
                    comando.Parameters.Add(new MySqlParameter("identidade", cliente.Identidade));
                    comando.Parameters.Add(new MySqlParameter("telefone", cliente.Telefone));
                    comando.Parameters.Add(new MySqlParameter("tipo", cliente.Tipo));                    

                    comando.Connection = conexao;
                    try
                    {
                        cliente.ID = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        public void ExcluiCliente(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM cliente WHERE id=@id;");
                comando.Parameters.Add(new MySqlParameter("id", id));

                comando.Connection = conexao;
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

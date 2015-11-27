using HopeBus.domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.services
{
    class PassagemMySql : MySqlBase
    {
        public PassagemDomain ObtemPassagem(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM passagem WHERE id=@id;");
                comando.Parameters.Add("id", id);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        PassagemDomain passagem = new PassagemDomain(reader);
                        return passagem;
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

        public List<PassagemDomain> ObtemPassagens()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM passagem;");
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<PassagemDomain> passagens = new List<PassagemDomain>();
                    while (reader.Read())
                    {
                        PassagemDomain passagem = new PassagemDomain(reader);
                        passagens.Add(passagem);
                    }
                    return passagens;
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
        /// Busca Passagens que possuam o parâmetro passado em qualquer um dos campos
        /// de viagem ou de cliente e na própria passagem
        /// </summary>
        /// <param name="parametro">Texto que deseja procurar</param>
        /// <returns>Lista de passagens que satisfaçam a busca</returns>
        public List<ViagemDomain> BuscaPassagens(String parametro)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                
                StringBuilder querry = new StringBuilder("SELECT p.* FROM passagem p");

                querry.Append(" INNER JOIN cliente_passagem cp ON p.id = cp.id_passagem");
                querry.Append(" INNER JOIN cliente c ON cp.id_cliente = c.id");
                querry.Append(" WHERE c.nome = @parametro OR c.cpf = @parametro");
                querry.Append(" OR c.identidade = @parametro OR c.tipo = @parametro;");

                //Pesquisar passagens relacionadas a viagem
                querry.Append(" INNER JOIN passagem_viagem pv  ON p.id = pv.id_passagem");
                querry.Append(" INNER JOIN viagem v ON pv.id_viagem = v.id");
                querry.Append(" WHERE v.origem = @parametro OR v.destino = @parametro");
                querry.Append(" OR v.horario = @parametro");

                //Pesquisar de acordo com as colunas da passagem
                querry.Append(" OR p.data = @parametro;");

                MySqlCommand comando = new MySqlCommand(querry.ToString());
                comando.Parameters.Add("parametro", parametro);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<ViagemDomain> viagens = new List<ViagemDomain>();
                    while (reader.Read())
                    {
                        ViagemDomain viagem = new ViagemDomain(reader);
                        viagens.Add(viagem);
                    }
                    return viagens;
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

        public List<PassagemDomain> BuscaPassagensDaViagem(int idViagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                StringBuilder querry = new StringBuilder("SELECT p.* FROM passagem p");
                querry.Append(" INNER JOIN passagem_viagem pv  ON p.id = pv.id_passagem");
                querry.Append(" WHERE pv.id_viagem=@id_viagem;");

                MySqlCommand comando = new MySqlCommand(querry.ToString());
                comando.Parameters.Add("id_viagem", idViagem);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<PassagemDomain> passagens = new List<PassagemDomain>();
                    while (reader.Read())
                    {
                        PassagemDomain passagem = new PassagemDomain(reader);
                        passagens.Add(passagem);
                    }
                    return passagens;
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

        public void SalvaPassagem(PassagemDomain passagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                //Passagem possui um ID, logo se trata de um update
                if (passagem.ID > 0)
                {
                    comando.CommandText = "UPDATE passagem SET valor=@valor,data=@data,poltrona=@poltrona WHERE id=@id;";
                    comando.Parameters.Add(new MySqlParameter("valor", passagem.Valor));
                    comando.Parameters.Add(new MySqlParameter("data", passagem.Data));
                    comando.Parameters.Add(new MySqlParameter("poltrona", passagem.Poltrona));
                    comando.Parameters.Add(new MySqlParameter("id", passagem.ID));

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
                //Passagem não possui um ID, logo se trata de uma insersão
                else
                {
                    comando.CommandText = "INSERT INTO passagem(valor,data,poltrona) VALUES(" +
                        "@valor,@data,@poltrona);SELECT LAST_INSERT_ID();";
                    comando.Parameters.Add(new MySqlParameter("valor", passagem.Valor));
                    comando.Parameters.Add(new MySqlParameter("data", passagem.Data));
                    comando.Parameters.Add(new MySqlParameter("poltrona", passagem.Poltrona));
                    comando.Parameters.Add(new MySqlParameter("id", passagem.ID));

                    comando.Connection = conexao;
                    try
                    {
                        passagem.ID = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        public void ExcluiPassagem(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM passagem WHERE id=@id;");
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

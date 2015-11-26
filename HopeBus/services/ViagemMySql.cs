using HopeBus.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HopeBus.services
{
    public class ViagemMySql : MySqlBase
    {
        public ViagemDomain ObtemViagem(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM viagem WHERE id=@id;");
                comando.Parameters.Add("id", id);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ViagemDomain viagem = new ViagemDomain(reader);
                        return viagem;
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

        public ViagemDomain ObtemViagem(String origem, String destino, String horario)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM viagem WHERE origem=@origem "+
                "AND destino=@destino AND horario=@horario");
                comando.Parameters.Add("origem", origem);
                comando.Parameters.Add("destino", destino);
                comando.Parameters.Add("horario", horario);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ViagemDomain viagem = new ViagemDomain(reader);
                        return viagem;
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

        public List<ViagemDomain> ObtemViagens()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM viagem;");
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

        /// <summary>
        /// Busca Viagens que possuam o parâmetro passado em qualquer um dos campos
        /// de viagem
        /// </summary>
        /// <param name="parametro">Texto que deseja procurar</param>
        /// <returns>Lista de viagens que satisfaçam a busca</returns>
        public List<ViagemDomain> BuscaViagens(String parametro)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                
                StringBuilder querry = new StringBuilder("SELECT * FROM viagem WHERE");
                querry.Append(" origem=@parametro OR");
                querry.Append(" destino=@parametro OR");
                querry.Append(" horario=@parametro;");

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

        public void SalvaViagem(ViagemDomain viagem)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                //Viagem possui um ID, logo se trata de um update
                if (viagem.ID > 0)
                {
                    comando.CommandText = "UPDATE viagem SET origem=@origem,destino=@destino,horario=@horario WHERE id=@id;";
                    comando.Parameters.Add(new MySqlParameter("origem", viagem.Origem));
                    comando.Parameters.Add(new MySqlParameter("destino", viagem.Destino));
                    comando.Parameters.Add(new MySqlParameter("horario", viagem.Horario));
                    comando.Parameters.Add(new MySqlParameter("id", viagem.ID));

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
                //Viagem não possui um ID, logo se trata de uma insersão
                else
                {
                    comando.CommandText = "INSERT INTO viagem(origem,destino,horario) VALUES(" +
                        "@origem,@destino,@horario);SELECT LAST_INSERT_ID();";
                    comando.Parameters.Add(new MySqlParameter("origem", viagem.Origem));
                    comando.Parameters.Add(new MySqlParameter("destino", viagem.Destino));
                    comando.Parameters.Add(new MySqlParameter("horario", viagem.Horario));

                    comando.Connection = conexao;
                    try
                    {
                        viagem.ID = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        public void ExcluiViagem(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM viagem WHERE id=@id;");
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

        //Exclui tudo fica melhor fora, pois além de excluir viagem, precisa excluir passagens relacionadas
        //public void ExcluiViagens()
        //{
        //    using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
        //    {
        //        conexao.Open();
        //        MySqlCommand comando = new MySqlCommand("SELECT * FROM viagem;");

        //        comando.Connection = conexao;
        //        try
        //        {
        //            MySqlDataReader reader = comando.ExecuteReader();
        //            StringBuilder querryDeletar = new StringBuilder();
        //            while (reader.Read())
        //            {
        //                querryDeletar.Append("DELETE FROM viagem WHERE id=" + reader["id"] + ";");
        //            }

        //            comando.CommandText = querryDeletar.ToString();
        //            comando.ExecuteNonQuery();
                    
        //        }
        //        catch (Exception e)
        //        {
        //            Console.Error.WriteLine(e);
        //        }
        //        finally { comando.Connection.Close(); }
        //    }
        //}
    }
}

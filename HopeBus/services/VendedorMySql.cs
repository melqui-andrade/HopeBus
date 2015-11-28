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
    public class VendedorMySql : MySqlBase
    {
        public VendedorDomain ObtemVendedor(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM vendedor WHERE id=@id;");
                comando.Parameters.Add("id", id);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        VendedorDomain vendedor = new VendedorDomain(reader);
                        return vendedor;
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

        public List<VendedorDomain> ObtemVendedores()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM vendedor;");
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<VendedorDomain> vendedores = new List<VendedorDomain>();
                    while (reader.Read())
                    {
                        VendedorDomain vendedor = new VendedorDomain(reader);
                        vendedores.Add(vendedor);
                    }
                    return vendedores;
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
        public List<VendedorDomain> BuscaVendedores(String parametro)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                
                StringBuilder querry = new StringBuilder("SELECT * FROM vendedor WHERE");
                querry.Append(" nome=@parametro OR");
                querry.Append(" identidade=@parametro OR");
                querry.Append(" cep=@parametro;");

                MySqlCommand comando = new MySqlCommand(querry.ToString());
                comando.Parameters.Add("parametro", parametro);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    List<VendedorDomain> vendedores = new List<VendedorDomain>();
                    while (reader.Read())
                    {
                        VendedorDomain vendedor = new VendedorDomain(reader);
                        vendedores.Add(vendedor);
                    }
                    return vendedores;
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

        public bool VendedorEstaAutenticado(String login, String senha)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM vendedor WHERE login=@login AND senha=@senha;");
                comando.Parameters.Add("login", login);
                comando.Parameters.Add("senha", senha);
                comando.Connection = conexao;
                try
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        VendedorDomain vendedor = new VendedorDomain(reader);
                        if (vendedor.ID > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
                finally
                {
                    comando.Connection.Close();
                    comando.Dispose();
                }
                return false;
            }
        }

        public void SalvaVendedor(VendedorDomain vendedor)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                //Viagem possui um ID, logo se trata de um update
                if (vendedor.ID > 0)
                {
                    comando.CommandText = "UPDATE vendedor SET cep=@cep, cpf=@cpf, endereco=@endereco,identidade=@identidade, nome=@nome WHERE id=@id;";
                    comando.Parameters.Add(new MySqlParameter("cep", vendedor.Cep));
                    comando.Parameters.Add(new MySqlParameter("cpf", vendedor.CPF));
                    comando.Parameters.Add(new MySqlParameter("endereco", vendedor.Endereco));
                    comando.Parameters.Add(new MySqlParameter("identidade", vendedor.Identidade));
                    comando.Parameters.Add(new MySqlParameter("nome", vendedor.Nome));
                    comando.Parameters.Add(new MySqlParameter("id", vendedor.ID));

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
                    comando.CommandText = "INSERT INTO vendedor(cep,cpf,endereco,identidade,nome) VALUES(" +
                        "@cep,@cpf,@endereco,@identidade,@nome);SELECT LAST_INSERT_ID();";

                    comando.Parameters.Add(new MySqlParameter("cep", vendedor.Cep));
                    comando.Parameters.Add(new MySqlParameter("cpf", vendedor.CPF));
                    comando.Parameters.Add(new MySqlParameter("endereco", vendedor.Endereco));
                    comando.Parameters.Add(new MySqlParameter("identidade", vendedor.Identidade));
                    comando.Parameters.Add(new MySqlParameter("nome", vendedor.Nome));

                    comando.Connection = conexao;
                    try
                    {
                        vendedor.ID = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                    }
                }
            }
        }

        public void ExcluiVendedor(int id)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM vendedor WHERE id=@id;");
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

        //public void ExcluiVendedores()
        //{
        //    using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
        //    {
        //        conexao.Open();
        //        MySqlCommand comando = new MySqlCommand("SELECT * FROM vendedor;");

        //        comando.Connection = conexao;
        //        try
        //        {
        //            MySqlDataReader reader = comando.ExecuteReader();
        //            StringBuilder querryDeletar = new StringBuilder();
        //            while (reader.Read())
        //            {
        //                querryDeletar.Append("DELETE FROM vendedor WHERE id=" + reader["id"] + ";");
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

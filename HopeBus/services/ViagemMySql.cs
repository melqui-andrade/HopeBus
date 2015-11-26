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
                MySqlCommand comando = new MySqlCommand("SELECT * FROM viagem WHERE id=@id");
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
    }
}

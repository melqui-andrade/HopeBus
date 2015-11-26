using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class ClienteDomain
    {
        int ID { get; set; }

        String Nome { get; set; }

        String Identidade { get; set; }

        String CPF { get; set; }

        String Telefone { get; set; }

        EnumTipo Tipo { get; set; }

        public ClienteDomain() { }

        public ClienteDomain(MySqlDataReader reader)
        {
            ID = (int)reader["id"];
            Nome = (String)reader["nome"];
            Identidade = (String)reader["identidade"];
            CPF = (String)reader["cpf"];
            Telefone = (String)reader["telefone"];
            Tipo = (EnumTipo)reader["tipo"];
        }
    }
}

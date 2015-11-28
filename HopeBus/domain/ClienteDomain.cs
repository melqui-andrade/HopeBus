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
        public int ID { get; set; }

        public String Nome { get; set; }

        public String Identidade { get; set; }

        public String CPF { get; set; }

        public String Telefone { get; set; }

        public EnumTipo Tipo { get; set; }

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

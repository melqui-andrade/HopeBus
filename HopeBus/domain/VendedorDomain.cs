using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class VendedorDomain
    {
        public int ID { get; set; }

        public String Nome { get; set; }

        public String Login { get; set; }

        public String Senha { get; set; }

        public String Identidade { get; set; }

        public String CPF { get; set; }

        public String Endereco { get; set; }

        public String Cep { get; set; }

        public VendedorDomain() { }

        public VendedorDomain(MySqlDataReader reader)
        {
            ID = (int)reader["id"];
            Nome = (String)reader["nome"];
            Login = (String)reader["login"];
            Senha = (String)reader["senha"];
            Identidade = (String)reader["identidade"];
            CPF = (String)reader["cpf"];
            Endereco = (String)reader["endereco"];
            Cep = (String)reader["cep"];
        }
    }
}

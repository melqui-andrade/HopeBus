using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    public class Agendamento
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public String Nome { get; set; }
        public String Origem { get; set; }
        public String Destino { get; set; }
        public DateTime Horario { get; set; }
        

        public Agendamento() { }

        public Agendamento(MySqlDataReader reader) {
            Data = DateTime.Parse(reader["data"].ToString());
            Nome = (String)reader["nome"];
            Origem = (String)reader["origem"];
            Destino = (String)reader["destino"];
            Horario = DateTime.Parse(reader["horario"].ToString());
        }

    }
}

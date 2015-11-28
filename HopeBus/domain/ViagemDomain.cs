using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HopeBus.domain
{
    public class ViagemDomain
    {
        public int ID { get; set; }

        public String Origem { get; set; }

        public String Destino { get; set; }

        public DateTime Horario { get; set; }

        public ViagemDomain() { }

        public ViagemDomain(MySqlDataReader reader)
        {
            ID = (int)reader["id"];
            Origem = (String)reader["origem"];
            Destino = (String)reader["destino"];
            Horario = DateTime.Parse(reader["horario"].ToString());
            
        }
    }
}

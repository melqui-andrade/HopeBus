using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class PassagemDomain
    {
        public int ID { get; set; }

        public double Valor { get; set; }

        public DateTime Data { get; set; }

        public int Poltrona { get; set; }

        public PassagemDomain() { }

        public PassagemDomain(MySqlDataReader reader)
        {
            ID = (int)reader["id"];
            Valor = (double)reader["valor"];
            Data = (DateTime)reader["data"];
            Poltrona = (int)reader["poltrona"];
        }
    }
}

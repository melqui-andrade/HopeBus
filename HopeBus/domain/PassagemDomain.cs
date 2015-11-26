using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class PassagemDomain
    {
        int ID { get; set; }

        double Valor { get; set; }

        DateTime Data { get; set; }

        int Poltrona { get; set; }
    }
}

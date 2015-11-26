using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class ViagemDomain
    {
        int ID { get; set; }

        String Origem { get; set; }

        String Destino { get; set; }

        DateTime Horario { get; set; }
    }
}

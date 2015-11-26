using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.domain
{
    class Cliente
    {
        int ID { get; set; }

        String Nome { get; set; }

        String Identidade { get; set; }

        String CPF { get; set; }

        String Telefone { get; set; }

        EnumTipo Tipo { get; set; }
    }
}

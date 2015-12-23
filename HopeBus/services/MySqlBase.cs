using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.services
{
    public abstract class MySqlBase
    {
        //String de conexão de Melqui
        protected String stringDeConexao = "server=localhost;user id=root;database=hope_bus;password=root";

        //String de conexão de Sidney
        //protected String stringDeConexao = "server=localhost;user id=SEU_ID;database=hope_bus;password=SEU_PASS";
    }
}

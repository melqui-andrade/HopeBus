using HopeBus.domain;
using HopeBus.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.business
{
    class ClienteBusiness
    {
        ClienteMySql _clienteMySql;

        public ClienteBusiness()
        {
            _clienteMySql = new ClienteMySql();
        }

        public int SalvaCliente(EnumTipo tipo, String nome, String cpf, String identidade, String telefone)
        {
            ClienteDomain cliente = new ClienteDomain();
            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Identidade = identidade;
            cliente.Telefone = telefone;
            cliente.Tipo = tipo;
                        
            _clienteMySql.SalvaCliente(cliente);
            return cliente.ID;          
        }

        public ClienteDomain ObtemCliente(int id)
        {
            return _clienteMySql.ObtemCliente(id);
        }

        public List<ClienteDomain> ListaClientes()
        {
            return _clienteMySql.ObtemClientes();
        }

        public List<ClienteDomain> BuscaClientes(String parametro)
        {
            return _clienteMySql.BuscaClientes(parametro);
        }

        public void ExcluiCliente(int id)
        {
            _clienteMySql.ExcluiCliente(id);
        }
    }
}

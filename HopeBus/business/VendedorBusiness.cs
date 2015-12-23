using HopeBus.services;
using HopeBus.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.business
{
    public class VendedorBusiness
    {
        private VendedorMySql _vendedorMySql;

        public VendedorBusiness()
        {
            _vendedorMySql = new VendedorMySql();
        }

        public bool VendedorAutenticado(String nome, String senha)
        {            
            return _vendedorMySql.VendedorEstaAutenticado(nome, senha);            
        }

        public VendedorDomain ObtemVendedor(int id)
        {
            return _vendedorMySql.ObtemVendedor(id);
        }

        public List<VendedorDomain> ListaVendedores()
        {            
            return _vendedorMySql.ObtemVendedores();
        }

        public List<VendedorDomain> BuscaVendedores(String parametro)
        {
            return _vendedorMySql.BuscaVendedores(parametro);
        }

        public void SalvaVendedor(String nome, String cpf, String identidade, String login, String senha, String cep, String endereco)
        {
            VendedorDomain vendedor = new VendedorDomain();
            vendedor.Nome = nome;
            vendedor.CPF = cpf;
            vendedor.Identidade = identidade;
            vendedor.Login = login;
            vendedor.Cep = cep;
            vendedor.Endereco = endereco;
            vendedor.Senha = senha;

            _vendedorMySql.SalvaVendedor(vendedor);
        }        

        public void ExcluiVendedor(int id)
        {            
            _vendedorMySql.ExcluiVendedor(id);
        }


    }
}

using HopeBus.domain;
using HopeBus.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeBus.business
{
    class PassagemBusiness
    {
        PassagemMySql _passagemMySql;

        public PassagemBusiness()
        {
            _passagemMySql = new PassagemMySql();
        }

        public void SalvaPassagem(int poltronaSelecionada, EnumTipo tipo, String origem, String destino, String horario, int idCliente)
        {
            PassagemDomain passagem = new PassagemDomain();
            ViagemMySql viagemMySql = new ViagemMySql();
            ViagemDomain viagem = viagemMySql.ObtemViagem(origem, destino, horario);

            PassagemViagemMySql passagemViagemMySql = new PassagemViagemMySql();
            ClientePassagemMySql clientePassagem = new ClientePassagemMySql();

            passagem.Data = DateTime.Now;
            passagem.Poltrona = poltronaSelecionada;
            passagem.Valor = CalculaValorDaPassagem(tipo);
            _passagemMySql.SalvaPassagem(passagem);

            passagemViagemMySql.InserirRelacao(passagem.ID, viagem.ID);
            clientePassagem.InserirRelacao(idCliente, passagem.ID);
        }

        public PassagemDomain ObtemPassagem(int id)
        {                        
            return _passagemMySql.ObtemPassagem(id);
        }

        public List<PassagemDomain> ListaPassagens()
        {
            return _passagemMySql.ObtemPassagens();
        }

        public List<PassagemDomain> BuscaPassagens(String parametro)
        {
            return _passagemMySql.BuscaPassagens(parametro);
        }

        public List<PassagemDomain> BuscaPassagensDaViagem(String origem, String destino, String horario)
        {
            ViagemMySql viagemMySql = new ViagemMySql();
            ViagemDomain viagem = viagemMySql.ObtemViagem(origem, destino, horario);
            return _passagemMySql.BuscaPassagensDaViagem(viagem.ID);
        }

        public void ExcluiPassagem(int id)
        {
            PassagemViagemMySql passagemViagemMySql = new PassagemViagemMySql();
            ClientePassagemMySql clientePassagemMySql = new ClientePassagemMySql();

            passagemViagemMySql.ExcluiRelacao(id);
            clientePassagemMySql.ExcluiRelacao(id);
            _passagemMySql.ExcluiPassagem(id);            
        }

        private double CalculaValorDaPassagem(EnumTipo tipo)
        {
            switch (tipo)
            {
                case EnumTipo.Normal:
                    return 4.2;
                case EnumTipo.Estudante:
                    return 2.1;
                case EnumTipo.Idoso:
                    return 0.0;
                case EnumTipo.Deficiente:
                    return 0.0;
                default:
                    return 4.2;
            }
        }
    }
}

using HopeBus.domain;
using HopeBus.presentation.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeBus.presentation.vendedor.consultarAgendamento
{
    public partial class ConsultarAgendamentoView : Form
    {
        public ConsultarAgendamentoView()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            IndexVendedorView indexVendedorView = new IndexVendedorView();
            this.Hide();
            indexVendedorView.Closed += (s, args) => this.Close();
            indexVendedorView.WindowState = this.WindowState;

            indexVendedorView.Show();
        }

        private void campoPesquisar_TextChanged(object sender, EventArgs e)
        {
            String pesquisa = campoPesquisar.Text;

            ClientePassagemMySql clientePassagem = new ClientePassagemMySql();

            List<Agendamento> agendamentos = clientePassagem.ObtemAgendamentos();

            dataGridPesquisa.Rows.Clear();
            for (int i = 0; i < agendamentos.Count; i++)
            {
                Agendamento ag = agendamentos.ElementAt(i);
                if (ag.Nome.ToLower() == pesquisa.ToLower() || ag.Data.Date.ToString().ToLower() == pesquisa.ToLower() || ag.Destino.ToLower() == pesquisa.ToLower() || ag.Origem.ToLower() == pesquisa.ToLower())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridPesquisa.Rows[0].Clone();
                    row.Cells[0].Value = ag.Nome;
                    row.Cells[1].Value = ag.Data;
                    row.Cells[2].Value = ag.Origem;
                    row.Cells[3].Value = ag.Destino;
                    row.Cells[4].Value = ag.Horario;
                    row.Height = 50;
                    dataGridPesquisa.Rows.Add(row);

                }

            }

        }
    }
}

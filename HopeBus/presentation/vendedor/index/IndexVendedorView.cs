using HopeBus.presentation.Vendedor.AlterarAgendamentoDoEmbarque;
using HopeBus.presentation.Vendedor.EmitirPassagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeBus.presentation.Vendedor
{
    public partial class IndexVendedorView : Form
    {
        public IndexVendedorView()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            this.Hide();
            loginView.Closed += (s, args) => this.Close(); 
            loginView.Show();


        }

        private void btnEmitirPassagem_Click(object sender, EventArgs e)
        {
            EmitirPassagemView emitirPassagemView = new EmitirPassagemView();
            this.Hide();
            emitirPassagemView.Closed += (s, args) => this.Close();
            emitirPassagemView.Show();
        }

        private void btnAlterarAgendamento_Click(object sender, EventArgs e)
        {
            AlterarAgendamentoPesquisarView alterarAgendamentoView = new AlterarAgendamentoPesquisarView();
            this.Hide();
            alterarAgendamentoView.Closed += (s, args) => this.Close();
            alterarAgendamentoView.Show();
        }
    }
}

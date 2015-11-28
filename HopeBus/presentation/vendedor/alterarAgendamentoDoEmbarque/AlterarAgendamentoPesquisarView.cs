using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeBus.presentation.Vendedor.consultarAgendamentoView
{
    public partial class AlterarAgendamentoPesquisarView : Form
    {
        public AlterarAgendamentoPesquisarView()
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

        }
    }
}

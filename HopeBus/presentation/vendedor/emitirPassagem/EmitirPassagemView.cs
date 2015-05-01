using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeBus.presentation.Vendedor.EmitirPassagem
{
    public partial class EmitirPassagemView : Form
    {
        public EmitirPassagemView()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            IndexVendedorView indexVendedorView = new IndexVendedorView();
            this.Hide();
            indexVendedorView.Closed += (s, args) => this.Close();
            indexVendedorView.Show();
        }
    }
}

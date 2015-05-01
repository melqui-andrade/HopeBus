using HopeBus.presentation.index;
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

namespace HopeBus
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IndexVendedorView indexVendedorView = new IndexVendedorView();
            this.Hide();
            indexVendedorView.Closed += (s, args) => this.Close(); 
            indexVendedorView.Show();
           
        }

        private void linkContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreditosView creditosView = new CreditosView();
            this.Hide();
            creditosView.Closed += (s, args) => this.Close();
            creditosView.Show();
        }
    }
}

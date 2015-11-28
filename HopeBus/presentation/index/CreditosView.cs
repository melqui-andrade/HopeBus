using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeBus.presentation.index
{
    public partial class CreditosView : Form
    {
        public CreditosView()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            this.Hide();
            loginView.Closed += (s, args) => this.Close();
            loginView.WindowState = this.WindowState;
            loginView.Show();
        }
    }
}

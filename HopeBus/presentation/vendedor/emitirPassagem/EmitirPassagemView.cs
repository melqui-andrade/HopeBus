using HopeBus.domain;
using HopeBus.services;
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

        private void EmitirPassagemView_Load(object sender, EventArgs e)
        {
            ViagemMySql viagemMySql = new ViagemMySql();
            List<ViagemDomain> viagens = viagemMySql.ObtemViagens();
            if (viagens.Count > 0)
            {
                foreach (ViagemDomain viagem in viagens)
                {
                    comboBoxOrigem.Items.Add(viagem.Origem);
                    comboBoxDestino.Items.Add(viagem.Destino);
                    comboBoxHorario.Items.Add(viagem.Horario.TimeOfDay);
                }
            }

        }
    }
}

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

        private void EmitirPassagemView_Load(object sender, EventArgs e)
        {
            ViagemMySql viagemMySql = new ViagemMySql();
            List<ViagemDomain> viagens = viagemMySql.ObtemViagens();
            ajustaCamposDoTrajeto(viagens);
            ajustaCoresDasPoltronas();

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            IndexVendedorView indexVendedorView = new IndexVendedorView();
            this.Hide();
            indexVendedorView.Closed += (s, args) => this.Close();
            indexVendedorView.Show();
        }


        private void btnAvancar_Click(object sender, EventArgs e)
        {

        }

        private void ajustaCamposDoTrajeto(List<ViagemDomain> viagens)
        {
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

        private bool formEstaOk()
        {
            //Dados da viagem
            StringBuilder mensagemErro = new StringBuilder();
            if(String.IsNullOrEmpty(comboBoxOrigem.Text) || String.IsNullOrEmpty(comboBoxDestino.Text) ||
                String.IsNullOrEmpty(comboBoxHorario.Text))
            {
                return false;
            }
            //Dados do passageiro
            else if(String.IsNullOrEmpty(campoNome.Text) || String.IsNullOrEmpty(campoCPF.Text) ||
                String.IsNullOrEmpty(campoRG.Text))
            {
                return false;
            }
            //Poltrona

            return true;
        }

        private void ajustaCoresDasPoltronas()
        {
            int i = 1;
            foreach (Button control in panelPoltronas.Controls.Cast<Button>().OrderBy(b => b.Right))
            {
                
                    Button button = (Button)control;
                    button.Text = Convert.ToString(i);
                    button.BackColor = Color.FromArgb(255, 39, 174, 97);
                    i++;
                
            }
        }

        private void comboBoxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrigem.Text == comboBoxDestino.Text)
            {
                int i = comboBoxDestino.Items.Count - 1;
                while (comboBoxOrigem.Text == comboBoxDestino.Text)
                {
                    comboBoxDestino.SelectedIndex = i;
                    i--;
                }
            }
        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrigem.Text == comboBoxDestino.Text)
            {
                int i = comboBoxOrigem.Items.Count - 1;
                while (comboBoxOrigem.Text == comboBoxDestino.Text)
                {
                    comboBoxOrigem.SelectedIndex = i;
                    i--;
                }
            }
        }

        private void AbasEmitirPassagem_TabIndexChanged(object sender, EventArgs e)
        {
            TabControl abas = (TabControl)sender;
            if (abas.SelectedIndex == 2)
            {
                if (formEstaOk())
                {
                    String origem = comboBoxOrigem.Text;
                    String destino = comboBoxDestino.Text;
                    String horario = comboBoxHorario.Text;
                    ViagemMySql viagemMySql = new ViagemMySql();
                    ViagemDomain viagem = viagemMySql.ObtemViagem(origem, destino, horario);

                    if (viagem != null)
                    {

                    }
                }
            }
        }
    }
}

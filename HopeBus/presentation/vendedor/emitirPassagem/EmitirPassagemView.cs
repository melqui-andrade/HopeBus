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
        Color _corLivre = Color.FromArgb(255, 39, 174, 97);
        Color _corOcupado = Color.FromArgb(255, 232, 76, 61);
        Color _corSelecionado = Color.FromArgb(255, 234, 156, 17);
        String _ultimaPoltronaSelecionada = "0";

        public EmitirPassagemView()
        {
            InitializeComponent();
        }

        private void EmitirPassagemView_Load(object sender, EventArgs e)
        {
            ViagemMySql viagemMySql = new ViagemMySql();
            List<ViagemDomain> viagens = viagemMySql.ObtemViagens();
            ajustaCamposDoTrajeto(viagens);            

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

        private void btnPoltrona_Click(object sender, EventArgs e)
        {
            Button poltrona = (Button)sender;
            if (poltrona.BackColor.Equals(_corLivre))
            {
                poltrona.BackColor = _corSelecionado;
                if (_ultimaPoltronaSelecionada != "0")
                {
                    Button ultimo = panelPoltronas.Controls.Cast<Button>().Single(b => b.Text == _ultimaPoltronaSelecionada);
                    ultimo.BackColor = _corLivre;
                }
                _ultimaPoltronaSelecionada = poltrona.Text;
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
                    PassagemMySql passagemMySql = new PassagemMySql();
                    ViagemDomain viagem = viagemMySql.ObtemViagem(origem, destino, horario);

                    if (viagem != null && viagem.ID > 0)
                    {
                        List<PassagemDomain> passagensCompradas = passagemMySql.BuscaPassagensDaViagem(viagem.ID);
                        ajustaCoresDasPoltronas(passagensCompradas);    
                    }
                }
            }
        }

        private bool formEstaOk()
        {
            //Dados da viagem            
            if (String.IsNullOrEmpty(comboBoxOrigem.Text) || String.IsNullOrEmpty(comboBoxDestino.Text) ||
                String.IsNullOrEmpty(comboBoxHorario.Text))
            {
                MessageBox.Show("Necessário definir: Origem, destino e horário da viagem", "Campos obrigatórios");
                return false;
            }
            //Dados do passageiro
            else if (String.IsNullOrEmpty(campoNome.Text) || String.IsNullOrEmpty(campoCPF.Text) ||
                String.IsNullOrEmpty(campoRG.Text))
            {
                MessageBox.Show("Necessário preencher: Nome, CPF e RG do passageiro", "Campos obrigatórios");
                return false;
            }
            //Poltrona

            return true;
        }

        private void ajustaCoresDasPoltronas(List<PassagemDomain> passagensCompradas)
        {
            int i = 1;
            List<Button> poltronas = panelPoltronas.Controls.Cast<Button>().OrderBy(b => b.Right).ToList();
            

            foreach (Button control in poltronas)
            {                
                Button poltrona = (Button)control;
                poltrona.Text = Convert.ToString(i);
                poltrona.BackColor = _corLivre;
                poltrona.Click += btnPoltrona_Click;
                i++;
            }
            foreach (PassagemDomain passagem in passagensCompradas)
            {
                String numPoltrona = Convert.ToString(passagem.Poltrona);
                Button poltrona = poltronas.Find(b => b.Text == numPoltrona);
                poltrona.BackColor = _corOcupado;
            }
        }
    }
}

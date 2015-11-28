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
        Color _corIndisponivel = Color.FromArgb(255, 236, 240, 241);

        String _ultimaPoltronaSelecionada = "0";
        int _tabSelecionada = 0;

        public EmitirPassagemView()
        {
            InitializeComponent();
        }

        private void EmitirPassagemView_Load(object sender, EventArgs e)
        {
            limpaForm();
        }

        private void ajustarCampoTipoPassagem()
        {
            comboBoxTipoDaPassagem.Items.Add(EnumTipo.Normal);
            comboBoxTipoDaPassagem.Items.Add(EnumTipo.Estudante);
            comboBoxTipoDaPassagem.Items.Add(EnumTipo.Idoso);
            comboBoxTipoDaPassagem.Items.Add(EnumTipo.Deficiente);
            comboBoxTipoDaPassagem.SelectedItem = 1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            _tabSelecionada = AbasEmitirPassagem.SelectedIndex;
            if (_tabSelecionada == 1 || _tabSelecionada == 2)
            {
                btnVoltar.Text = " Voltar";
                btnAvancar.Text = "Avançar ";
                AbasEmitirPassagem.SelectedIndex--;
            }
            else { 
                AbasEmitirPassagem.SelectedIndex = 0;
                IndexVendedorView indexVendedorView = new IndexVendedorView();
                this.Hide();
                indexVendedorView.Closed += (s, args) => this.Close();
                indexVendedorView.WindowState = this.WindowState;

                indexVendedorView.Show();
            }


          




        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            _tabSelecionada = AbasEmitirPassagem.SelectedIndex;
            if (_tabSelecionada < AbasEmitirPassagem.TabCount - 2)
            {
                btnAvancar.Text = "Avançar ";
                AbasEmitirPassagem.SelectedIndex++;
            }
            else if (_tabSelecionada == AbasEmitirPassagem.TabCount - 2)
            {
                btnAvancar.Text = "Concluir";
                AbasEmitirPassagem.SelectedIndex++;
            }
            else
            {
                if (formEstaOk())
                {
                    int poltronaSelecionada = Convert.ToInt32(_ultimaPoltronaSelecionada);
                    if (poltronaSelecionada > 0)
                    {
                        EnumTipo tipo = (EnumTipo)comboBoxTipoDaPassagem.SelectedItem;
                        String origem = comboBoxOrigem.Text;
                        String destino = comboBoxDestino.Text;
                        String horario = comboBoxHorario.Text;

                        String nome = campoNome.Text;
                        String cpf = campoCPF.Text;
                        String identidade = campoRG.Text;
                        String telefone = campoTelefone.Text;
                        StringBuilder dadosDaViagem = new StringBuilder();

                        dadosDaViagem.Append("Venda de Passagens de Ônibus \n\n");
                        dadosDaViagem.Append("Dados da Viagem: \n\n");
                        dadosDaViagem.Append(String.Format("Origem: {0}\n" +
                                             "Destino: {1}\nHorario: {2}\n\n", origem, destino, horario));
                        dadosDaViagem.Append("Cliente: " + nome);
                        dadosDaViagem.Append("\nCPF: " + cpf + "\tRG: " + identidade);
                        dadosDaViagem.Append("\n\n" + origem + ", ");
                        dadosDaViagem.Append(String.Format("\n\n{0:hh:mm dd/MM/yyyy}", DateTime.Now));

                        int idCliente = salvaCliente(tipo, nome, cpf, identidade, telefone);
                        salvaPassagem(poltronaSelecionada, tipo, origem, destino, horario, idCliente);

                        DialogResult result = MessageBox.Show(dadosDaViagem.ToString(), "Passagem emitida!");

                        if (result == DialogResult.OK)
                        {
                            limpaForm();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Necessário selecionar a poltrona do passageiro", "Campo Obrigatório");
                    }
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
            if (!String.IsNullOrEmpty(comboBoxOrigem.Text) && !String.IsNullOrEmpty(comboBoxDestino.Text))
            {
                ViagemMySql viagemMySql = new ViagemMySql();
                List<ViagemDomain> viagens = viagemMySql.ObtemViagens();
                comboBoxHorario.Items.Clear();
                foreach (ViagemDomain viagem in viagens)
                {
                    if (viagem.Origem == comboBoxOrigem.Text && viagem.Destino == comboBoxDestino.Text)
                    {
                        comboBoxHorario.Items.Add(viagem.Horario.TimeOfDay);
                    }
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

        private void limpaForm()
        {
            ViagemMySql viagemMySql = new ViagemMySql();
            List<ViagemDomain> viagens = viagemMySql.ObtemViagens();

            AbasEmitirPassagem.SelectedIndex = 0;
            _ultimaPoltronaSelecionada = "0";
            ajustaCamposDoTrajeto(viagens);
            ajustarCampoTipoPassagem();

            campoNome.Text = "";
            campoRG.Text = "";
            campoCPF.Text = "";
            campoTelefone.Text = "";

            btnAvancar.Text = "Avançar ";

            foreach (Button botao in panelPoltronas.Controls.Cast<Button>())
            {
                botao.BackColor = _corIndisponivel;
            }

        }

        private int salvaCliente(EnumTipo tipo, String nome, String cpf, String identidade, String telefone)
        {
            ClienteDomain cliente = new ClienteDomain();
            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Identidade = identidade;
            cliente.Telefone = telefone;
            cliente.Tipo = tipo;

            ClienteMySql clienteMySql = new ClienteMySql();
            clienteMySql.SalvaCliente(cliente);
            return cliente.ID;
        }

        private void salvaPassagem(int poltronaSelecionada, EnumTipo tipo, String origem, String destino, String horario, int idCliente)
        {
            PassagemDomain passagem = new PassagemDomain();
            PassagemMySql passagemMySql = new PassagemMySql();
            ViagemMySql viagemMySql = new ViagemMySql();
            ViagemDomain viagem = viagemMySql.ObtemViagem(origem, destino, horario);

            PassagemViagemMySql passagemViagemMySql = new PassagemViagemMySql();
            ClientePassagemMySql clientePassagem = new ClientePassagemMySql();

            passagem.Data = DateTime.Now;
            passagem.Poltrona = poltronaSelecionada;
            passagem.Valor = calculaValorDaPassagem(tipo);
            passagemMySql.SalvaPassagem(passagem);

            passagemViagemMySql.InserirRelacao(passagem.ID, viagem.ID);
            clientePassagem.InserirRelacao(idCliente, passagem.ID);
        }

        private void ajustaCamposDoTrajeto(List<ViagemDomain> viagens)
        {
            if (viagens.Count > 0)
            {
                comboBoxDestino.Items.Clear();
                comboBoxOrigem.Items.Clear();
                comboBoxHorario.Items.Clear();
                foreach (ViagemDomain viagem in viagens)
                {
                    comboBoxOrigem.Items.Add(viagem.Origem);
                    comboBoxDestino.Items.Add(viagem.Destino);
                    comboBoxHorario.Items.Add(viagem.Horario.TimeOfDay);
                }
            }
        }

        private double calculaValorDaPassagem(EnumTipo tipo)
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

﻿namespace HopeBus.presentation.vendedor.consultarAgendamento
{
    partial class ConsultarAgendamentoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelVendaDePassagensDeOnibus = new System.Windows.Forms.Label();
            this.labelHopeBus = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPesquisa = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.campoPesquisar = new System.Windows.Forms.TextBox();
            this.labelAlterarAgendamento = new System.Windows.Forms.Label();
            this.iconAlterarAgendamento = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.panelTop.Controls.Add(this.labelVendaDePassagensDeOnibus);
            this.panelTop.Controls.Add(this.labelHopeBus);
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1189, 102);
            this.panelTop.TabIndex = 4;
            // 
            // labelVendaDePassagensDeOnibus
            // 
            this.labelVendaDePassagensDeOnibus.AutoSize = true;
            this.labelVendaDePassagensDeOnibus.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendaDePassagensDeOnibus.Location = new System.Drawing.Point(23, 67);
            this.labelVendaDePassagensDeOnibus.Name = "labelVendaDePassagensDeOnibus";
            this.labelVendaDePassagensDeOnibus.Size = new System.Drawing.Size(150, 15);
            this.labelVendaDePassagensDeOnibus.TabIndex = 1;
            this.labelVendaDePassagensDeOnibus.Text = "Venda de Passagens de Ônibus";
            // 
            // labelHopeBus
            // 
            this.labelHopeBus.AutoSize = true;
            this.labelHopeBus.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHopeBus.Location = new System.Drawing.Point(14, 11);
            this.labelHopeBus.Name = "labelHopeBus";
            this.labelHopeBus.Size = new System.Drawing.Size(168, 56);
            this.labelHopeBus.TabIndex = 0;
            this.labelHopeBus.Text = "HopeBus";
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.dataGridPesquisa);
            this.panelBottom.Controls.Add(this.btnPesquisar);
            this.panelBottom.Controls.Add(this.labelPesquisar);
            this.panelBottom.Controls.Add(this.campoPesquisar);
            this.panelBottom.Controls.Add(this.labelAlterarAgendamento);
            this.panelBottom.Controls.Add(this.iconAlterarAgendamento);
            this.panelBottom.Controls.Add(this.btnVoltar);
            this.panelBottom.ForeColor = System.Drawing.Color.White;
            this.panelBottom.Location = new System.Drawing.Point(-2, 97);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1189, 564);
            this.panelBottom.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(14, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "HopeBus - Venda de Passagens de Ônibus Ⓡ Daniel Marques. Melquisedec Andrade, Sid" +
    "ney Pimentel";
            // 
            // dataGridPesquisa
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaDestino,
            this.ColunaCliente,
            this.Destino,
            this.Horario});
            this.dataGridPesquisa.Location = new System.Drawing.Point(94, 154);
            this.dataGridPesquisa.Name = "dataGridPesquisa";
            this.dataGridPesquisa.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridPesquisa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPesquisa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridPesquisa.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPesquisa.Size = new System.Drawing.Size(1072, 329);
            this.dataGridPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(460, 99);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(59, 49);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelPesquisar.Location = new System.Drawing.Point(89, 75);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(100, 30);
            this.labelPesquisar.TabIndex = 15;
            this.labelPesquisar.Text = "Pesquisar";
            // 
            // campoPesquisar
            // 
            this.campoPesquisar.BackColor = System.Drawing.Color.White;
            this.campoPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoPesquisar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.campoPesquisar.Location = new System.Drawing.Point(94, 106);
            this.campoPesquisar.Name = "campoPesquisar";
            this.campoPesquisar.Size = new System.Drawing.Size(360, 39);
            this.campoPesquisar.TabIndex = 0;
            this.campoPesquisar.TextChanged += new System.EventHandler(this.campoPesquisar_TextChanged);
            // 
            // labelAlterarAgendamento
            // 
            this.labelAlterarAgendamento.AutoSize = true;
            this.labelAlterarAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.labelAlterarAgendamento.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterarAgendamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelAlterarAgendamento.Location = new System.Drawing.Point(83, 8);
            this.labelAlterarAgendamento.Name = "labelAlterarAgendamento";
            this.labelAlterarAgendamento.Size = new System.Drawing.Size(894, 65);
            this.labelAlterarAgendamento.TabIndex = 2;
            this.labelAlterarAgendamento.Text = "Consultar Agendamento do Embarque";
            // 
            // iconAlterarAgendamento
            // 
            this.iconAlterarAgendamento.AutoSize = true;
            this.iconAlterarAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.iconAlterarAgendamento.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAlterarAgendamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconAlterarAgendamento.Location = new System.Drawing.Point(983, 8);
            this.iconAlterarAgendamento.Name = "iconAlterarAgendamento";
            this.iconAlterarAgendamento.Size = new System.Drawing.Size(87, 65);
            this.iconAlterarAgendamento.TabIndex = 10;
            this.iconAlterarAgendamento.Text = "";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(14, 489);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(260, 53);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = " Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ColunaID
            // 
            this.ColunaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColunaID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColunaID.HeaderText = "Nome";
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.ReadOnly = true;
            // 
            // ColunaDestino
            // 
            this.ColunaDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColunaDestino.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColunaDestino.HeaderText = "Data";
            this.ColunaDestino.Name = "ColunaDestino";
            this.ColunaDestino.ReadOnly = true;
            // 
            // ColunaCliente
            // 
            this.ColunaCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColunaCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColunaCliente.HeaderText = "Origem";
            this.ColunaCliente.Name = "ColunaCliente";
            this.ColunaCliente.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Destino.DefaultCellStyle = dataGridViewCellStyle6;
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Horario.DefaultCellStyle = dataGridViewCellStyle7;
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // ConsultarAgendamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "ConsultarAgendamentoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HopeBus - Pesquisar Agendamento do Embarque";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelVendaDePassagensDeOnibus;
        private System.Windows.Forms.Label labelHopeBus;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.TextBox campoPesquisar;
        private System.Windows.Forms.Label labelAlterarAgendamento;
        private System.Windows.Forms.Label iconAlterarAgendamento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
    }
}
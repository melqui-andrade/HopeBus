using System.Drawing;
namespace HopeBus
{
    partial class LoginView
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelVendaDePassagensDeOnibus = new System.Windows.Forms.Label();
            this.labelHopeBus = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.iconSenha = new System.Windows.Forms.Label();
            this.iconUsuario = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.linkContato = new System.Windows.Forms.LinkLabel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(1189, 249);
            this.panelTop.TabIndex = 0;
            // 
            // labelVendaDePassagensDeOnibus
            // 
            this.labelVendaDePassagensDeOnibus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVendaDePassagensDeOnibus.AutoSize = true;
            this.labelVendaDePassagensDeOnibus.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendaDePassagensDeOnibus.Location = new System.Drawing.Point(431, 164);
            this.labelVendaDePassagensDeOnibus.Name = "labelVendaDePassagensDeOnibus";
            this.labelVendaDePassagensDeOnibus.Size = new System.Drawing.Size(308, 31);
            this.labelVendaDePassagensDeOnibus.TabIndex = 1;
            this.labelVendaDePassagensDeOnibus.Text = "Venda de Passagens de Ônibus";
            // 
            // labelHopeBus
            // 
            this.labelHopeBus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHopeBus.AutoSize = true;
            this.labelHopeBus.Font = new System.Drawing.Font("Tw Cen MT Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHopeBus.Location = new System.Drawing.Point(418, 53);
            this.labelHopeBus.Name = "labelHopeBus";
            this.labelHopeBus.Size = new System.Drawing.Size(336, 111);
            this.labelHopeBus.TabIndex = 0;
            this.labelHopeBus.Text = "HopeBus";
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelBottom.Controls.Add(this.linkContato);
            this.panelBottom.Controls.Add(this.iconSenha);
            this.panelBottom.Controls.Add(this.iconUsuario);
            this.panelBottom.Controls.Add(this.btnEntrar);
            this.panelBottom.Controls.Add(this.labelSenha);
            this.panelBottom.Controls.Add(this.labelUsuario);
            this.panelBottom.Controls.Add(this.campoSenha);
            this.panelBottom.Controls.Add(this.campoUsuario);
            this.panelBottom.ForeColor = System.Drawing.Color.White;
            this.panelBottom.Location = new System.Drawing.Point(0, 245);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1189, 419);
            this.panelBottom.TabIndex = 2;
            // 
            // iconSenha
            // 
            this.iconSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iconSenha.AutoSize = true;
            this.iconSenha.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconSenha.Location = new System.Drawing.Point(413, 186);
            this.iconSenha.Name = "iconSenha";
            this.iconSenha.Size = new System.Drawing.Size(39, 30);
            this.iconSenha.TabIndex = 6;
            this.iconSenha.Text = "";
            // 
            // iconUsuario
            // 
            this.iconUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iconUsuario.AutoSize = true;
            this.iconUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.iconUsuario.Location = new System.Drawing.Point(413, 111);
            this.iconUsuario.Name = "iconUsuario";
            this.iconUsuario.Size = new System.Drawing.Size(39, 30);
            this.iconUsuario.TabIndex = 5;
            this.iconUsuario.Text = "";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(457, 236);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(260, 53);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelSenha.Location = new System.Drawing.Point(452, 152);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(70, 30);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelUsuario.Location = new System.Drawing.Point(453, 76);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(83, 30);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuário";
            // 
            // campoSenha
            // 
            this.campoSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.campoSenha.BackColor = System.Drawing.Color.White;
            this.campoSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoSenha.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.campoSenha.Location = new System.Drawing.Point(458, 182);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(259, 39);
            this.campoSenha.TabIndex = 1;
            // 
            // campoUsuario
            // 
            this.campoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.campoUsuario.BackColor = System.Drawing.Color.White;
            this.campoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoUsuario.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.campoUsuario.Location = new System.Drawing.Point(458, 107);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(259, 39);
            this.campoUsuario.TabIndex = 0;
            // 
            // panelBackground
            // 
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1184, 661);
            this.panelBackground.TabIndex = 2;
            // 
            // linkContato
            // 
            this.linkContato.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.linkContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkContato.AutoSize = true;
            this.linkContato.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkContato.Location = new System.Drawing.Point(12, 394);
            this.linkContato.Name = "linkContato";
            this.linkContato.Size = new System.Drawing.Size(491, 13);
            this.linkContato.TabIndex = 8;
            this.linkContato.TabStop = true;
            this.linkContato.Text = "HopeBus - Venda de Passagens de Ônibus Ⓡ Daniel Marques. Melquisedec Andrade, Sid" +
    "ney Pimentel";
            this.linkContato.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContato_LinkClicked);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBackground);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HopeBus - Login";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHopeBus;
        private System.Windows.Forms.Label labelVendaDePassagensDeOnibus;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label iconSenha;
        private System.Windows.Forms.Label iconUsuario;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.LinkLabel linkContato;
    }
}


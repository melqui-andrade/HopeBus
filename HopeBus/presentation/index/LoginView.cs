﻿using HopeBus.presentation.index;
using HopeBus.presentation.Vendedor;
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
            if (loginEstaOk())
            {
                labelMensagem.Text = "";
                IndexVendedorView indexVendedorView = new IndexVendedorView();
                this.Hide();
                indexVendedorView.Closed += (s, args) => this.Close();
                indexVendedorView.WindowState = this.WindowState;
                indexVendedorView.Show();
            }
            else
            {
                labelMensagem.Text = "*Usuário ou senha não conferem";
            }
        }

        private void linkContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreditosView creditosView = new CreditosView();
            this.Hide();
            creditosView.Closed += (s, args) => this.Close();
            creditosView.WindowState = this.WindowState;
            creditosView.Show();
        }

        private bool loginEstaOk()
        {
            if (String.IsNullOrEmpty(campoUsuario.Text) || String.IsNullOrEmpty(campoSenha.Text))
            {
                return false;
            }
            else
            {
                String login = campoUsuario.Text;
                String senha = campoSenha.Text;
                VendedorMySql vendedorMySql = new VendedorMySql();
                if (vendedorMySql.VendedorEstaAutenticado(login, senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void campoSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnEntrar.PerformClick();
            }
        }        
    }
}

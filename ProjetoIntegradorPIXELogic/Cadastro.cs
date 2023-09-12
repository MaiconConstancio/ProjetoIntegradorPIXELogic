﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorPIXELogic
{
    public partial class Cadastro : System.Windows.Forms.Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (Funcoes.campoVazio("Nome", txtNome) == false && Funcoes.campoVazio("Endereço", txtEndereco) == false &&
                Funcoes.campoVazio("Telefone", txtTelefone) == false && Funcoes.campoVazio("CPF", txtCPF) == false &&
                Funcoes.campoVazio("CEP", txtCEP) == false && Funcoes.campoVazio("Número", txtNumero) == false &&
                Funcoes.campoVazio("Cidade", txtCidade) == false)
            {

                if (Funcoes.existe("clientes", "nome", txtNome) == false)
                {

                    if (Funcoes.existe("clientes", "telefone", txtTelefone) == false)
                    {

                        if (Funcoes.existe("clientes", "CPF", txtCPF) == false)
                        {

                            if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                            $"Endereço: {txtEndereco.Text}\n\n" +
                            $"Telefone: {txtTelefone.Text}\n\n" +
                            $"CNPJ: {txtCPF.Text}\n\n" +
                            $"CEP: {txtCEP.Text}\n\n" +
                            $"Número: {txtNumero.Text}\n\n" +
                            $"Cidade: {txtCidade.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                            {

                                string query = $"insert into clientes (nome,endereco,telefone,cpf,cep,numero,cidade) values " +
                                    $"('{txtNome.Text}','{txtEndereco.Text}','{txtTelefone.Text}','{txtCPF.Text}','{txtCEP.Text}','{txtNumero.Text}','{txtCidade.Text}');";
                                Conexao.executaQuery(query);

                                txtNome.Clear();
                                txtEndereco.Clear();
                                txtTelefone.Clear();
                                txtCPF.Clear();
                                txtCEP.Clear();
                                txtCidade.Clear();
                                txtNumero.Clear();

                            }

                        }

                        else { MessageBox.Show("Por favor digite outro CPF.", "CPF já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.panel1.Controls.Clear();
            Lista lista = new Lista();
            lista.TopLevel = false;
            Form1.panel1.Controls.Add(lista);
            lista.Show();


        }
    }
}

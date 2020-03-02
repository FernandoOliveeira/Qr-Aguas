﻿using QrAguas.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.View_Layer
{
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
        }

        public int IdCategoria { private get; set; }
        public string Categoria { private get; set; }

        Functions functions = new Functions();

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            txtAtualizarCategoria.Text = Categoria;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("O campo 'Categoria' está vazio.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (functions.AtualizarCategoria(IdCategoria, txtAtualizarCategoria.Text.Trim()))
                    {
                        MessageBox.Show("Atualizado com sucesso !", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RegisterCategory.UpdateCategoryResultado = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                catch (Exception erro)
                {

                    MessageBox.Show("Erro ao atualizar \nErro: " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CamposVazios()
        {
            if (txtAtualizarCategoria.Text.Trim().Equals("") || txtAtualizarCategoria.Text.Trim().Equals(null))
            {
                return true;
            }

            return false;
        }
    }
}

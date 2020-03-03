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
    public partial class RegisterProduct : Form
    {
        public RegisterProduct()
        {
            InitializeComponent();
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            // Atualiza o DropDownListFornecedores com a lista de Fornecedores
            this.fornecedoresTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductFornecedores.fornecedores);
            
            
            // Atualiza o DropDownListCategorias com a lista de Categorias
            this.categoriasTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductCategorias.categorias);

        }

        private void TxtCategoria_Click(object sender, EventArgs e)
        {
            // Atualiza o DropDownListCategorias com a lista de Categorias
            this.categoriasTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductCategorias.categorias);
        }

        private void TxtFornecedor_Click(object sender, EventArgs e)
        {
            // Atualiza o DropDownListFornecedores com a lista de Fornecedores
            this.fornecedoresTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductFornecedores.fornecedores);
        }
    }
}

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
    public partial class RegisterCategory : Form
    {
        public RegisterCategory()
        {
            InitializeComponent();
        }

        private void RegisterCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_0ybkkaeekeDataSetCategoria.categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this._0ybkkaeekeDataSetCategoria.categorias);

        }
    }
}

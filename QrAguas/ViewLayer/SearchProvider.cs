using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.ViewLayer
{
    public partial class SearchProvider : Form
    {
        public SearchProvider()
        {
            InitializeComponent();
        }

        private void SearchProvider_Load(object sender, EventArgs e)
        {
            // Atualiza os dados no DGVFornecedores
            this.fORNECEDORESTableAdapter.Fill(this.qrAguasRemoteDBDataSet.FORNECEDORES);

            

        }
    }
}

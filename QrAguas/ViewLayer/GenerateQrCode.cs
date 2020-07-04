using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QrAguas.ViewLayer
{
    public partial class GenerateQrCode : Form
    {
        public string NomeProduto { get; internal set; }
        public DateTime DataValidade { get; internal set; }

        public GenerateQrCode()
        {
            InitializeComponent();
        }

        private void GenerateQrCode_Load(object sender, EventArgs e)
        {
            // Tamanho mínimo do form
            this.MaximumSize = new Size(940, 470);
            

            // Nome do produto
            txtNomeProduto.Text = NomeProduto;

            if (DataValidade.ToString() != "01/01/0001 00:00:00")
            {
                // Valor mínimo do DateTimePicker
                DTPValidade.MinDate = DataValidade;

                // Recebe o valor da proriedade
                DTPValidade.Value = DataValidade;
                
            }
            else
            {
                DataValidade = DateTime.Now;
            }
            
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("Um ou mais campos estão vazios ou incompletos. \n Verifique antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {

                // texto que será transformado em Qr Code
                string qrCodeText = "Produto: " + txtNomeProduto.Text.Trim() + "\n"
                                + "Data de Validade: " + DTPValidade.Text + "\n"
                                + "Nome do Distribuidor: " + txtNomeEmpresa.Text.Trim() + "\n"
                                + "Telefone: " + txtTelefone.Text.Trim();

                // Instanciação do gerador de Qr Code
                QRCodeGenerator qrCode = new QRCodeGenerator();
                QRCodeData dados = qrCode.CreateQrCode(qrCodeText, QRCodeGenerator.ECCLevel.M);
                QRCode code = new QRCode(dados);

                // Insere o QrCode no PictureBox
                PBQrCode.Image = code.GetGraphic(50);
            }

            
            
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("Um ou mais campos estão vazios ou imcompletos. \n Verifique antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PBQrCode.Image == null)
            {
                MessageBox.Show("O Qr Code ainda não foi gerado. \nPor favor clique no botão 'Gerar Qr Code' antes de imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ImprimirQrCode();
            }
        }

        private void ImprimirQrCode()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += DocumentPrintPage;
            pd.Document = document;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void DocumentPrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(PBQrCode.Width, PBQrCode.Height);
            PBQrCode.DrawToBitmap(bitmap, new Rectangle(0, 0, PBQrCode.Width, PBQrCode.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap.Dispose();
        }

        private bool CamposVazios()
        {
            if (txtNomeProduto.Text.Trim() == "" ||
                txtNomeEmpresa.Text.Trim() == "" ||
                txtTelefone.Text.Length != 14)
            {
                return true;
            }

            return false;
        }
    }
}

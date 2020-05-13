using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.ViewLayer
{
    public partial class GenerateQrCode : Form
    {
        public GenerateQrCode()
        {
            InitializeComponent();
        }

        private void GenerateQrCode_Load(object sender, EventArgs e)
        {
            DTPValidade.MinDate = DateTime.Now;

            this.MinimumSize = new Size(939,470);
            this.MaximumSize = new Size(939, 470);
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("Um ou mais campos estão vazios ou incompletos. \n Verifique antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                // Gera o caminho da imagem a ser inserida no centro do Qr Code
                string path = Directory.GetCurrentDirectory();
                string newPath = Path.GetFullPath(Path.Combine(path, "..", "..", @".\Resources\qrAguasIconeGota.png"));

                // texto que será transformado em Qr Code
                string qrCodeText = "Produto: " + txtNomeProduto.Text.Trim() + "\n"
                                + "Data de Validade: " + DTPValidade.Text + "\n"
                                + "Nome do Distribuidor: " + txtNomeEmpresa.Text.Trim() + "\n"
                                + "Telefone: " + txtTelefone.Text.Trim();

                // Instanciação do gerador de Qr Code
                QRCodeGenerator qrCode = new QRCodeGenerator();
                QRCodeData dados = qrCode.CreateQrCode(qrCodeText, QRCodeGenerator.ECCLevel.M);
                QRCode code = new QRCode(dados);
                
                // Insere uma imagem no centro do Qr Code 
                PBQrCode.Image = code.GetGraphic(50, Color.Black, Color.White, (Bitmap)Image.FromFile(newPath));
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

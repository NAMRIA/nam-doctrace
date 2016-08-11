using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing.Printing;
using ZXing;

namespace DocTrace
{
    public partial class PrintDialogForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private PrintDocument Document = new PrintDocument();
        private List<GheloBytes.Paper.Coordinate> Coordinates = new List<GheloBytes.Paper.Coordinate>();
        private string _BarCodeText;

        public PrintDialogForm(string barCode, DateTime dateCreated)
        {
            InitializeComponent();
            _BarCodeText = String.Format("{0}  {1:MM/dd/yyyy}", barCode, dateCreated); ;
        }
        private void PrintDialog_Load(object sender, EventArgs e)
        {
            GetPrinterName();
            
            this.Document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {

            PaperSize custom = new PaperSize("Custom Size", 200, 50);

            Document.DefaultPageSettings.PaperSize = custom;
            Document.PrinterSettings.DefaultPageSettings.PaperSize = custom;

            IBarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE, Options = new ZXing.Common.EncodingOptions { Width = 100, Height = 100 } };

            Bitmap result = writer.Write(this._BarCodeText);


            Graphics g = e.Graphics;
            Font fontOffice = new System.Drawing.Font("Arial", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Font fontNamria = new System.Drawing.Font("Arial", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Font fontNormal = new System.Drawing.Font("Courier New", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            // draw QR code
            g.DrawImage(result, 142, -2, 60, 60);

            // prepare text offset
            Point textLocation = new Point(-34, 1);

            // draw Office of the Administrator
            g.DrawString("Office of the Administrator", fontOffice, Brushes.Black, textLocation.X + 89, textLocation.Y +  10);

            // draw NAMRIA
            g.DrawString("National Mapping and Resource", fontNamria, Brushes.Black, textLocation.X + 92, textLocation.Y + 20);
            g.DrawString("Information Authority", fontNamria, Brushes.Black, textLocation.X + 107, textLocation.Y + 27);

            // draw code
            g.DrawString(this._BarCodeText, fontNormal, Brushes.Black, textLocation.X + 90, textLocation.Y + 35);

        }
        private void btnChangePrinter_Click(object sender, EventArgs e)
        {
            SetPrinter();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!GheloBytes.IsNumeric(txtCopies.Text))
            {
                MessageBox.Show("Enter a valid value for copies.");
                return;
            }
            int copies = Convert.ToInt32(txtCopies.Text);

            this.Document.PrinterSettings.Copies = (short)copies;

            this.Hide();
            this.Document.Print();
            this.Close();
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SetDefaultPageSize()
        {
            Document.DefaultPageSettings.PaperSize = new PaperSize(GheloBytes.Paper.Default.Name, GheloBytes.ToHundredInches(GheloBytes.Paper.Default.Width), GheloBytes.ToHundredInches(GheloBytes.Paper.Default.Height));
        }
        private void SetPrinter()
        {
            PrintDialog dialog = new PrintDialog();
            dialog.Document = Document;
            dialog.ShowDialog();

            // save selected printer
            GheloBytes.SaveSetting("printing", "printer", "default", Document.DefaultPageSettings.PrinterSettings.PrinterName);

            GetPrinterName();
        }
        private void GetPrinterName()
        {
            string printerName = GheloBytes.GetSetting("printing", "printer", "default");
            lblPrinterName.Text = printerName;
            Document.PrinterSettings.PrinterName = printerName;
            Document.PrintController = new StandardPrintController();
        }

        private void PrintDialogForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnOk.PerformClick();
        }



        



    }
}
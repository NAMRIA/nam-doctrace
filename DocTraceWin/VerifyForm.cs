using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Touchless.Vision.Camera;
using ZXing;
using System.Data.SqlClient;

namespace DocTrace
{
    public partial class VerifyForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {


        CameraFrameSource frameSrc = null;
        Bitmap latestCapture;
       
        public VerifyForm()
        {
            InitializeComponent();

            latestCapture = new Bitmap(picCapture.Width, picCapture.Height);

        }

        private void lnkClose_LinkClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartCapture()
        {
            lnkNewScan.Hide();
            if (CameraService.DefaultCamera == null)
                return;

            Camera cam = CameraService.DefaultCamera;
            frameSrc = new CameraFrameSource(cam);

            frameSrc.NewFrame += frameSrc_NewFrame;
            picCapture.Paint += new PaintEventHandler(picCapture_Paint);


            frameSrc.StartFrameCapture();
        }

        private void frameSrc_NewFrame(Touchless.Vision.Contracts.IFrameSource arg1, Touchless.Vision.Contracts.Frame arg2, double arg3)
        {
            latestCapture = arg2.Image;
            picCapture.Invalidate();
        }

        private void picCapture_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(latestCapture, picCapture.Bounds);

            var reader = new BarcodeReader();
            var result = reader.Decode(latestCapture);

            System.Diagnostics.Debug.Print("Result: " + result);


            if (result != null)
            {
                if (frameSrc != null)
                {

                    frameSrc.StopFrameCapture();
                    picCapture.Paint -= picCapture_Paint;
                    frameSrc.NewFrame -= frameSrc_NewFrame;
                    frameSrc.Camera.Dispose();
                }

                string str = result.Text;

                while(str.Contains("  "))
                {
                    str = str.Replace("  ", " ");
                }

                string[] arr = str.Split(' ');

                string barCode = arr[0];
                string dateCreated = arr[1];

                txtQRCode.Text = arr[0];
                txtDateCreated.Text = arr[1];

                picCapture.Refresh();

                lnkNewScan.Show();

                DisplayDocument(barCode);

                //picCapture.Invalidate();
                //e.Graphics.DrawImage(latestCapture, picCapture.Bounds);
            
            }

        }

        private void VerifyForm_Load(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void lnkNewScan_LinkClicked(object sender, EventArgs e)
        {
            StartCapture();
        }



        private void DisplayDocument(string code)
        {

            using (SqlConnection conn = new SqlConnection(GheloBytes.ConnectionStringDecrypted(2)))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("SELECT BarCode, DateCreated, Title, Snapshot FROM [Transactions] WHERE BarCode = '{0}' ", code), conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtDateCreated.Text = dr["DateCreated"].ToString();
                    txtTitle.Text = dr["Title"].ToString();

                    byte[] bytes = (byte[])dr["Snapshot"];

                    string fileName = Environment.CurrentDirectory + "\\guide.pdf";

                    System.IO.File.WriteAllBytes(fileName, bytes);

                    pdfViewer.FileName = fileName;
                    pdfViewer.Update();
                    

                }
            
            }

        }

    }
}

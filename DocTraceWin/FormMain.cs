using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Drawing.Printing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

namespace DocTrace
{
    public partial class FormMain : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public static string UserName;
        private static string OfficeCode;


        public FormMain()
        {
            
            InitializeComponent();

            this.Size = new Size(685, 442);
            foreach (Control ctrl in kryptonPanel.Controls) { ctrl.Dock = DockStyle.Fill; };
            pnlLogin.BringToFront();


            

            //debug
            //pnlPrint.BringToFront();
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            PanelSwitcher(pnlSetDetails);
        }
        private void lnkUploadSelectFile_LinkClicked(object sender, EventArgs e)
        {


            //OpenFileDialog fileOpen = new OpenFileDialog();
            //fileOpen.Filter = "PDF (*.pdf)|*.pdf";
            //fileOpen.ShowDialog();
            //if (System.IO.File.Exists(fileOpen.FileName))
            //    pdfViewer1.FileName = fileOpen.FileName;

           
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "PDF/Image Files|*.pdf;*.jpg;*.png;*.bmp";
            fileOpen.Multiselect = true;
            //fileOpen.Filter = "PDF|*.pdf|Image Files|*.jpg;*.png;*.bmp";
            fileOpen.ShowDialog();

            if (fileOpen.FileNames.Length == 0)
                return;
            

            string extension = String.Empty;

            List<string> fileNames = new List<string>();
            foreach (string file in fileOpen.FileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (extension == String.Empty)
                    extension = fileInfo.Extension.ToLower();
                else if (extension != fileInfo.Extension.ToLower())
                {
                    MessageBox.Show("Cannot use multiple types!");
                    return;
                }
                fileNames.Add(file);
            }
            // determine if pdf or jpg
            FileInfo firstFile = new FileInfo(fileNames[0]);

            if (firstFile.Extension == ".pdf")
                pdfViewer.FileName = firstFile.FullName;
            else
            {
                CreatePDFFromImage(fileOpen.FileNames);
                string filename = Environment.CurrentDirectory + "\\temp.pdf";
                pdfViewer.FileName = filename;
            }


        }
        private void btnSetDetailsNext_Click(object sender, EventArgs e)
        {
            // validate entry
            if (txtTitle.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Document title cannot be empty.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!System.IO.File.Exists(pdfViewer.FileName))
            {
                MessageBox.Show("Please attach the scanned PDF file of the document.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (SaveRecord())
            {
                PanelSwitcher(pnlPrint);
            }else 
            {
                MessageBox.Show("An error occured! \nThis transaction was cancelled.\nContact the administrator for help. \n\n The application will now close.", "Error!", MessageBoxButtons.OK);
                Application.Exit();
            }
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string officeCode = "";
            if (IsValidUser(txtUsername.Text, txtPassword.Text, ref officeCode))
            {
                FormMain.UserName = txtUsername.Text;
                FormMain.OfficeCode = officeCode;

                PanelSwitcher(pnlStart);
            }
            else
            {
                MessageBox.Show("Invalid user name / password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void lnkProcessAnother_LinkClicked(object sender, EventArgs e)
        {
            txtTitle.Text = String.Empty;
            pdfViewer.CloseFile();
            cmbDateTime.Value = DateTime.Now;

            pnlStart.BringToFront();
        }
        private void btnPrintFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lnkReprint_LinkClicked(object sender, EventArgs e)
        {
            ReprintDialogForm frm = new ReprintDialogForm();
            frm.ShowDialog();
        }

        private void lnkPrint_LinkClicked(object sender, EventArgs e)
        {

            string barCode = txtQRCode.Text;
            DateTime dateCreated = Convert.ToDateTime(lnkPrint.Tag);

            PrintDialogForm frm = new PrintDialogForm(barCode, dateCreated);

            frm.ShowDialog();

        }
     
        private void PanelSwitcher(KryptonPanel pnl)
        {
            pnl.BringToFront();
        }
        private bool SaveRecord()
        {
            using(SqlConnection conn = new SqlConnection(GheloBytes.ConnectionStringDecrypted(2)))
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();
                string sqlInsert = String.Format("INSERT INTO [Transactions](Sequence, BarCode, Title, DocDate, Snapshot, Username, DateCreated) VALUES(@Sequence, @BarCode, @Title, @DocDate, @Snapshot, @Username, GetDate());");
                string sqlGetDate = String.Format("SELECT DateCreated FROM [Transactions] WHERE Sequence = @Sequence;");
                SqlCommand cmd = new SqlCommand(sqlInsert, conn, trans);
                

                // define parameters
                cmd.Parameters.Add("@Sequence", SqlDbType.Int);
                cmd.Parameters.Add("@BarCode", SqlDbType.VarChar);
                cmd.Parameters.Add("@Title", SqlDbType.VarChar);
                cmd.Parameters.Add("@DocDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@Snapshot", SqlDbType.VarBinary);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar);

                // generate bar code
                int sequence = GetNextSequence();

                Random rand = new Random();
                string randString1 = Convert.ToChar(rand.Next(65, 90)).ToString();
                string randString2 = Convert.ToChar(rand.Next(65, 90)).ToString();
                //randString1 = (FormMain.OfficeCode ? "0" : "0");
                //randString2 = (FormMain.OfficeCode ? "0" : "0");
                //string barCode = String.Format("{0}-{1}{2}",sequence, randString1, randString2);
                string barCode = String.Format("{0}-{1}", sequence, FormMain.OfficeCode);

                
                // set parameters
                cmd.Parameters["@Sequence"].Value = sequence;
                cmd.Parameters["@BarCode"].Value = barCode;
                cmd.Parameters["@Title"].Value = txtTitle.Text;
                cmd.Parameters["@DocDate"].Value = cmbDateTime.Value;
                cmd.Parameters["@Snapshot"].Value = SnapShot(pdfViewer.FileName);
                cmd.Parameters["@Username"].Value = txtUsername.Text;



                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        trans.Commit();

                        cmd = new SqlCommand(sqlGetDate, conn);
                        cmd.Parameters.Add(new SqlParameter("@Sequence", sequence));

                        DateTime dateCreated = (DateTime)cmd.ExecuteScalar();

                        //lblBarCode.Text = String.Format("{0}", barCode);
                        txtQRCode.Text = barCode;
                        //lblBarCodeValue.Text = String.Format("{0}  {1:MM/dd/yyyy}", barCode, dateCreated);

                        lnkPrint.Tag = dateCreated;
                        
                        return true;
                    }
                    else
                    {
                        trans.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    trans.Rollback();
                    return false;
                }
                
                   
            }
 
        }
        private byte[] SnapShot(string fileName)
        {
            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            byte[] fileByte = new byte[fs.Length];
            fs.Read(fileByte, 0, (int)fs.Length);
            return fileByte;
        }
        private int GetNextSequence()
        {
           using (SqlConnection conn = new SqlConnection(GheloBytes.ConnectionStringDecrypted(2)))
            {
                conn.Open();
                string strSelect = String.Format("SELECT ISNULL(MAX(Sequence), CAST(YEAR(getDate())-2000 AS VARCHAR) + '000' )  FROM [Transactions];");
                SqlCommand cmd = new SqlCommand(strSelect, conn);

                object result = cmd.ExecuteScalar();
                return (int)result + 1;
            }
        }
        private bool IsValidUser(string username, string password, ref string officeCode)
        {
            password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(GheloBytes.ConnectionStringDecrypted(2)))
            {
                string sql = String.Format("SELECT COUNT(*) FROM [Users] WHERE Username = '{0}' AND Password = '{1}'", username, password);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);
                conn.Open();


                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    sql = String.Format("SELECT OfficeCode FROM [Users] WHERE Username = '{0}' AND Password = '{1}'", username, password);
                    cmd.CommandText = sql;
                    officeCode= (string)cmd.ExecuteScalar();
                    return true;
                }
            };

            return false;
        }

        private void lnkChangePassword_LinkClicked(object sender, EventArgs e)
        {
            if (pnlNewPassword.Visible)
            {
                lnkChangePassword.Text = "Change password";
                pnlNewPassword.Hide();
            }
            else
            {
                lnkChangePassword.Text = "Cancel change password";
                pnlNewPassword.Show();
            }
        }

        private void lnkSetPassword_LinkClicked(object sender, EventArgs e)
        {
            
            if (txtNewPassword.Text != txtNewPasswordConfirm.Text)
            {
                MessageBox.Show("New password did not match!");
                return;
            }

            string officeCode = "";
            if (IsValidUser(txtUsername.Text, txtPassword.Text, ref officeCode))
            {
                FormMain.UserName = txtUsername.Text;
                FormMain.OfficeCode = officeCode;

                if (SetPassword(txtNewPassword.Text))
                {
                    pnlNewPassword.Hide();
                    txtPassword.Clear();
                    lnkChangePassword.Text = "Change password";
                }
            }
            else
            {
                MessageBox.Show("Invalid user name / password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private bool SetPassword(string password)
        {
            password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
            using (SqlConnection conn = new SqlConnection(GheloBytes.ConnectionStringDecrypted(2)))
            {
                conn.Open();

                string sql = String.Format("UPDATE [Users] SET [Password] = '{0}' WHERE [Username] = '{1}';", password, FormMain.UserName);
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        //////private byte[] CreatePDFFromImage(string[] files)
        //////{

        //////    List<string> filenames = new List<string>();

        //////    foreach (string file in files)
        //////    {
        //////        filenames.Add(file);
        //////    }
        //////    filenames.Sort();

        //////    using(System.IO.MemoryStream ms = new System.IO.MemoryStream())
        //////    {
        //////        PdfDocument doc = new PdfDocument();

        //////        foreach(string filename in filenames)
        //////        {
        //////            doc.Pages.Add(new PdfPage());
        //////            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);
        //////            XImage img = XImage.FromFile(filename);

        //////            xgr.DrawImage(img, 0, 0);
        //////        }
            
        //////        doc.Save(ms,true);
        //////        doc.Close();

        //////        byte[] fileByte = new byte[ms.Length];
        //////        ms.Read(fileByte, 0, (int)ms.Length);
        //////        return fileByte;
        //////    }

        ////// }

        private void CreatePDFFromImage(string[] files)
        {

            List<string> filenames = new List<string>();

            foreach (string file in files)
            {
                filenames.Add(file);
            }
            filenames.Sort();

            using (System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + "\\temp.pdf", FileMode.Create))
            {
                PdfDocument doc = new PdfDocument();

                int i = 0;
                foreach (string filename in filenames)
                {
                    doc.Pages.Add(new PdfPage());
                    XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);
                    XImage img = XImage.FromFile(filename);
                    xgr.DrawImage(img, 0, 0);
                    xgr.Dispose();
                    i++;
                }

                doc.Save(fs, true);
                doc.Close();                
            }

        }

        private void lblVerify_LinkClicked(object sender, EventArgs e)
        {
            VerifyForm frm = new VerifyForm();

            frm.ShowDialog();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnLogin.PerformClick();
        }



     }
}
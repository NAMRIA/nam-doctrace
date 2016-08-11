using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace DocTrace
{   
    public partial class ReprintDialogForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        

        public ReprintDialogForm()
        {
            InitializeComponent();
        }

        private void lnkCancel_LinkClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string barCode = txtBarcode.Text;
            string barCodeSymbol = String.Format("*{0}*",barCode);

            
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(GheloBytes.ConnectionStringDecrypted(2)))
            {
                string sql = String.Format("SELECT * FROM [Transactions] WHERE Username = '{0}' AND BarCode = '{1}'", FormMain.UserName, barCode);    
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    this.Hide();
                    //barCodeText = String.Format("{0}  {1:MM/dd/yyyy}", barCode, reader["DateCreated"]);

                    PrintDialogForm frm = new PrintDialogForm(barCode, Convert.ToDateTime(reader["DateCreated"]));
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    // barcode doesn't exist
                    MessageBox.Show("The Barcode doesn't exists.");
                    return;
                }
                
            }




        }


       

    }
}
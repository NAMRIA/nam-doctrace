using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

namespace DocTraceWeb
{
    public partial class pdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["doctraceConnectionString"].ConnectionString))
            {

                string barCode = Request.QueryString["barCode"].ToString();
                //string tableName = (barCode.Contains("-00") ? "TransactionAdmin" : "TransactionRecords");
                string tableName = "Transactions";
                string sql = String.Format("SELECT SnapShot FROM [{0}] WHERE BarCode = '{1}'", tableName, barCode);

                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string randomString = DateTime.Now.Ticks.ToString();

                    Response.Clear();
                    Response.AddHeader(@"Content-Disposition",
                                        String.Format(@"inline; filename=""{0}.pdf"" ", randomString));
                    Response.ContentType = "application/pdf";
                    Response.BinaryWrite((byte[])dr["SnapShot"]);
                    Response.End();
                }

            }
        }
    }
}

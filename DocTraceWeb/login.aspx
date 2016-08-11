<%@ Page Language="C#" %>
<%@ Import Namespace="System.Web.Security" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>


<script runat="server">
  private void Logon_Click(object sender, EventArgs e)
  {
    //if ((UserEmail.Text == "admin") && 
    //        (UserPass.Text == "admin"))
      if(Authenticate(UserEmail.Text, UserPass.Text))
      {
          FormsAuthentication.RedirectFromLoginPage 
             (UserEmail.Text, Persist.Checked);
      }
      else
      {
          Msg.Text = "Invalid credentials. Please try again.";
      }
  }


  private bool Authenticate(string u, string p)
  {
      string connectionString = "Data Source=192.168.8.16;Initial Catalog=doctrace;User ID=doctrace;Password=doctrace;";

      p = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(p, "SHA1");


      // Provide the query string with a parameter placeholder. 
      string queryString = "SELECT * FROM Users WHERE Username = @u ANd Password = @p";

      // Create and open the connection in a using block. This 
      // ensures that all resources will be closed and disposed 
      // when the code exits. 
      using (SqlConnection connection =
          new SqlConnection(connectionString))
      {
          // Create the Command and Parameter objects.
          SqlCommand command = new SqlCommand(queryString, connection);
          command.Parameters.AddWithValue("@u", u);
          command.Parameters.AddWithValue("@p", p);

          // Open the connection in a try/catch block.  
          // Create and execute the DataReader, writing the result 
          // set to the console window. 
          try
          {
              connection.Open();
              SqlDataReader reader = command.ExecuteReader();
              if (reader.Read())
              {
                  reader.Close();
                  return true;
              }
              reader.Close();
          }
          catch (Exception ex)
          {
              throw new Exception("Authentication error!", ex);
          }
          return false;
      }

  }
  
</script>
<html>
<head id="Head1" runat="server">
  <title>NAMRIA DocTrace Login</title>
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
        #form1
        {
            height: 226px;
        }
    </style>
</head>
<body style="width: 100%; font-family: Arial, Helvetica, sans-serif; height: 374px;">
  <form id="form1" runat="server">
    <br /><br /><br />
    <h3 style="text-align: center">
        NAMRIA Document Tracer (DocTrace) Records Viewer</h3>
    <p style="text-align: center">
        You are trying to access a secured page. </p>
    <p style="text-align: center">
        Please enter your credentials.</p>
    <table align="center">
      <tr>
        <td class="style1">
            Username:</td>
        <td class="style1">
          <asp:TextBox ID="UserEmail" runat="server" /></td>
        <td class="style1">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            ControlToValidate="UserEmail"
            Display="Dynamic" 
            ErrorMessage="Cannot be empty." 
            runat="server" />
        </td>
      </tr>
      <tr>
        <td>
          Password:</td>
        <td>
          <asp:TextBox ID="UserPass" TextMode="Password" 
             runat="server" />
        </td>
        <td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            ControlToValidate="UserPass"
            ErrorMessage="Cannot be empty." 
            runat="server" />
        </td>
      </tr>
      <tr style="display: none;">
        <td>
          Remember me?</td>
        <td>
          <asp:CheckBox ID="Persist" runat="server" /></td>
      </tr>
      <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
      </tr>
      <tr>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
    <asp:Button ID="Submit1" OnClick="Logon_Click" Text="Login" 
       runat="server" />
          </td>
      </tr>
    </table>
    <p style="text-align: center">
      <asp:Label ID="Msg" ForeColor="red" runat="server" style="text-align: center" />
    </p>
  </form>
</body>
</html>
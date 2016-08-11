<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        daDocTrace.FilterExpression = "Title LIKE '%" + txtFilter.Text + "%'";
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        daDocTrace.FilterExpression = "1=1";
        txtFilter.Text = "";
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>NAMRIA DocTrace Viewer</title>
    <script type="text/javascript">
 
        function popUp(barcode) {
            day = new Date();
            id = day.getTime();
            eval("page" + id + " = window.open('pdf.aspx?barCode=" + barcode + "', '" + id + "', 'toolbar=0,scrollbars=1,location=0,statusbar=0,menubar=0,resizable=1,width=600,height=650,left = 570,top = 200');");
        }
    
    </script>

    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <p>List of Recorded Documents</p>

        <p>
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" Text="Filter" onclick="btnFilter_Click" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
        </p>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Sequence" DataSourceID="daDocTrace" 
            Font-Names="Segoe UI,Tahoma,Verdana" AllowPaging="True" 
            EnableModelValidation="True">

            <Columns>
                <asp:BoundField DataField="Sequence" HeaderText="Sequence" ReadOnly="True" 
                    SortExpression="Sequence" />
                <asp:BoundField DataField="BarCode" HeaderText="Bar code" 
                    SortExpression="BarCode" >
                <ItemStyle Width="110px" />
                </asp:BoundField>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="OfficeName" HeaderText="Office" SortExpression="Title" />
                <asp:BoundField DataField="DocDate" DataFormatString="{0:MMM dd yyyy}" 
                    HeaderText="Document date" SortExpression="DocDate" />
                <asp:BoundField DataField="DateCreated" DataFormatString="{0:MMM dd yyyy}" 
                    HeaderText="Date created" SortExpression="DateCreated" />
                <asp:BoundField DataField="Username" HeaderText="Username" 
                    SortExpression="Username" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="javascript:popUp('<%# Eval("BarCode", "{0}") %>');">Open pdf</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No Matching Record
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:SqlDataSource ID="daDocTrace" runat="server" 
            ConnectionString="<%$ ConnectionStrings:doctraceConnectionString %>" 
            
            SelectCommand="SELECT Transactions.Sequence, Transactions.BarCode, Transactions.Title, Transactions.DocDate, Transactions.Username, Transactions.DateCreated, Offices.OfficeCode, Offices.OfficeName, Offices.OfficeHead FROM Transactions LEFT OUTER JOIN Offices ON SUBSTRING(Transactions.BarCode, 7, 2) = Offices.OfficeCode ORDER BY Transactions.DateCreated DESC"></asp:SqlDataSource>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Administrator validated documents</title>
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
    
        <p>Administrator's Documents</p>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Sequence" DataSourceID="daDocTrace" 
            Font-Names="Segoe UI, Tahoma, Verdana">
            <Columns>
                <asp:BoundField DataField="Sequence" HeaderText="Sequence" ReadOnly="True" 
                    SortExpression="Sequence" />
                <asp:BoundField DataField="BarCode" HeaderText="Bar code" 
                    SortExpression="BarCode" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
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
        </asp:GridView>
        <asp:SqlDataSource ID="daDocTrace" runat="server" 
            ConnectionString="<%$ ConnectionStrings:doctraceConnectionString %>" 
            SelectCommand="SELECT * FROM [Transactions] WHERE BarCode LIKE '%-00';"></asp:SqlDataSource>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

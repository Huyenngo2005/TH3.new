<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppAWeb.Default" Async="true"%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AppA - Client</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>AppA - Client</h2>
            Tên sản phẩm: <asp:TextBox ID="txtName" runat="server" /><br /><br />
            Giá: <asp:TextBox ID="txtPrice" runat="server" TextMode="Number" /><br /><br />              
            <asp:Button ID="btnSend" runat="server" Text="Gửi sang AppB" OnClick="btnSend_Click" /><br /><br />                        
            <asp:Label ID="lblResult" runat="server" Font-Bold="true" ForeColor="Blue" />
        </div>
    </form>
</body>
</html>
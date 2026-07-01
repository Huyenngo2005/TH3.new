<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppBWeb.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AppB - Server</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>AppB - Server</h2>
            <asp:Label ID="lblInfo" runat="server" Text="Chưa có dữ liệu từ Client" Font-Bold="true" /><br /><br />             
            <asp:Label ID="lblReceived" runat="server" /><br /><br />
            Phản hồi: <asp:TextBox ID="txtFeedback" runat="server" Width="300px" /><br /><br />
            <asp:Button ID="btnSendBack" runat="server" Text="Gửi phản hồi về AppA" OnClick="btnSendBack_Click" /><br /><br />                        
            <asp:Label ID="lblStatus" runat="server" ForeColor="Green" /> 
        </div>
    </form>
</body>
</html>
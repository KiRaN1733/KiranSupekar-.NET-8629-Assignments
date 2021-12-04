<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WCFservice.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Enter Id to delete record: "></asp:Label>
            <asp:TextBox ID="txtId3" runat="server" Height="22px"></asp:TextBox>
            <br />
            <asp:Button ID="btnDelete3" runat="server" OnClick="btnDelete3_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>

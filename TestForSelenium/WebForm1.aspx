<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestForSelenium.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label id="lblGender">Gender</label>
        <asp:TextBox ID="tbxGender" runat="server" style="margin-left: 43px" Width="150px"></asp:TextBox>
    </div>
        <div>
            <label id="lblAge">Age</label>
            <asp:TextBox ID="tbxAge" runat="server" style="margin-left: 64px" Width="146px"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>

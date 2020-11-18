<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="WebTech.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" />
    <title>Page Tow</title>
</head>
<body>
    <form id="form1" class="form" runat="server">
        <p>Click on button to change state of checkbox</p>
        <div class="form-group">
            <label>Is Checked</label>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </div>
        <asp:Button ID="Button1" CssClass="btn-primary" runat="server" Text="Change State" OnClick="Button1_Click" />
        <asp:HiddenField ID="openTimeHiddenField" runat="server" />
        <br />
        <span style="font-size:12px">if there is querystring or session value will show down</span><br />
        <div class="information>
            <p id="P1" runat="server" visible="false">Information From Query String</p>
            <p id="secondText" runat="server" visible="false"></p>
            <p id="firstText" runat="server" visible="false"></p>

            <p id="sessionCount" runat="server"></p>
            <p id="sessionValue" runat="server"></p>
        </div>
    </form>
</body>
</html>

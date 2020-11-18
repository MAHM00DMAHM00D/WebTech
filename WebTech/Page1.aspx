<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="WebTech.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" />
    <title>Page One</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <label>First Text</label>
            <asp:TextBox ID="txt_first" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Second Text</label>
            <asp:TextBox ID="txt_second" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <p>Click to move text from fist input field to the second one</p>
        <asp:Button ID="btn_move" CssClass="btn btn-primary" runat="server" Text="Move Text" OnClick="btn_move_Click" />
        <asp:label runat="server" ID="lbl_error" Visible="False"></asp:label>
        <asp:Button ID="btnSession" runat="server" CssClass="btn btn-primary" Text="Store First text within Session" OnClick="btnSession_Click" />
        <asp:Button ID="btnToHidden" runat="server" CssClass="btn btn-primary" Text="Store within Hidden Field" OnClick="btnToHidden_Click" />
        <asp:Button ID="btnQuery" runat="server" CssClass="btn btn-primary" Text="Send information to the Second Page" OnClick="btnQuery_Click" />
        <asp:Button ID="btnCookie" runat="server" CssClass="btn btn-primary" Text="Load default value from cookie" OnClick="btnCookie_Click" />
        <asp:HiddenField ID="txtSecondHiddenField" runat="server" />
        <asp:Button ID="btnRetreveFromHidden" Text="Click to retreve data from hidden field" runat="server" CssClass="btn btn-primary" OnClick="btnRetreveFromHidden_Click1" />
        <asp:Button ID="btnLike" Text="Like" runat="server" CssClass="btn btn-primary" OnClick="btnLike_Click" />
        <asp:Label ID="lblLike" runat="server" Text=""></asp:Label>
        <br />
        <span style="font-size:12px">*note:cookie expires after one hour</span>
    </form>
    
</body>
</html>

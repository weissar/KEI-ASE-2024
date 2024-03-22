<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <h1>KEI/ASE pokus ASPX</h1>
    <div>
      <asp:HiddenField ID="hfCounter" runat="server" Value="?" />
      <asp:Button ID="Button1" runat="server" Text="Press me ..." OnClick="Button1_Click" />
    </div>
    <div>
      <asp:GridView ID="gwData" runat="server" AutoGenerateColumns="True" 
        AlternatingRowStyle-BackColor="LightGreen" RowStyle-BackColor="LightPink">
      </asp:GridView>
    </div>
  </form>
</body>
</html>

<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="LoginControl" %>
<div>
<p><asp:Label ID="Label1" runat="server" Text="Podaj login:" Font-Bold="True" Font-Names="Times New Roman" Font-Overline="False" Font-Size="Large"></asp:Label></p>
    <p><asp:TextBox ID="tblogin" runat="server" Font-Names="Times New Roman" Font-Size="Medium"></asp:TextBox></p>
    <p><asp:Label ID="Label2" Font-Bold="True" Font-Names="Times New Roman" Font-Overline="False" Font-Size="Large" runat="server" Text="Podaj hasło:"></asp:Label></p>
    <p>
        <asp:TextBox ID="tbpassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
            <p><asp:Button ID="btlogin" Font-Names="Times New Roman" Font-Size="Medium" runat="server" Text="Zaloguj" OnClick="btlogin_Click" NavigateUrl="" CssClass="button" />
        </p>
    <p>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Pages/Account/Register.aspx" runat="server">Nie masz u nas konta?? Załóż teraz.</asp:HyperLink></p>
</div>



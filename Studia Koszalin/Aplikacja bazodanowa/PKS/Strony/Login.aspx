<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Strony_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p style="text-align:center;font-size:28px">
        Login:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tblogin"  runat="server" Height="24px" Width="130px"></asp:TextBox>
    </p>
<p style="text-align:center;font-size:28px"">
        Hasło:</p>
<p style="text-align:center">
        <asp:TextBox ID="tbhaslo" runat="server" TextMode="Password" Height="24px" Width="130px"></asp:TextBox>
    </p>
<p style="text-align:center">
        <asp:Button ID="btzaloguj" runat="server" OnClick="btzaloguj_Click" Text="Zaloguj" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    &nbsp;
        <asp:Button ID="btanuluj" runat="server" OnClick="btanuluj_Click" Text="Anuluj" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
</asp:Content>


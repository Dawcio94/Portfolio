<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Autokaryedycja.aspx.cs" Inherits="Strony_Autokary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p style="text-align:center">
    Numer rejestracyjny:</p>
<p style="text-align:center">
    <asp:TextBox ID="tbnrrejestr" runat="server"></asp:TextBox>
</p>
<p style="text-align:center">
    Marka:</p>
<p style="text-align:center">
    <asp:TextBox ID="tbmarka" runat="server"></asp:TextBox>
</p>
<p style="text-align:center">
    Model:</p>
<p style="text-align:center">
    <asp:TextBox ID="tbmodel" runat="server"></asp:TextBox>
</p>
<p style="text-align:center">
    Ilość miejsc:</p>
<p style="text-align:center">
    <asp:TextBox ID="tbiloscmiejsc" runat="server"></asp:TextBox>
</p>
<p style="text-align:center">
    Id kursu:</p>
<p style="text-align:center">
    <asp:TextBox ID="tbidkursu" runat="server"></asp:TextBox>
</p>
<p style="text-align:center">
    <asp:Button ID="btok" runat="server" OnClick="btok_Click" Text="Potwierdź" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
</p>
<p style="text-align:center">
    <asp:Label ID="lbwynik" runat="server"></asp:Label>
</p>
</asp:Content>


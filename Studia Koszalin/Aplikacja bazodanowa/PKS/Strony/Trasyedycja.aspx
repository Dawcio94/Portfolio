<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trasyedycja.aspx.cs" Inherits="Strony_Trasyedycja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p style="text-align:center">
        Id miejscowości początkowej:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbidmiastpocz" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Id miejscowości końcowej:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbidmiastkon" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Oznaczenie trasy:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tboznacztrasy" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        <asp:Button ID="btok" runat="server" OnClick="btok_Click" Text="Potwierdź" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
    <p style="text-align:center">
        <asp:Label ID="lbwynik" runat="server"></asp:Label>
    </p>
</asp:Content>


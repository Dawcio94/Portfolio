<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Miejscowosciedycja.aspx.cs" Inherits="Strony_Miejscowosciedycja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p style="text-align:center">
        Nazwa miejscowości:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbmiejsce" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        <asp:Button ID="btok" runat="server" Text="Potwierdź" OnClick="btok_Click1" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
    <p style="text-align:center">
        <asp:Label ID="lbwynik" runat="server"></asp:Label>
    </p>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kierowcaedycja.aspx.cs" Inherits="Strony_Kierowcaedycja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p style="text-align:center">
        Imie i nazwisko:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbdanekier" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Id_kursu:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbidkursu" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        <asp:Button ID="btok" runat="server" OnClick="btok_Click" Text="Potwierdź" BackColor="#009933" Font-Size="Large" ForeColor="White" Height="54px" Width="149px" />
    </p>
    <p style="text-align:center">
        <asp:Label ID="lbwynik" runat="server"></asp:Label>
    </p>
</asp:Content>


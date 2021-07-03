<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Przebiegedycja.aspx.cs" Inherits="Strony_Przebiegedycja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p style="text-align:center">
        Id miejscowość:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbidmiej" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Id trasy:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbidtrasy" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Godzina odjazdu:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbgodzina" runat="server"></asp:TextBox>
    </p>
    
    <p style="text-align:center">Kolejność</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbkolej" runat="server" style="margin-left:auto;margin-right:auto"></asp:TextBox>
    </p>
    <p style="text-align:center">
<asp:Button ID="btok" runat="server" OnClick="btok_Click1" Text="Potwierdź" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
    <p>
        <asp:Label ID="lbwynik" runat="server" style="margin-left:auto;margin-right:auto"></asp:Label>
    </p>
    
    
    
</asp:Content>


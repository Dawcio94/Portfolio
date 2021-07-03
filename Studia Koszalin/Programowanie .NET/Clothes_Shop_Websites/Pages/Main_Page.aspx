<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main_Page.aspx.cs" Inherits="Pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="LoginView" style="font-size: large">
        <center><h2><asp:LoginView ID="LoginView1" runat="server">

            <LoggedInTemplate>
                Witaj
                                <asp:LoginName ID="LoginName1" runat="server" />
            </LoggedInTemplate>
        </asp:LoginView></h2></center>
    </div>
    <asp:Image ID="Image4" runat="server" style="float:right" ImageUrl="~/Images/advert.PNG" Width="50%" Height="651px" />
    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/gifmain.gif" />
    <asp:Image ID="Image3" runat="server" Height="315px" ImageUrl="~/Images/gifmain1.gif" Width="500px" />
    </asp:Content>


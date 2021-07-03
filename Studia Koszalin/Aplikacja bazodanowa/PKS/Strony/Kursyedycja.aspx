<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kursyedycja.aspx.cs" Inherits="Strony_Kursyedycja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align:center">
        &nbsp;</p>
<p style="text-align:center">
        &nbsp;</p>
    <p style="text-align:center">
        Oznaczenie kursu:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tboznkursu" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Data kursu:</p>
    <p style="text-align:center">
        <asp:Calendar ID="cdata" runat="server" style="margin-left:450px" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
    </p>
    <p style="text-align:center">
        Ilość pasażerów:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbiloscpas" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Czas rozpoczęcia kursu:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbgodz" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
        Id_trasy:</p>
    <p style="text-align:center">
        <asp:TextBox ID="tbidtrasy" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center; height: 116px;">
        <asp:Button ID="btok" runat="server" Text="Potwierdź" OnClick="btok_Click1" />
    </p>
    <p style="text-align:center">
        <asp:Label ID="lbwynik" runat="server"></asp:Label>
    </p>
</asp:Content>


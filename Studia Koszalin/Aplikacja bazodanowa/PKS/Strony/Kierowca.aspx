<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kierowca.aspx.cs" Inherits="Strony_Kierowca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    
    <asp:Button ID="bddodajkierowca" runat="server" Text="Dodaj kierowcę" Height="54px" OnClick="bddodajkierowca_Click" Width="139px" BackColor="#009933" Font-Size="Large" ForeColor="White"  />
    <asp:Button ID="Button1" runat="server" Text="Wyszukaj aktualnie w trasie" Height="54px" Width="238px" BackColor="#009933" Font-Size="Large" ForeColor="White" OnClick="Button1_Click" />
<br />
<br />
<br />
    <asp:Label ID="Label1" runat="server" style="margin-left:150px" Text="Dane kierowcy:"></asp:Label>
    <asp:Label ID="Label2" runat="server" style="float:right;margin-right:255px" Text="Aktualnie w trasie:"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="float:right;margin-right:150px" DataKeyNames="Id_kierowcy"  CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id_kierowcy" HeaderText="Id_kierowcy" ItemStyle-HorizontalAlign ="Right" InsertVisible="False" ReadOnly="True" SortExpression="Id_kierowcy" />
            <asp:BoundField DataField="Imie_Nazwisko" HeaderText="Imie_Nazwisko" ItemStyle-HorizontalAlign ="Right" SortExpression="Imie_Nazwisko" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    
    <asp:SqlDataSource ID="sdskierowcawtrasie" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" ></asp:SqlDataSource>
<asp:GridView ID="gvkierowcy" runat="server" style="margin-left:150px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_kierowcy" DataSourceID="sdskierowca" OnRowEditing="gvkierowcy_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id_kierowcy" HeaderText="Id_kierowcy" ItemStyle-HorizontalAlign ="Right" InsertVisible="False" ReadOnly="True" SortExpression="Id_kierowcy" />
        <asp:BoundField DataField="Imie_Nazwisko" HeaderText="Imie_Nazwisko" ItemStyle-HorizontalAlign ="Right" SortExpression="Imie_Nazwisko" />
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
<asp:SqlDataSource ID="sdskierowca" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" DeleteCommand="DELETE FROM [Kierowca] WHERE [Id_kierowcy] = @Id_kierowcy" InsertCommand="INSERT INTO [Kierowca] ([Id_kursu], [Imie_Nazwisko]) VALUES (@Id_kursu, @Imie_Nazwisko)" SelectCommand="SELECT * FROM [Kierowca]" UpdateCommand="UPDATE [Kierowca] SET [Id_kursu] = @Id_kursu, [Imie_Nazwisko] = @Imie_Nazwisko WHERE [Id_kierowcy] = @Id_kierowcy">
    <DeleteParameters>
        <asp:Parameter Name="Id_kierowcy" Type="Decimal" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Id_kursu" Type="Decimal" />
        <asp:Parameter Name="Imie_Nazwisko" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Id_kursu" Type="Decimal" />
        <asp:Parameter Name="Imie_Nazwisko" Type="String" />
        <asp:Parameter Name="Id_kierowcy" Type="Decimal" />
    </UpdateParameters>
</asp:SqlDataSource>
<br />
</asp:Content>


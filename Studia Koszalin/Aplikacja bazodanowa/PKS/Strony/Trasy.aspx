<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trasy.aspx.cs" Inherits="Strony_Trasy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <asp:Button ID="btdodajprzeb" runat="server" OnClick="btdodajprzeb_Click" Text="Dodaj trasę" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView3" style="float:right;margin-right:225px" runat="server" AllowPaging="True"  AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id_miejscowosci" DataSourceID="sdsmiastokon" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nazwa_miejscowosci" ItemStyle-HorizontalAlign ="Right" HeaderText="Nazwa_miejscowosci_koniec" SortExpression="Nazwa_miejscowosci" />
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
        <asp:GridView ID="GridView2" runat="server" style="float:right;margin-right:0px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_miejscowosci" DataSourceID="sdsmiastopocz" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nazwa_miejscowosci" ItemStyle-HorizontalAlign ="Right" HeaderText="Nazwa_miejscowosci_poczatek" SortExpression="Nazwa_miejscowosci" />
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
        <asp:GridView ID="GridView1" runat="server"  AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" style="float:right" DataKeyNames="Id_trasy" DataSourceID="sdstrasy" OnRowEditing="GridView1_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id_trasy" HeaderText="L.p." InsertVisible="False" ItemStyle-HorizontalAlign ="Right" ReadOnly="True" SortExpression="Id_trasy" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Oznaczenie_trasy" ItemStyle-HorizontalAlign ="Right" HeaderText="Oznaczenie_trasy" SortExpression="Oznaczenie_trasy" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
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
        <asp:SqlDataSource ID="sdsmiastokon" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" SelectCommand="SELECT * FROM [Miejscowości]"></asp:SqlDataSource>
        
        <asp:SqlDataSource ID="sdsmiastopocz" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" SelectCommand="SELECT * FROM [Miejscowości] "></asp:SqlDataSource>
        <asp:SqlDataSource ID="sdstrasy" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" DeleteCommand="DELETE FROM [Trasa] WHERE [Id_trasy] = @Id_trasy" InsertCommand="INSERT INTO [Trasa] ([Id_miejscowosci_poczatek], [Id_miejscowosci_koniec], [Oznaczenie_trasy]) VALUES (@Id_miejscowosci_poczatek, @Id_miejscowosci_koniec, @Oznaczenie_trasy)" SelectCommand="SELECT * FROM [Trasa]" UpdateCommand="UPDATE [Trasa] SET [Id_miejscowosci_poczatek] = @Id_miejscowosci_poczatek, [Id_miejscowosci_koniec] = @Id_miejscowosci_koniec, [Oznaczenie_trasy] = @Oznaczenie_trasy WHERE [Id_trasy] = @Id_trasy">
            <DeleteParameters>
                <asp:Parameter Name="Id_trasy" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id_miejscowosci_poczatek" Type="Decimal" />
                <asp:Parameter Name="Id_miejscowosci_koniec" Type="Decimal" />
                <asp:Parameter Name="Oznaczenie_trasy" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Id_miejscowosci_poczatek" Type="Decimal" />
                <asp:Parameter Name="Id_miejscowosci_koniec" Type="Decimal" />
                <asp:Parameter Name="Oznaczenie_trasy" Type="String" />
                <asp:Parameter Name="Id_trasy" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>


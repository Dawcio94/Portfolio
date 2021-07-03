<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Autokary.aspx.cs" Inherits="Strony_Autokary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <asp:Button ID="btdodajautokar" runat="server" OnClick="btdodajautokar_Click" Text="Dodaj autokar" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
<br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" style="margin-left:150px" Text="Dane autokaru:"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Dane kierowcy:" style="float:right;margin-right:180px" ></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="float:right;margin-right:150px" DataKeyNames="Id_kierowcy" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
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
    <asp:SqlDataSource ID="sdskierowca" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>"></asp:SqlDataSource>
    <asp:GridView ID="gvautokary" runat="server" style="margin-left:150px" AllowPaging="True" AllowSorting="True"  AutoGenerateColumns="False"  DataKeyNames="Id_autokaru" DataSourceID="sdsautokar" Width="40%" OnRowEditing="gvautokary_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvautokary_RowCommand">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        <asp:BoundField DataField="Id_autokaru" HeaderText="Id_autokaru" SortExpression="Id_autokaru" ItemStyle-HorizontalAlign ="Right" InsertVisible="False" ReadOnly="True" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Nr_rejestr" HeaderText="Nr_rejestr" SortExpression="Nr_rejestr" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Marka" HeaderText="Marka" SortExpression="Marka" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Liczba_miejsc" HeaderText="Liczba_miejsc" SortExpression="Liczba_miejsc" ItemStyle-HorizontalAlign ="Right" >
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
<asp:SqlDataSource ID="sdsautokar" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" DeleteCommand="DELETE FROM [Autokar] WHERE [Id_autokaru] = @Id_autokaru" InsertCommand="INSERT INTO [Autokar] ([Id_kursu], [Nr_rejestr], [Marka], [Model], [Liczba_miejsc]) VALUES (@Id_kursu, @Nr_rejestr, @Marka, @Model, @Liczba_miejsc)" SelectCommand="SELECT * FROM [Autokar]" UpdateCommand="UPDATE [Autokar] SET [Id_kursu] = @Id_kursu, [Nr_rejestr] = @Nr_rejestr, [Marka] = @Marka, [Model] = @Model, [Liczba_miejsc] = @Liczba_miejsc WHERE [Id_autokaru] = @Id_autokaru">
    <DeleteParameters>
        <asp:Parameter Name="Id_autokaru" Type="Decimal" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Id_kursu" Type="Decimal" />
        <asp:Parameter Name="Nr_rejestr" Type="String" />
        <asp:Parameter Name="Marka" Type="String" />
        <asp:Parameter Name="Model" Type="String" />
        <asp:Parameter Name="Liczba_miejsc" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Id_kursu" Type="Decimal" />
        <asp:Parameter Name="Nr_rejestr" Type="String" />
        <asp:Parameter Name="Marka" Type="String" />
        <asp:Parameter Name="Model" Type="String" />
        <asp:Parameter Name="Liczba_miejsc" Type="Decimal" />
        <asp:Parameter Name="Id_autokaru" Type="Decimal" />
    </UpdateParameters>
</asp:SqlDataSource>
<br />
</asp:Content>


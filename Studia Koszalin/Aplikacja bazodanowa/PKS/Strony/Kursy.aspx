<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kursy.aspx.cs" Inherits="Strony_Kursy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <asp:Button ID="btdodajkurs" runat="server" Text="Dodaj kurs" OnClick="btdodajkurs_Click" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    <br />
    <br />
    <asp:GridView ID="gvkurs" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" style="margin-left:auto;margin-right:auto" DataKeyNames="Id_kursu" DataSourceID="sdskurs" OnRowEditing="gvkurs_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvkurs_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id_kursu" HeaderText="L.p." InsertVisible="False" ReadOnly="True" ItemStyle-HorizontalAlign ="Right" SortExpression="Id_kursu" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Oznaczenie" HeaderText="Oznaczenie" SortExpression="Oznaczenie" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Data_kursu" HeaderText="Data_kursu" SortExpression="Data_kursu" DataFormatString="{0:yyyy-MM-dd}" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Ilość_pasażerów" HeaderText="Ilość_pasażerów" SortExpression="Ilość_pasażerów" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Godzina_rozpoczecia" HeaderText="Godzina_rozpoczecia" SortExpression="Godzina_rozpoczecia" ItemStyle-HorizontalAlign ="Right" >
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
    <p style="text-align:center">
<asp:Label ID="Label1" runat="server"  Text="Wpisz oznaczenie kursu:"></asp:Label>
    </p>
    
    <asp:SqlDataSource ID="sdskurs" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" DeleteCommand="DELETE FROM [Kurs] WHERE [Id_kursu] = @Id_kursu" InsertCommand="INSERT INTO [Kurs] ([Id_trasy], [Oznaczenie], [Data_kursu], [Ilość_pasażerów], [Godzina_rozpoczecia]) VALUES (@Id_trasy, @Oznaczenie, @Data_kursu, @Ilość_pasażerów, @Godzina_rozpoczecia)" SelectCommand="SELECT * FROM [Kurs]" UpdateCommand="UPDATE [Kurs] SET [Id_trasy] = @Id_trasy, [Oznaczenie] = @Oznaczenie, [Data_kursu] = @Data_kursu, [Ilość_pasażerów] = @Ilość_pasażerów, [Godzina_rozpoczecia] = @Godzina_rozpoczecia WHERE [Id_kursu] = @Id_kursu">
        <DeleteParameters>
            <asp:Parameter Name="Id_kursu" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id_trasy" Type="Decimal" />
            <asp:Parameter Name="Oznaczenie" Type="String" />
            <asp:Parameter DbType="Date" Name="Data_kursu" />
            <asp:Parameter Name="Ilość_pasażerów" Type="Decimal" />
            <asp:Parameter DbType="Time" Name="Godzina_rozpoczecia" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Id_trasy" Type="Decimal" />
            <asp:Parameter Name="Oznaczenie" Type="String" />
            <asp:Parameter DbType="Date" Name="Data_kursu" />
            <asp:Parameter Name="Ilość_pasażerów" Type="Decimal" />
            <asp:Parameter DbType="Time" Name="Godzina_rozpoczecia" />
            <asp:Parameter Name="Id_kursu" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <p style="text-align:center">
        <asp:TextBox ID="tboznkursu" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">
    <asp:Button ID="bttyg" runat="server" BackColor="#009933" Font-Size="Large" Height="54px" ForeColor="White" Text="Raport tygodniowy" OnClick="bttyg_Click" />
    <asp:Button ID="btsrednia" runat="server" BackColor="#009933" Font-Size="Large" Height="54px" ForeColor="White" Text="Średnia pasażerów" OnClick="btsrednia_Click" />
    </p>
    <p style="text-align:center">
        <asp:Label ID="Label2" runat="server" Text="Ilość pasażerów:"></asp:Label>
    </p>
    <p style="text-align:center">
        <asp:TextBox ID="tbpasazer" runat="server"></asp:TextBox>
    </p>
    
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Miejscowosci.aspx.cs" Inherits="Strony_Miejscowosci" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btdodajmiej" runat="server" OnClick="btdodajmiej_Click" Text="Dodaj miejscowość" Height="54px" Width="176px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="gvmiej" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" style="margin-left:auto;margin-right:auto" DataKeyNames="Id_miejscowosci" DataSourceID="sdsmiej" OnRowEditing="GridView1_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id_miejscowosci" HeaderText="L.p." ItemStyle-HorizontalAlign ="Right" InsertVisible="False" ReadOnly="True" SortExpression="Id_miejscowosci" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Nazwa_miejscowosci" HeaderText="Nazwa_miejscowosci" ItemStyle-HorizontalAlign ="Right" SortExpression="Nazwa_miejscowosci" >
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
        <asp:SqlDataSource ID="sdsmiej" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" DeleteCommand="DELETE FROM [Miejscowości] WHERE [Id_miejscowosci] = @Id_miejscowosci" InsertCommand="INSERT INTO [Miejscowości] ([Nazwa_miejscowosci]) VALUES (@Nazwa_miejscowosci)" SelectCommand="SELECT * FROM [Miejscowości]" UpdateCommand="UPDATE [Miejscowości] SET [Nazwa_miejscowosci] = @Nazwa_miejscowosci WHERE [Id_miejscowosci] = @Id_miejscowosci">
            <DeleteParameters>
                <asp:Parameter Name="Id_miejscowosci" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nazwa_miejscowosci" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nazwa_miejscowosci" Type="String" />
                <asp:Parameter Name="Id_miejscowosci" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>


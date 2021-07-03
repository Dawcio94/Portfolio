<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Przebieg.aspx.cs" Inherits="Strony_Przebieg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;<br />
    </p>
    <p>
        <asp:Button ID="btdodajmiej" runat="server" OnClick="btdodajmiej_Click" Text="Dodaj przebieg" Height="54px" Width="149px" BackColor="#009933" Font-Size="Large" ForeColor="White" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1"  runat="server" style="float:right;margin-right:250px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id_miejscowosci" DataSourceID="sdsmiasto" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nazwa_miejscowosci" ItemStyle-HorizontalAlign ="Right" HeaderText="Nazwa_miejscowosci" SortExpression="Nazwa_miejscowosci" />
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
        <asp:SqlDataSource ID="sdsmiasto" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" SelectCommand="SELECT * FROM [Miejscowości]"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" style="float:right" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id_trasy" DataSourceID="sdstrasa" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Oznaczenie_trasy" ItemStyle-HorizontalAlign ="Right" HeaderText="Oznaczenie_trasy" SortExpression="Oznaczenie_trasy" />
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
        <asp:SqlDataSource ID="sdstrasa" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" SelectCommand="SELECT * FROM [Trasa]"></asp:SqlDataSource>
        <asp:GridView ID="gvprzebieg" runat="server" style="float:right" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"  DataKeyNames="Id_przebiegu" DataSourceID="sdsprzebieg" OnRowEditing="gvprzebieg_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id_przebiegu" HeaderText="L.p" ItemStyle-HorizontalAlign ="Right" InsertVisible="False" ReadOnly="True" SortExpression="Id_przebiegu" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Roznica_czasu" HeaderText="Roznica_czasu" ItemStyle-HorizontalAlign ="Right" SortExpression="Roznica_czasu" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Kolejnosc" HeaderText="Kolejnosc" ItemStyle-HorizontalAlign ="Right" SortExpression="Kolejnosc" >
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
        <asp:SqlDataSource ID="sdsprzebieg" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" DeleteCommand="DELETE FROM [Przebieg] WHERE [Id_przebiegu] = @Id_przebiegu" InsertCommand="INSERT INTO [Przebieg] ([Id_miejscowosci], [Id_trasy], [Roznica_czasu], [Kolejnosc]) VALUES (@Id_miejscowosci, @Id_trasy, @Roznica_czasu, @Kolejnosc)" SelectCommand="SELECT * FROM [Przebieg]" UpdateCommand="UPDATE [Przebieg] SET [Id_miejscowosci] = @Id_miejscowosci, [Id_trasy] = @Id_trasy, [Roznica_czasu] = @Roznica_czasu, [Kolejnosc] = @Kolejnosc WHERE [Id_przebiegu] = @Id_przebiegu">
            <DeleteParameters>
                <asp:Parameter Name="Id_przebiegu" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id_miejscowosci" Type="Decimal" />
                <asp:Parameter Name="Id_trasy" Type="Decimal" />
                <asp:Parameter DbType="Time" Name="Roznica_czasu" />
                <asp:Parameter Name="Kolejnosc" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Id_miejscowosci" Type="Decimal" />
                <asp:Parameter Name="Id_trasy" Type="Decimal" />
                <asp:Parameter DbType="Time" Name="Roznica_czasu" />
                <asp:Parameter Name="Kolejnosc" Type="Decimal" />
                <asp:Parameter Name="Id_przebiegu" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>


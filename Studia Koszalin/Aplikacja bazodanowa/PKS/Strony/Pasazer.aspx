<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Pasazer.aspx.cs" Inherits="Strony_Pasazer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Wybierz miejscowość początkową:"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="dplmiastopocz" runat="server" DataSourceID="sdsmiastopocz" DataTextField="Nazwa_miejscowosci" DataValueField="Id_miejscowosci" Height="25px" Width="230px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="sdsmiastopocz" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" SelectCommand="SELECT * FROM [Miejscowości]"></asp:SqlDataSource>
         
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" style="float:right" DataKeyNames="Id_przebiegu" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Roznica_czasu" HeaderText="Roznica_czasu" ItemStyle-HorizontalAlign ="Right" SortExpression="Roznica_czasu" >
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
        <asp:GridView ID="GridView3" runat="server" style="float:right" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id_miejscowosci" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nazwa_miejscowosci" HeaderText="Nazwa_miejscowosci" SortExpression="Nazwa_miejscowosci" />
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
        <asp:SqlDataSource ID="sdsmiasto" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" ></asp:SqlDataSource>
        <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" style="float:right" DataKeyNames="Id_kursu" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id_kursu" HeaderText="L.p"  ItemStyle-HorizontalAlign ="Right" InsertVisible="False" ReadOnly="True" SortExpression="Id_kursu" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Oznaczenie" HeaderText="Oznaczenie" SortExpression="Oznaczenie" ItemStyle-HorizontalAlign ="Right" >
<ItemStyle HorizontalAlign="Right"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Data_kursu" HeaderText="Data_kursu" DataFormatString="{0:yyyy-MM-dd}" SortExpression="Data_kursu" ItemStyle-HorizontalAlign ="Right" >
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
        <asp:SqlDataSource ID="sdsprzebieg" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" ></asp:SqlDataSource>
        <asp:SqlDataSource ID="sdskurs" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" >
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
    </p>
    <p>
        Wybierz miejscowość końcową:</p>
    <p>
        <asp:DropDownList ID="dplmiastokon" runat="server" DataSourceID="sdsmiastokon" DataTextField="Nazwa_miejscowosci" DataValueField="Id_miejscowosci" Height="25px" Width="230px" style="margin-top: 0px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="sdsmiastokon" runat="server" ConnectionString="<%$ ConnectionStrings:Baza_PKSConnectionString %>" SelectCommand="SELECT * FROM [Miejscowości]"></asp:SqlDataSource>
    </p>
    <p>
        Wybierz datę połączenia:</p>
    <p>
        <asp:Calendar ID="clpasazer" runat="server"></asp:Calendar>
    </p>
     <p>
         <asp:Label ID="Label2" runat="server" Text="Podaj godzinę:"></asp:Label>                
         </p>
    <p>
        <asp:TextBox ID="tbgodz" runat="server" TextMode="Time" Height="24px" Width="130px"></asp:TextBox>
        <asp:Button ID="btzaloguj" runat="server" Text="Szukaj" Height="30px" Width="200px" OnClick="btzaloguj_Click" BackColor="#009933" Font-Size="Large" ForeColor="White" ></asp:Button> 
    </p>
            
    </asp:Content>


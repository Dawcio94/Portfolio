<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Pages_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><asp:ChangePassword ID="ChangePassword1" runat="server" CancelButtonText="Wróć" CancelDestinationPageUrl="~/Pages/Main_Page.aspx" ChangePasswordButtonText="Zmień hasło" ChangePasswordTitleText="Zmień hasło" ConfirmNewPasswordLabelText="Potwierdź nowe hasło:" ContinueDestinationPageUrl="~/Pages/Main_Page.aspx" NewPasswordLabelText="Nowe hasło:" PasswordLabelText="Stare hasło:" NewPasswordRegularExpressionErrorMessage="Proszę podać inne hasło." NewPasswordRequiredErrorMessage="Pole &quot;Nowe hasło&quot; jest wymagane" PasswordRequiredErrorMessage="Hasło jest wymagane!!" SuccessPageUrl="~/Pages/Main_Page.aspx" SuccessText="Hasło zostało zmienione :)" SuccessTitleText="Udało się!!" UserNameLabelText="Login:">
        <CancelButtonStyle CssClass="button" />
        <ChangePasswordButtonStyle CssClass="button" />
        <ContinueButtonStyle CssClass="button" />
    </asp:ChangePassword>
        </center>
</asp:Content>


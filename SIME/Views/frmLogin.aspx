<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="SIME.Views.frmLogin" %>
<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../SwitcherResources/Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <uc1:ucMensaje runat="server" ID="ucMensaje" />
        <br />
        <br />
        <br />
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4" style="text-align:center">
                <dx:BootstrapTextBox ID="txtUsuario" runat="server" Caption="Usuario:" NullText="Ingrese su email aquí.">
                    <ValidationSettings RequiredField-IsRequired="true" RequiredField-ErrorText="El usuario es requerido"></ValidationSettings>
                </dx:BootstrapTextBox>
            </div>
            <div class="col-md-4"></div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4" style="text-align:center">
                <dx:BootstrapTextBox ID="txtPassword" runat="server" Caption="Contraseña:" NullText="Ingrese su contraseña aquí." Password="true">
                    <ValidationSettings RequiredField-IsRequired="true" RequiredField-ErrorText="La contraseña es requerida"></ValidationSettings>
                </dx:BootstrapTextBox>
            </div>
            <div class="col-md-4"></div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4" style="text-align:center">
                <dx:BootstrapButton ID="btnEntrar" runat="server" Text="Ingresar" OnClick="btnLogin_Click">
                    <SettingsBootstrap RenderOption="Primary" />
                </dx:BootstrapButton>
            </div>
            <div class="col-md-4"></div>
        </div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4" style="text-align:center">
                <dx:BootstrapButton ID="btnOlvidoPass" runat="server" Text="¿Olvidó su contraseña?">
                    <SettingsBootstrap RenderOption="Link" />
                </dx:BootstrapButton>
            </div>
            <div class="col-md-4"></div>
        </div>
    </form>
</body>
</html>

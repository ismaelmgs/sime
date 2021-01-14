<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="SIME.Views.frmLogin" %>
<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManger" runat="Server" />

            <div style="width: 100%;">
                <asp:UpdatePanel ID="upaGeneral" runat="server">
                    <ContentTemplate>

                        <uc1:ucMensaje runat="server" ID="ucMensaje" />

                        <div style="margin-left: 2%;">
                            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Login</h5>
                        </div>

                        <div class="row">
                            <div class="col-md-6 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                                <asp:Label runat="server" Text="Usuario:"></asp:Label>
                            </div>
                            <div class="col-md-6 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                                <asp:TextBox ID="txtsUsuario" runat="server" Text=""></asp:TextBox>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-6 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                                <asp:Label runat="server" Text="Contraseña:"></asp:Label>
                            </div>
                            <div class="col-md-6 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                                <asp:TextBox ID="txtPass"  runat="server" Text="" type="password" ></asp:TextBox>
                            </div>
                        </div>

                        <div class="row">
                            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Secion" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

        </div>
    </form>
</body>
</html>

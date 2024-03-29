﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMensaje.ascx.cs" Inherits="SIME.ControlesUsuario.ucMensaje" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<link href="../SwitcherResources/Content/bootstrap.min.css" rel="stylesheet" />
<%--<ajax:ModalPopupExtender ID="mpext" runat="server" BackgroundCssClass="overlayy"
    TargetControlID="pnlPopup" PopupControlID="pnlPopup" OkControlID="btnOk" CancelControlID="btnOk">
</ajax:ModalPopupExtender>
<asp:Panel ID="pnlPopup" runat="server" BackColor="White" Style="display: none;border-radius: 0.3em;" DefaultButton="btnOk">
    <table style="width:100%; border-radius: 5px;">
        <tr style="background-color:#0AC880;">
            <td colspan="2" align="left" runat="server" id="tdCaption" class="thGrv">
                &nbsp; <asp:Label ID="lblCaption" runat="server" Font-Size="Medium" ForeColor="#FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 60px; padding-left: 15px; padding-top:20px;" valign="middle" align="center">
                <asp:Image ID="imgInfo" runat="server" ImageUrl="~/images/icons/Information.png" Width="35px" Height="35px" />
            </td>
            <td valign="middle" align="left" style="padding-right: 15px; padding-top:20px;">
                <asp:Label ID="lblMessage" runat="server" CssClass="lblError" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="right" style="padding: 10px 10px 10px 10px;">
                <asp:Button ID="btnOk" runat="server" Text="Aceptar" OnClick="btnOk_Click" CssClass="mb-2 btn btn-secondary mr-2" />
            </td>
        </tr>
    </table>
</asp:Panel>--%>

<dx:BootstrapPopupControl ID="ppMensaje" runat="server" ClientInstanceName="ppMensaje" CloseAnimationType="Fade" PopupAnimationType="Fade"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="350px" Height="200px"
    AllowDragging="true" Modal="true" CloseAction="CloseButton" ShowCloseButton="true" AllowResize="true">
    <ContentCollection>
        <dx:ContentControl>
            <header>
                <asp:Label ID="lblCaption" runat="server" Font-Size="Medium" ForeColor="#FFFFFF"></asp:Label>
            </header>
            <div class="row">
                <div class="col-md-2">
                    <asp:Image ID="imgInfo" runat="server" ImageUrl="~/images/icons/information.png" Width="35px" Height="35px" />
                </div>
                <div class="col-md-10">
                    <asp:Label ID="lblMessage" runat="server" CssClass="lblError" Font-Size="Medium"></asp:Label>
                </div>
            </div>
            <footer style="text-align:right">
                <%--<asp:Button ID="btnOK" runat="server" AutoPostBack="false" Text="Aceptar" CssClass="btn btn btn-primary"></asp:Button>--%>
            </footer>
        </dx:ContentControl>
    </ContentCollection>
</dx:BootstrapPopupControl>

<script type="text/javascript">
    function fnClickOK(sender, e) {
        __doPostBack(sender, e);
    }
</script>
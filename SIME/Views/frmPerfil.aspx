<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPerfil.aspx.cs" Inherits="SIME.Views.frmPerfil" %>
<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <uc1:ucMensaje runat="server" ID="ucMensaje" />
    <div class="container-fluid">
        <div style="margin-left: 2%;">
            <br />
            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">ABC de perfiles</h5>
            <br />
        </div>
        <br />
        
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:90%">
                    <div class="row">
                        <div class="col-lg-12" style="text-align:right">
                            <dx:BootstrapButton ID="btnAgregarPerfil" runat="server" Text="Agregar perfil" OnClick="btnAgregarPerfil_Click">
                                <SettingsBootstrap RenderOption="Primary" />
                            </dx:BootstrapButton>
                        </div>
                    </div>
                </td>
                <td style="width:5%"></td>
            </tr>
            <tr>
                <td style="width:5%"></td>
                <td style="width:90%">
                    <dx:BootstrapGridView ID="gvPerfiles" runat="server" KeyFieldName="ID_Perfil" OnRowCommand="gvPerfiles_RowCommand">
                    <SettingsSearchPanel Visible="true" ShowApplyButton="true" />
                    <Settings ShowGroupPanel="True" ShowFilterRowMenu="true" />
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <Columns>
                        <dx:BootstrapGridViewDataColumn FieldName="Des_Perfil" Caption="Perfil" VisibleIndex="1" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="Comentarios" Caption="Comentarios" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="DescStatus" Caption="Estatus" VisibleIndex="3" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn Caption="Acciones" VisibleIndex="4" Settings-AllowDragDrop="False" CssClasses-HeaderCell="border-1" HorizontalAlign="Center">
                            <DataItemTemplate>
                                <dx:BootstrapButton ID="btnEditar" runat="server" Text="Editar" CommandArgument='<%# Eval("ID_Perfil") %>'  CommandName="Editar">
                                    <SettingsBootstrap RenderOption="Success" />
                                </dx:BootstrapButton>
                                <dx:BootstrapButton ID="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("ID_Perfil") %>'  CommandName="Eliminar">
                                    <SettingsBootstrap RenderOption="Warning" />
                                </dx:BootstrapButton>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                    </Columns>
                    <Templates>
                        <EmptyDataRow>
                            Aún no se han registrado usuarios para esta empresa.
                        </EmptyDataRow>
                    </Templates>
                </dx:BootstrapGridView>
                </td>
                <td style="width:5%"></td>
            </tr>
        </table>
    </div>

    <%-- MODAL PARA AGREGAR UN PERFIL --%>
    <dx:BootstrapPopupControl ID="ppAddPerfil" runat="server" ClientInstanceName="ppAddPerfil" PopupElementCssSelector="#info-popup-control"
        CloseAnimationType="Fade" PopupAnimationType="Fade"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="300px" Height="350px" HeaderText="Edición de perfil"
        AllowDragging="true" Modal="true" CloseAction="CloseButton" ShowCloseButton="true" AllowResize="true">
        <ContentCollection>
            <dx:ContentControl>

                <div class="row">
                    <div class="col-sm-12">
                        <dx:BootstrapTextBox ID="txtPerfil" runat="server" Caption="Perfil:" TabIndex="1">
                            <ValidationSettings ValidationGroup="VGPerfil">
                                <RequiredField IsRequired="true" ErrorText="El perfil es requerido" />
                            </ValidationSettings>
                        </dx:BootstrapTextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <dx:BootstrapMemo ID="txtComentarios" runat="server" Rows="2" TabIndex="2" Caption="Comentarios:">
                        </dx:BootstrapMemo>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12">
                        <div style="text-align: center">
                            <dx:BootstrapButton ID="btnAgregar" runat="server" Text="Agregar" TabIndex="3" ValidationGroup="VGPerfil" AutoPostBack="true"
                                OnClick="btnAgregar_Click">
                                <SettingsBootstrap RenderOption="Success" />
                            </dx:BootstrapButton>

                            <dx:BootstrapButton ID="btnCancelar" runat="server" Text="Cancelar" TabIndex="4" AutoPostBack="false" OnClick="btnCancelar_Click">
                                <ClientSideEvents Click="function(s, e) { ppTramos.Hide(); }" />
                                <SettingsBootstrap RenderOption="Warning" />
                            </dx:BootstrapButton>
                        </div>
                    </div>
                </div>

            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>
</asp:Content>

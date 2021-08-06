<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMisSolicitudes.aspx.cs" Inherits="SIME.Views.frmMisSolicitudes" %>
<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/StyleMIT.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <uc1:ucMensaje runat="server" ID="ucMensaje" />
    <div class="container-fluid">
        <div style="margin-left: 2%;">
            <br />
            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Mis solicitudes</h5>
            <br />
        </div>

        <table style="width:100%">
            <tr>
                <td style="width:2%"></td>
                <td style="width:96%">
                    <dx:BootstrapGridView ID="gvSolicitudes" runat="server" KeyFieldName="IdSolicitud" OnRowCommand="gvSolicitudes_RowCommand">
                        <SettingsSearchPanel Visible="true" ShowApplyButton="true" />
                        <Settings ShowGroupPanel="True" ShowFilterRowMenu="true" />
                        <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                        <Columns>
                            <dx:BootstrapGridViewDataColumn FieldName="NombreCliente" Caption="Nombre cliente" VisibleIndex="1" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn FieldName="Descripcion" Caption="Descripción" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        
                            <dx:BootstrapGridViewDataColumn Caption="Proveedor asignado" VisibleIndex="4" Settings-AllowDragDrop="False" CssClasses-HeaderCell="border-1" HorizontalAlign="Left">
                                <DataItemTemplate>
                                    <dx:BootstrapButton ID="lkbProveedor" runat="server" Text='<%# Eval("DescProveedorAsignado") %>' CommandArgument='<%# Eval("IdSolicitud") %>'  CommandName="Proveedor">
                                        <SettingsBootstrap RenderOption="Link" />
                                    </dx:BootstrapButton>
                                </DataItemTemplate>
                            </dx:BootstrapGridViewDataColumn>

                            <dx:BootstrapGridViewDataColumn Caption="Ver imágenes" VisibleIndex="4" Settings-AllowDragDrop="False" CssClasses-HeaderCell="border-1" HorizontalAlign="Left">
                                <DataItemTemplate>
                                    <dx:BootstrapButton ID="lkbDetalle" runat="server" Text="Ver detalle" CommandArgument='<%# Eval("IdSolicitud") %>'  CommandName="Imagenes">
                                        <SettingsBootstrap RenderOption="Primary" />
                                    </dx:BootstrapButton>
                                </DataItemTemplate>
                            </dx:BootstrapGridViewDataColumn>
                        </Columns>
                        <Templates>
                            <EmptyDataRow>
                                Aún no se han encontrado solicitudes para mostrar.
                            </EmptyDataRow>
                        </Templates>
                    </dx:BootstrapGridView>
                </td>
                <td style="width:2%"></td>
            </tr>
        </table>
    </div>


    <%-- MODAL PARA AGREGAR UN PERFIL --%>
    <dx:BootstrapPopupControl ID="ppImagenes" runat="server" ClientInstanceName="ppImagenes" PopupElementCssSelector="#info-popup-control"
        CloseAnimationType="Fade" PopupAnimationType="Fade"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="800px" Height="400px" HeaderText="Visor de imágenes"
        AllowDragging="true" Modal="true" CloseAction="CloseButton" ShowCloseButton="true" AllowResize="true">
        <ContentCollection>
            <dx:ContentControl>

                <div class="row">
                    <div class="col-sm-12">
                        <dx:ASPxImageSlider ID="ImageSlider" runat="server" ClientInstanceName="ImageSlider"
                            EnableViewState="False" EnableTheming="False" NavigateUrlFormatString="javascript:void({0});">
                            <SettingsImageArea ImageSizeMode="ActualSizeOrFit" NavigationButtonVisibility="None"
                                ItemTextVisibility="Always" EnableLoopNavigation="true" />
                            <SettingsNavigationBar Mode="Dots" />
                            <SettingsSlideShow AutoPlay="true" StopPlayingWhenPaging="false" PausePlayingWhenMouseOver="false" PlayPauseButtonVisibility="Faded" />
                            <Items>
                                <%--<dx:ImageSliderItem ImageUrl="~/ImagenesSolicitud/202102_2wl5hk0s.jpg" NavigateUrl="4">
                                    <TextTemplate>
                                        <h3 class='isdemoH3'>Smile</h3>
                                        <p>It takes 17 muscles to smile and 43 to frown. <a tabindex="-1" href='javascript:void(1);'>Details »</a></p>
                                    </TextTemplate>
                                </dx:ImageSliderItem>--%>
                            </Items>
                            <Styles>
                                <ImageArea Width="800" Height="313" />
                            </Styles>
                        </dx:ASPxImageSlider>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12">
                        <div style="text-align: center">
                            <dx:BootstrapButton ID="btnAgregar" runat="server" Text="Agregar" TabIndex="3" AutoPostBack="true">
                                <SettingsBootstrap RenderOption="Success" />
                            </dx:BootstrapButton>

                            <dx:BootstrapButton ID="btnCancelar" runat="server" Text="Cancelar" TabIndex="4" AutoPostBack="false">
                                <ClientSideEvents Click="function(s, e) { ppImagenes.Hide(); }" />
                                <SettingsBootstrap RenderOption="Warning" />
                            </dx:BootstrapButton>
                        </div>
                    </div>
                </div>

            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>


    <%-- MODAL PARA ASIGNAR UN PROVEEDOR --%>
    <dx:BootstrapPopupControl ID="ppProveedores" runat="server" ClientInstanceName="ppProveedores" PopupElementCssSelector="#info-popup-control"
        CloseAnimationType="Fade" PopupAnimationType="Fade"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="550px" Height="350px" HeaderText="Asignación de proveedor"
        AllowDragging="true" Modal="true" CloseAction="CloseButton" ShowCloseButton="true" AllowResize="true">
        <ContentCollection>
            <dx:ContentControl>
                <div class="row">
                    <div class="col-sm-12">
                        <dx:BootstrapGridView ID="gvProveedores" runat="server" KeyFieldName="Id_Prov">
                            <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                            <SettingsBehavior AllowSelectSingleRowOnly="true" AllowSelectByRowClick="true" />
                            <Columns>
                                <dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" />
                                <dx:BootstrapGridViewDataColumn FieldName="NombreProv" Caption="Nombre proveedor" VisibleIndex="1" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                                <dx:BootstrapGridViewDataColumn FieldName="RFC" Caption="RFC" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            </Columns>
                            <SettingsPager NumericButtonCount="5"></SettingsPager>
                            <Templates>
                                <EmptyDataRow>
                                    No se encontraron proveedores para asignar
                                </EmptyDataRow>
                            </Templates>
                        </dx:BootstrapGridView>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12">
                        <div style="text-align: center">
                            <dx:BootstrapButton ID="btnAsignar" runat="server" Text="Agregar" TabIndex="3" AutoPostBack="true"
                                OnClick="btnAsignar_Click">
                                <SettingsBootstrap RenderOption="Success" />
                            </dx:BootstrapButton>

                            <dx:BootstrapButton ID="btnCerrar" runat="server" Text="Cancelar" TabIndex="4" AutoPostBack="false">
                                <ClientSideEvents Click="function(s, e) { ppProveedores.Hide(); }" />
                                <SettingsBootstrap RenderOption="Warning" />
                            </dx:BootstrapButton>
                        </div>
                    </div>
                </div>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

</asp:Content>

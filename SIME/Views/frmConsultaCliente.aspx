<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultaCliente.aspx.cs" Inherits="SIME.Views.frmConsultaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <div class="container-fluid">
        <div style="margin-left: 2%;">
            <br />
            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Listado de clientes de SIME</h5>
            <br />
        </div>
        <%--<div class="row">
            <div class="col-md-3" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                &nbsp;             
            </div>
            <div class="col-md-4" style="text-align: center; margin-bottom: 5px;">
                <dx:BootstrapTextBox ID="txtBuscar" runat="server" NullText="Escribe algo para buscar"></dx:BootstrapTextBox>
            </div>
            <div class="col-md-5" style="text-align: left; margin-bottom: 12px;">
                <dx:BootstrapButton ID="btnBucar" runat="server" Text="Buscar">
                    <SettingsBootstrap RenderOption="Primary" />
                </dx:BootstrapButton>
            </div>
        </div>--%>

        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:90%">
                    <dx:BootstrapGridView ID="gvClientes" runat="server" KeyFieldName="Id_Cliente" OnRowCommand="gvClientes_RowCommand">
                    <SettingsSearchPanel Visible="true" ShowApplyButton="true" />
                    <Settings ShowGroupPanel="True" ShowFilterRowMenu="true" />
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <Columns>
                        <dx:BootstrapGridViewDataColumn Caption="Nombre / Razón Social" VisibleIndex="1" Settings-AllowDragDrop="False" CssClasses-HeaderCell="border-1" HorizontalAlign="Left">
                            <DataItemTemplate>
                                <dx:BootstrapButton ID="lkbCliente" runat="server" Text='<%# Eval("Cliente").ToString() %>' CommandArgument='<%# Eval("Id_Cliente") %>'  CommandName="Cliente">
                                    <SettingsBootstrap RenderOption="Link" />
                                </dx:BootstrapButton>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                        <dx:BootstrapGridViewDataColumn FieldName="Cliente" Caption="Cliente" Visible="false" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="Descripcion" Caption="Tipo de Persona" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="RFC" Caption="RFC" VisibleIndex="3" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="DatosContactoServicio" Caption="Contacto servicio" VisibleIndex="4" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="DatosContactoAdmin" Caption="Contacto administrativo" VisibleIndex="5" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        <dx:BootstrapGridViewDataColumn FieldName="Sector" Caption="Sector" VisibleIndex="6" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
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

</asp:Content>

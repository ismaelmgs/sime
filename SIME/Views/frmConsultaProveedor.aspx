<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultaProveedor.aspx.cs" Inherits="SIME.Views.frmConsultaProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <div class="container-fluid">
        <div style="margin-left: 2%;">
            <br />
            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Listado de Proveedores</h5>
            <br />
        </div>
        <%--<div class="row">
            <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                &nbsp;             
            </div>
            <div class="col-md-4 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                <asp:TextBox ID="txtBuscar" runat="server"  Text="" placeholder="Palabra Clave" ></asp:TextBox>
            </div>
            <div class="col-md-5 rlrcentro" style="text-align: center; margin-bottom: 12px;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnBucar" runat="server" Text="BUSCAR" CssClass="btn btn-primary" OnClick="btnBucar_Click" />
            </div>
        </div>--%>

        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:90%">
                    <dx:BootstrapGridView ID="gvProveedores" runat="server" KeyFieldName="Id_Prov" OnRowCommand="gvProveedores_RowCommand">
                        <SettingsSearchPanel Visible="true" ShowApplyButton="true" />
                        <Settings ShowGroupPanel="True" ShowFilterRowMenu="true" />
                        <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                        <Columns>
                            <dx:BootstrapGridViewDataColumn Caption="Proveedor" VisibleIndex="1" Settings-AllowDragDrop="False" CssClasses-HeaderCell="border-1" HorizontalAlign="Left">
                            <DataItemTemplate>
                                <dx:BootstrapButton ID="lkbCliente" runat="server" Text='<%# Eval("Proveedor").ToString() %>' CommandArgument='<%# Eval("Id_Prov") %>'  CommandName="Proveedor">
                                    <SettingsBootstrap RenderOption="Link" />
                                </dx:BootstrapButton>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                            <dx:BootstrapGridViewDataColumn FieldName="Descripcion" Caption="Tipo de Persona" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn FieldName="RFC" Caption="RFC" VisibleIndex="3" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn FieldName="Contacto_Serv" Caption="Contacto Servicio" VisibleIndex="4" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn FieldName="Contacto_Admin" Caption="Contacto Administrativo" VisibleIndex="5" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
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

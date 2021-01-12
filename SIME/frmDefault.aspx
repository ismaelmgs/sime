<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDefault.aspx.cs" Inherits="SIME.frmDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <dx:BootstrapGridView ID="gvPrueba" runat="server" KeyFieldName="Columna1">
        <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
        <Columns>
            <dx:BootstrapGridViewDataColumn FieldName="Columna1" Caption="Correo" VisibleIndex="1" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
            <dx:BootstrapGridViewDataColumn FieldName="Columna2" Caption="Nombre" VisibleIndex="2" SortIndex="0" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
            <dx:BootstrapGridViewDataColumn FieldName="Columna3" Caption="Telefono" VisibleIndex="3" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
            <dx:BootstrapGridViewDataColumn FieldName="Columna4" Caption="Password" VisibleIndex="4" Visible="false" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
            <dx:BootstrapGridViewDataColumn VisibleIndex="5">
                <DataItemTemplate>
                    <dx:BootstrapButton ID="btnActualizar" runat="server" Text="Actualizar" CommandName="Actualizar" CommandArgument='<%# Eval("Columna1").ToString()%>'></dx:BootstrapButton>
                    <dx:BootstrapButton ID="btnEliminar" runat="server" Text="Eliminar" CommandName="Eliminar"
                        CommandArgument='<%# Eval("Columna1").ToString()%>'>
                        <ClientSideEvents Click="function(s, e){  e.processOnServer = confirm('¿Está seguro que desea eliminar el registro?');}" />
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
</asp:Content>

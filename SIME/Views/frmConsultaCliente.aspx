<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultaCliente.aspx.cs" Inherits="SIME.Views.frmConsultaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <asp:ScriptManager ID="ScriptManger" runat="Server" />

    <div style="width: 100%;">
        <asp:UpdatePanel ID="upaGeneral" runat="server">
            <ContentTemplate>

                <div style="margin-left: 2%;">
                    <h5 class="page-title rlrH5" style="margin-left: -2%;margin-bottom: 1%;font-weight:bold;">Listado de Clientes DE SIME...</h5>
                </div>

                <div class="row">
                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        &nbsp;             
                    </div>
                    <div class="col-md-4 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                       <asp:TextBox ID="txtBuscar" runat="server"  Text="" placeholder="Palabra Clave" ></asp:TextBox>
                    </div>
                    <div class="col-md-5 rlrcentro" style="text-align: center; margin-bottom: 12px;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnBucar" runat="server" Text="BUSCAR" CssClass="btn btn-primary" OnClick="btnBucar_Click" />
                    </div>
                </div>

                <div width="100%" class="row">
                    <dx:BootstrapGridView ID="gvClientes" runat="server" KeyFieldName="Id_Cliente">
                        <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                        <Columns>
                            <dx:BootstrapGridViewDataColumn FieldName="Cliente" Caption="Nombre / Razón Social" VisibleIndex="1" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn FieldName="Descripcion" Caption="Tipo de Persona" VisibleIndex="2" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn FieldName="RFC" Caption="RFC" VisibleIndex="3" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                            <dx:BootstrapGridViewDataColumn  Caption="Contacto Servicio" VisibleIndex="4"  CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn">
                                <DataItemTemplate>
                                    <dx:ASPxLabel runat="server" Text='<%#Eval("Contacto_Servicios") %>' ></dx:ASPxLabel>
                                    <dx:ASPxLabel runat="server" Text='<%#Eval("Tel_Cont_serv") %>' ></dx:ASPxLabel>
                                </DataItemTemplate>
                            </dx:BootstrapGridViewDataColumn>
                            <dx:BootstrapGridViewDataColumn  Caption="Contacto Administrativo" VisibleIndex="5"  CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn">
                                <DataItemTemplate>
                                    <dx:ASPxLabel runat="server" Text='<%#Eval("Contacto_Administrativo") %>' ></dx:ASPxLabel>
                                    <dx:ASPxLabel runat="server" Text='<%#Eval("Tel_Cont_adm") %>' ></dx:ASPxLabel>
                                </DataItemTemplate>
                            </dx:BootstrapGridViewDataColumn>
                            <dx:BootstrapGridViewDataColumn FieldName="Sector" Caption="Sector" VisibleIndex="6" CssClasses-DataCell="hideColumn" CssClasses-HeaderCell="hideColumn" />
                        </Columns>
                        <Templates>
                            <EmptyDataRow>
                                Aún no se han registrado usuarios para esta empresa.
                            </EmptyDataRow>
                        </Templates>
                    </dx:BootstrapGridView>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

</asp:Content>

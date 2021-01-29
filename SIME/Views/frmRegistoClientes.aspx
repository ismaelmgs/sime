<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRegistoClientes.aspx.cs" Inherits="SIME.Views.frmRegistoClientes" %>

<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <uc1:ucMensaje runat="server" ID="ucMensaje" />

    <div class="container-fluid">
        <div style="margin-left: 2%;">
            <br />
            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Registro de clientes</h5>
            <br />
            <%--<p class="col-12 demo-content-title">Registro de Clientes</p>--%>
            <%--<h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Registro de Clientes</h5>--%>
        </div>
        <br />
        <fieldset style="width: 100%; padding: 15px; margin-top: -40px; margin-bottom: 40px" class="card mb-4">
            <header>
                Nombre
            </header>
            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Tipo de Persona:"></asp:Label>
                </div>
                <div class="col-lg-9">
                    <asp:CheckBox ID="chkFisica" runat="server" Text="Fisica" OnCheckedChanged="chkFisica_CheckedChanged" AutoPostBack="true" CssClass="lblTituloCampos" />
                    <asp:CheckBox ID="chkMoral" runat="server" Text="Moral" OnCheckedChanged="chkMoral_CheckedChanged" AutoPostBack="true" CssClass="lblTituloCampos" />
                </div>
            </div>
            <div id="divMoral" runat="server" class="row">
                <div class="col-md-1"></div>
                <div class="col-md-2">
                    <asp:Label runat="server" Text="Razon Social:"></asp:Label>
                </div>
                <div class="col-md-5">
                    <dx:BootstrapTextBox ID="txtRazon_Social" runat="server"></dx:BootstrapTextBox>
                </div>
                <div class="col-md-4"></div>
            </div>
            <div id="divFisica" runat="server">
                <div class="row">
                    <div class="col-lg-1"></div>
                    <div class="col-lg-2">
                        <asp:Label ID="lblPrimerNombre" runat="server" Text="Primer nombre:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <dx:BootstrapTextBox ID="txtPrimer_Nombre" runat="server"></dx:BootstrapTextBox>
                    </div>
                    <div class="col-lg-1"></div>
                    <div class="col-lg-2">
                        <asp:Label ID="lblSegundoNombre" runat="server" Text="Segundo nombre:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <dx:BootstrapTextBox ID="txtSegundo_Nombre" runat="server"></dx:BootstrapTextBox>
                    </div>
                    <div class="col-lg-2"></div>
                </div>
                <div class="row">
                    <div class="col-lg-1"></div>
                    <div class="col-lg-2">
                        <asp:Label ID="lblApellidoPaterno" runat="server" Text="Apellido paterno:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <dx:BootstrapTextBox ID="txtApp_Pa" runat="server"></dx:BootstrapTextBox>
                    </div>
                    <div class="col-lg-1"></div>
                    <div class="col-lg-2">
                        <asp:Label ID="Label1" runat="server" Text="Apellido materno:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <dx:BootstrapTextBox ID="txtApp_Mat" runat="server"></dx:BootstrapTextBox>
                    </div>
                    <div class="col-lg-2"></div>
                </div>
                <div class="row">
                    <div class="col-lg-1"></div>
                    <div class="col-lg-2">
                        <asp:Label runat="server" Text="Identificacion:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <dx:BootstrapTextBox ID="txtIdentificacion" runat="server" Text=""></dx:BootstrapTextBox>
                    </div>
                    <div class="col-lg-1"></div>
                    <div class="col-lg-2">
                        <asp:Label runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                    </div>
                    <div class="col-lg-2">
                        <dx:BootstrapTextBox ID="txtFec_Nac" runat="server" Text=""></dx:BootstrapTextBox>
                    </div>
                    <div class="col-lg-2"></div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="RFC:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtRFC" runat="server" Text="">
                    </dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Sector:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtSector" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>
        </fieldset>
        <br />
        <fieldset style="width: 100%; padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                Dirección
            </header>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Calle:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtCalle" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="No Ext:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtNum_Ext" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="No Int:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtNum_Int" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="CP:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtCP" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Colonia:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtColonia" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Municipio / Delegacion:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtMpio_Del" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Ciudad:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtCiudad" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Pais:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtPais" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

        </fieldset>
        <br />
        <fieldset style="width: 100%; padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                Datos de contacto
            </header>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Contacto Servi.:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtContacto_Servicios" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Contacto Admin.:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtContacto_Administrativo" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Num. Tel. Servi.:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtTel_Cont_serv" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Num Tel. Admin.:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtTel_Cont_adm" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Email Servi.:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtMail_Cont_serv" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-1"></div>
                <div class="col-lg-2">
                    <asp:Label runat="server" Text="Email Admin.:"></asp:Label>
                </div>
                <div class="col-lg-2">
                    <dx:BootstrapTextBox ID="txtMail_Cont_adm" runat="server" Text=""></dx:BootstrapTextBox>
                </div>
                <div class="col-lg-2"></div>
            </div>

        </fieldset>

        <div class="row">
            <div class="col-lg-12" style="text-align: center">
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" />
            </div>
        </div>

        <br />
    </div>
</asp:Content>

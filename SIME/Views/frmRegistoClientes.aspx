<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRegistoClientes.aspx.cs" Inherits="SIME.Views.frmRegistoClientes" %>
<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <asp:ScriptManager ID="ScriptManger" runat="Server" />

    <div style="width: 100%;">
        <asp:UpdatePanel ID="upaGeneral" runat="server">
            <ContentTemplate>

                <uc1:ucMensaje runat="server" ID="ucMensaje" />

                <div style="margin-left: 2%;">
                    <h5 class="page-title rlrH5" style="margin-left: -2%;margin-bottom: 1%;font-weight:bold;">.:Registro de Clientes:.</h5>
                </div>


                <div class="row">
                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Tipo de Persona:"></asp:Label>       
                    </div>
                    <div class="col-md-4 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                         <asp:CheckBox ID="chkFisica" runat="server" Text="Fisica" OnCheckedChanged="chkFisica_CheckedChanged" AutoPostBack="true" CssClass="lblTituloCampos" /> 
                    </div>
                    <div class="col-md-5 rlrcentro" style="text-align: center; margin-bottom: 12px;">
                          <asp:CheckBox ID="chkMoral" runat="server" Text="Moral" OnCheckedChanged="chkMoral_CheckedChanged" AutoPostBack="true" CssClass="lblTituloCampos" /> 
                    </div>
                </div>

                <div id="divMoral" runat="server" class="row">
                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Razon Social:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtRazon_Social" runat="server"  Text=""></asp:TextBox>
                    </div> 
                </div>
                <div id="divFisica" runat="server" class="row">
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Primer Nombre:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtPrimer_Nombre" runat="server"  Text=""></asp:TextBox>
                    </div>      
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Segundo Nombre:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtSegundo_Nombre" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Apellido Paterno:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtApp_Pa" runat="server"  Text=""></asp:TextBox>
                    </div>     

                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Apellido Materno:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtApp_Mat" runat="server"  Text=""></asp:TextBox>
                    </div> 
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Identificacion:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtIdentificacion" runat="server"  Text=""></asp:TextBox>
                    </div>    
                    
                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Fecha de Nacimiento:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtFec_Nac" runat="server"  Text=""></asp:TextBox>
                    </div>    
                </div>
                <div id="divRFC" class="row">
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="RFC:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtRFC" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Sector:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtSector" runat="server"  Text=""></asp:TextBox>
                    </div> 
                    
                </div>
                <div id="divDireccion" class="row">
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Calle:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtCalle" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Num Ext:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtNum_Ext" runat="server"  Text=""></asp:TextBox>
                    </div> 
                    
                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Num Int:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtNum_Int" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="CP:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtCP" runat="server"  Text=""></asp:TextBox>
                    </div> 

                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Colonia:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtColonia" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Municipio / Delegacion:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtMpio_Del" runat="server"  Text=""></asp:TextBox>
                    </div> 

                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Ciudad:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtCiudad" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Pais:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtPais" runat="server"  Text=""></asp:TextBox>
                    </div> 
                </div>
                <div id="divContactos" class="row">
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Nombre Contacto Servicio:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtContacto_Servicios" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Num Tel:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtTel_Cont_serv" runat="server"  Text=""></asp:TextBox>
                    </div> 
                    
                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Email:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtMail_Cont_serv" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Nombre Contacto Administrativo:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtContacto_Administrativo" runat="server"  Text=""></asp:TextBox>
                    </div> 

                    <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Num Tel:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtTel_Cont_adm" runat="server"  Text=""></asp:TextBox>
                    </div>  
                    
                     <div class="col-md-3 rlrcentro" style="text-align: right; margin-bottom: 5px; padding-top: 3px;">
                        <asp:Label runat="server" Text="Email:"></asp:Label>       
                    </div>
                    <div class="col-md-3 rlrcentro" style="text-align: center; margin-bottom: 5px;">
                        <asp:TextBox ID="txtMail_Cont_adm" runat="server"  Text=""></asp:TextBox>
                    </div> 
                    
                </div>

                <div class="row">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" />                    
                </div>               

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

</asp:Content>

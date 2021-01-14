<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigation.ascx.cs" Inherits="SIME.Navigation" %>

<a href="https://www.devexpress.com/products/try/" target="_blank" class="demo-try-now-link bg-primary text-white">Try it now</a>
<dx:BootstrapTreeView runat="server">
    <CssClasses
        IconExpandNode="demo-icon demo-icon-col m-0"
        IconCollapseNode="demo-icon demo-icon-ex m-0"
        NodeList="demo-treeview-nodes m-0" Node="demo-treeview-node" Control="demo-treeview" />

    <Nodes>        
         <dx:BootstrapTreeViewNode Text="Consultar" Expanded="true">
            <Nodes>
                <dx:BootstrapTreeViewNode Text="Consulta Cliente" NavigateUrl="~/Views/frmConsultaCliente.aspx"></dx:BootstrapTreeViewNode>
                <dx:BootstrapTreeViewNode Text="Consulta Proveedor" NavigateUrl="~/Views/frmConsultaProveedor.aspx"></dx:BootstrapTreeViewNode>
            </Nodes>
        </dx:BootstrapTreeViewNode>

        <dx:BootstrapTreeViewNode Text="Registrar" Expanded="true">
            <Nodes>
                <dx:BootstrapTreeViewNode Text="Registo Clientes" NavigateUrl="~/Views/frmRegistoClientes.aspx"></dx:BootstrapTreeViewNode>
                <dx:BootstrapTreeViewNode Text="Registro Proveedor" NavigateUrl="~/Views/frmRegistroProveedor.aspx"></dx:BootstrapTreeViewNode>
            </Nodes>
        </dx:BootstrapTreeViewNode>
       
    </Nodes>

</dx:BootstrapTreeView>
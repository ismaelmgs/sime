<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigation.ascx.cs" Inherits="SIME.Navigation" %>

<a href="https://www.devexpress.com/products/try/" target="_blank" class="demo-try-now-link bg-primary text-white">Try it now</a>
<dx:BootstrapTreeView runat="server">
    <CssClasses
        IconExpandNode="demo-icon demo-icon-col m-0"
        IconCollapseNode="demo-icon demo-icon-ex m-0"
        NodeList="demo-treeview-nodes m-0" Node="demo-treeview-node" Control="demo-treeview" />
    <Nodes>
        <dx:BootstrapTreeViewNode Text="Opcion 1" NavigateUrl="~/frmQuienesSomos.aspx"></dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Opcion 2" Expanded="true">
            <Nodes>
                <dx:BootstrapTreeViewNode Text="Opcion 3" NavigateUrl="~/frmDatosUsuario.aspx"></dx:BootstrapTreeViewNode>
                <dx:BootstrapTreeViewNode Text="Opcion 4" NavigateUrl="~/EventScheduling.aspx"></dx:BootstrapTreeViewNode>
            </Nodes>
        </dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Opcion 5" NavigateUrl="https://docs.devexpress.com/AspNetBootstrap/118796/getting-started" Target="_blank"></dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Opcion 6" NavigateUrl="~/frmConfiguracionEmpresa.aspx"></dx:BootstrapTreeViewNode>
    </Nodes>
</dx:BootstrapTreeView>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigation.ascx.cs" Inherits="SIME.Navigation" %>

<%--<a href="https://www.devexpress.com/products/try/" target="_blank" class="demo-try-now-link bg-primary text-white">Try it now</a>--%>

<%--<link href="../SwitcherResources/Content/litera/bootstrap.min.css" rel="stylesheet" />
<link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
<link href="../Content/common.css" rel="stylesheet" />
<link href="../Content/demo-icons.css" rel="stylesheet" />--%>


<br />
<br />
<dx:BootstrapTreeView ID="tvMenu" runat="server">
    <CssClasses
        IconExpandNode="demo-icon demo-icon-col m-0"
        IconCollapseNode="demo-icon demo-icon-ex m-0"
        NodeList="demo-treeview-nodes m-0" Node="demo-treeview-node" Control="demo-treeview" />
</dx:BootstrapTreeView>

<%--<dx:BootstrapMenu ID="tvMenu" runat="server" Orientation="Vertical" ShowPopOutImages="True">
</dx:BootstrapMenu>--%>



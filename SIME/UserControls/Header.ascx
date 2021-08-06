<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="SIME.Header" %>

<link href="../SwitcherResources/Content/bootstrap.min.css" rel="stylesheet" />
<link href="../Content/common.css" rel="stylesheet" />
<link href="../Content/demo-icons.css" rel="stylesheet" />

<div class="demo-header-part demo-area-highlight" style="float: left">
    <table style="width: 100%">
        <tr>
            <td>
                <div style="float: left">
                    <dx:BootstrapToolbar runat="server" ID="HeaderToolbar" ClientInstanceName="HeaderToolbar" Width="100%">
                        <CssClasses Control="demo-header-toolbar p-2 justify-content-end"
                            Item="demo-btn-custom-state active-highlight idle-highlight" />
                        <Items>
                            <dx:BootstrapToolbarItem IconCssClass="demo-icon demo-icon-menu" CssClass="rounded-circle shadow show-navigation" Name="SideNavToggleBtn" GroupName="SideNavToggleBtn"></dx:BootstrapToolbarItem>
                        </Items>
                    </dx:BootstrapToolbar>
                </div>
            </td>
            <td style="width: 30%">
                <%--<div class="row">
                    <div class="col-lg-12" style="text-align: right">
                        <asp:Label ID="lblNombre" runat="server"></asp:Label><br />
                        <asp:Label ID="lblPerfil" runat="server"></asp:Label><br />
                        <asp:Label ID="Label1" runat="server" Text="SIME"></asp:Label>
                    </div>
                </div>--%>
            </td>
            <td style="width: 40%; text-align: right">
                
                <div class="demo-header-part demo-area-highlight" style="float:right">
                    <dx:BootstrapToolbar runat="server" ID="btbUsuario" ClientInstanceName="btbUsuario" OnItemClick="BootstrapToolbar1_ItemClick">
                        <CssClasses Control="demo-header-toolbar p-2 justify-content-end"
                            Item="demo-btn-custom-state active-highlight idle-highlight" />
                        <%--<Items>
                            <dx:BootstrapToolbarItem Text=""
                                CssClass="no-icon demo-header-user-info align-items-center border-0 bg-light text-dark">
                                <TextTemplate>
                                    <dx:BootstrapImage runat="server" ImageUrl="~/Content/Icons/demo-user.svg"></dx:BootstrapImage>
                                    <span><asp:Label ID="lblNombre" runat="server"></asp:Label></span>
                                </TextTemplate>
                                <Items>
                                    <dx:BootstrapToolbarMenuItem Name="Perfil" Text="Perfil" IconCssClass="demo-icon demo-icon-user" />
                                    <dx:BootstrapToolbarMenuItem Name="Salir" Text="Salir" IconCssClass="demo-icon demo-icon-logout" />
                                </Items>
                            </dx:BootstrapToolbarItem>
                        </Items>--%>
                    </dx:BootstrapToolbar>
                </div>
            </td>
        </tr>
    </table>
</div>



<%--<div class="demo-header-part demo-area-highlight">
    <dx:BootstrapToolbar runat="server" ID="HeaderToolbar" ClientInstanceName="HeaderToolbar">
        <CssClasses Control="demo-header-toolbar p-2 justify-content-end" 
            Item="demo-btn-custom-state active-highlight idle-highlight" />
        <Items>
            <dx:BootstrapToolbarItem IconCssClass="demo-icon demo-icon-menu" CssClass="rounded-circle shadow show-navigation" Name="SideNavToggleBtn" GroupName="SideNavToggleBtn"></dx:BootstrapToolbarItem>
            <dx:BootstrapToolbarItem Text="User Settings" CssClass="no-icon demo-header-user-info align-items-center border-0 bg-light text-dark">
                <TextTemplate>
                    <dx:BootstrapImage runat="server" ImageUrl="~/Content/Icons/demo-user.svg"></dx:BootstrapImage>
                    <span>User Name</span>
                </TextTemplate>
                <Items>
                    <dx:BootstrapToolbarMenuItem Name="navigate_profile" Text="Profile" IconCssClass="demo-icon demo-icon-user" />
                    <dx:BootstrapToolbarMenuItem Name="logout" Text="Logout" IconCssClass="demo-icon demo-icon-logout" />
                </Items>
            </dx:BootstrapToolbarItem>
            <dx:BootstrapToolbarItem Name="show_messages" IconCssClass="demo-icon demo-icon-mail" CssClass="rounded-circle shadow ml-2 demo-item-wb">
                <Badge Text="8" CssClass="demo-badge-floating bg-success text-white" />
            </dx:BootstrapToolbarItem>
            <dx:BootstrapToolbarItem Name="show_notifications" IconCssClass="demo-icon demo-icon-alert" CssClass="rounded-circle shadow ml-2 demo-item-wb">
                <Badge Text="12" CssClass="demo-badge-floating bg-danger text-white" />
            </dx:BootstrapToolbarItem>
            <dx:BootstrapToolbarItem  IconCssClass="demo-icon demo-icon-settings m-0" CssClass="demo-header-toolbar-settings rounded-circle shadow ml-2">
                <Items>
                    <dx:BootstrapToolbarMenuItem GroupName="theme" Name="theme-light" Text="Light Theme" IconCssClass="demo-icon-light-theme" Checked="true"></dx:BootstrapToolbarMenuItem>
                    <dx:BootstrapToolbarMenuItem GroupName="theme" Name="theme-dark" Text="Dark Theme" IconCssClass="demo-icon-dark-theme"></dx:BootstrapToolbarMenuItem>
                </Items>
            </dx:BootstrapToolbarItem>
        </Items>
    </dx:BootstrapToolbar>
</div>--%>
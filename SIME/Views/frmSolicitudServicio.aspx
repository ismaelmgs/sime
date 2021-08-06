<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmSolicitudServicio.aspx.cs" Inherits="SIME.Views.frmSolicitudServicio" %>
<%@ Register Src="~/ControlesUsuario/ucMensaje.ascx" TagPrefix="uc1" TagName="ucMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function onUploadControlFileUploadComplete(s, e) {
            if(e.isValid)
                document.getElementById("uploadedImage").src = "UploadImages/" + e.callbackData;
            setElementVisible("uploadedImage", e.isValid);
        }
        function onImageLoad() {
            var externalDropZone = document.getElementById("externalDropZone");
            var uploadedImage = document.getElementById("uploadedImage");
            uploadedImage.style.left = (externalDropZone.clientWidth - uploadedImage.width) / 2 + "px";
            uploadedImage.style.top = (externalDropZone.clientHeight - uploadedImage.height) / 2 + "px";
            setElementVisible("dragZone", false);
        }
        function setElementVisible(elementId, visible) {
            document.getElementById(elementId).className = visible ? "" : "hidden";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <uc1:ucMensaje runat="server" ID="ucMensaje" />
    <div class="container-fluid">
        <div style="margin-left: 2%;">
            <br />
            <h5 class="page-title rlrH5" style="margin-left: -2%; margin-bottom: 1%; font-weight: bold;">Nueva solicitud de servicio</h5>
            <br />
        </div>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:1%"></td>
                <td style="width:98%">
                    <fieldset style="width: 100%; padding: 15px; margin-top: -40px; margin-bottom: 40px" class="card mb-4">
                        <header>
                            Tipo de servicio o reporte:
                        </header>
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:ASPxLabel ID="lblCategorias" runat="server" Text="Categoria:"></dx:ASPxLabel>
                            </div>
                            <div class="col-lg-4">
                                <dx:ASPxLabel ID="lblSubcategorias" runat="server" Text="Subcategoria:"></dx:ASPxLabel>
                            </div>
                            <div class="col-lg-4"></div>
                        </div>
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:BootstrapComboBox ID="ddlCategorias" runat="server" AutoPostBack="true" NullText="Seleccione"
                                    OnSelectedIndexChanged="ddlCategorias_SelectedIndexChanged">
                                    <ValidationSettings RequiredField-IsRequired="true" ValidationGroup="VGSolictitud" RequiredField-ErrorText="Seleccione una categoria"></ValidationSettings>
                                </dx:BootstrapComboBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapComboBox ID="ddlSubcategoria" runat="server" NullText="Seleccione">
                                    <ValidationSettings RequiredField-IsRequired="true" ValidationGroup="VGSolictitud" RequiredField-ErrorText="Seleccione una subvategoria"></ValidationSettings>
                                </dx:BootstrapComboBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapButton ID="btnAgregarServicio" runat="server" Text="Agregar servicio" OnClick="btnAgregarServicio_Click">
                                    <SettingsBootstrap RenderOption="Primary" />
                                </dx:BootstrapButton>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-10">
                                <dx:BootstrapGridView ID="gvServicios" runat="server" AutoGenerateColumns="false" KeyFieldName="Index"
                                    OnRowCommand="gvServicios_RowCommand">
                                    <Columns>
                                        <dx:BootstrapGridViewDataColumn FieldName="Categoria" Caption="Categoria"></dx:BootstrapGridViewDataColumn>
                                        <dx:BootstrapGridViewDataColumn FieldName="Subcategoria" Caption="Subcategoria"></dx:BootstrapGridViewDataColumn>
                                        <dx:BootstrapGridViewDataColumn Caption="Acciones" VisibleIndex="3" Settings-AllowDragDrop="False" CssClasses-HeaderCell="border-1" HorizontalAlign="Left">
                                            <DataItemTemplate>
                                                <dx:BootstrapButton ID="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("Index") %>'  CommandName="Eliminar">
                                                </dx:BootstrapButton>
                                            </DataItemTemplate>
                                        </dx:BootstrapGridViewDataColumn>
                                    </Columns>
                                </dx:BootstrapGridView>
                            </div>
                            <div class="col-lg-2"></div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-10">
                                <dx:BootstrapMemo ID="txtDescripcion" runat="server" Caption="Descripción:" Rows="3"></dx:BootstrapMemo>
                            </div>
                            <div class="col-lg-2"></div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-lg-10">
                                <fieldset style="width: 100%; padding: 15px; margin-top: -40px; margin-bottom: 40px" class="card mb-4">
                                    <header>
                                        Suba aquí sus archivos de evidencia.
                                    </header>
                                    <%--<div id="externalDropZone" class="dropZoneExternal">
                                        <div id="dragZone">
                                            <span class="dragZoneText">Drag an image here</span>
                                        </div>
                                        <img id="uploadedImage" src="#" class="hidden" alt="" onload="onImageLoad()" />
                                        <div id="dropZone" class="hidden">
                                            <span class="dropZoneText">Drop an image here</span>
                                        </div>
                                    </div>--%>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <dx:ASPxUploadControl ID="UploadControl" ClientInstanceName="UploadControl" runat="server" UploadMode="Auto" AutoStartUpload="True" Width="100%"
                                                ShowProgressPanel="True" DialogTriggerID="externalDropZone" OnFileUploadComplete="UploadControl_FileUploadComplete" >
                                                <AdvancedModeSettings EnableDragAndDrop="True" EnableFileList="False" EnableMultiSelect="False" ExternalDropZoneID="externalDropZone" DropZoneText="" />
                                                <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg, .jpeg, .gif, .png" ErrorStyle-CssClass="validationMessage" />
                                                <BrowseButton Text="Seleccione una imagen a subir..." />
                                                <DropZoneStyle CssClass="uploadControlDropZone" />
                                                <ClientSideEvents
                                                    DropZoneEnter="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', true); }"
                                                    DropZoneLeave="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', false); }"
                                                    FileUploadComplete="onUploadControlFileUploadComplete">
                                                </ClientSideEvents>
                                            </dx:ASPxUploadControl>
                                        </div>
                                        <div class="col-sm-6">
                                            <asp:Label ID="lblNombreFoto1" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="row" style="height:15px"></div>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <dx:ASPxUploadControl ID="UploadControl2" ClientInstanceName="UploadControl2" runat="server" UploadMode="Auto" AutoStartUpload="True" Width="100%"
                                                ShowProgressPanel="True" DialogTriggerID="externalDropZone" OnFileUploadComplete="UploadControl2_FileUploadComplete" >
                                                <AdvancedModeSettings EnableDragAndDrop="True" EnableFileList="False" EnableMultiSelect="False" ExternalDropZoneID="externalDropZone" DropZoneText="" />
                                                <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg, .jpeg, .gif, .png" ErrorStyle-CssClass="validationMessage" />
                                                <BrowseButton Text="Seleccione una imagen a subir..." />
                                                <DropZoneStyle CssClass="uploadControlDropZone" />
                                                <ClientSideEvents
                                                    DropZoneEnter="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', true); }"
                                                    DropZoneLeave="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', false); }"
                                                    FileUploadComplete="onUploadControlFileUploadComplete">
                                                </ClientSideEvents>
                                            </dx:ASPxUploadControl>
                                        </div>
                                        <div class="col-sm-6"></div>
                                    </div>
                                    <div class="row" style="height:15px"></div>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <dx:ASPxUploadControl ID="UploadControl3" ClientInstanceName="UploadControl3" runat="server" UploadMode="Auto" AutoStartUpload="True" Width="100%"
                                                ShowProgressPanel="True" DialogTriggerID="externalDropZone" OnFileUploadComplete="UploadControl3_FileUploadComplete" >
                                                <AdvancedModeSettings EnableDragAndDrop="True" EnableFileList="False" EnableMultiSelect="False" ExternalDropZoneID="externalDropZone" DropZoneText="" />
                                                <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg, .jpeg, .gif, .png" ErrorStyle-CssClass="validationMessage" />
                                                <BrowseButton Text="Seleccione una imagen a subir..." />
                                                <DropZoneStyle CssClass="uploadControlDropZone" />
                                                <ClientSideEvents
                                                    DropZoneEnter="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', true); }"
                                                    DropZoneLeave="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', false); }"
                                                    FileUploadComplete="onUploadControlFileUploadComplete">
                                                </ClientSideEvents>
                                            </dx:ASPxUploadControl>
                                        </div>
                                        <div class="col-sm-6"></div>
                                    </div>
                                    <small>Extensiones permitidas: .jpg, .jpeg, .png.</small>
                                    <small>Tamaño maximo de archivo: 4 MB.</small>
                                </fieldset>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-12" style="text-align:center">
                                <dx:BootstrapButton ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" ValidationGroup="VGSolictitud">
                                    <SettingsBootstrap RenderOption="Success" />
                                </dx:BootstrapButton>
                            </div>
                        </div>
                    </fieldset>
                </td>
                <td style="width:1%"></td>
            </tr>
        </table>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMasa.aspx.cs" Inherits="ProyectoMasasWEB.AgregarMasa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                        <h3>Agregar Masa</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="codTxt">Código de la masa</label>
                        <asp:Textbox ID="codTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:Textbox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="codTxt" CssClass="text-danger" runat="server" ErrorMessage="Debe ingresar un código"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="tipoRbl">Seleccione tipo de masa</label>
                        <asp:RadioButtonList ID="tipoRbl" runat="server">
                            <asp:ListItem Text="Masa para sopaipillas" Selected="True" Value="Masa para sopaipillas"></asp:ListItem>
                            <asp:ListItem Text="Masa para empanadas fritas" Value="Masa para empanadas fritas"></asp:ListItem>
                            <asp:ListItem Text="Masa para empanadas de horno"  Value="Masa para empanadas de horno"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

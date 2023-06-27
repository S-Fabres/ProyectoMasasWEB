<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ModificarMasa.aspx.cs" Inherits="ProyectoMasasWEB.ModificarMasa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Modificar masa</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="codigoTxt">Código de la masa</label>
                        <asp:TextBox ID="codigoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tipoRbl">Tipo</label>
                        <asp:RadioButtonList ID="tipoRbl" runat="server">
                            <asp:ListItem Text="Masa para sopaipillas" Selected="True" Value="Masa para sopaipillas"></asp:ListItem>
                            <asp:ListItem Text="Masa para empanadas fritas" Value="Masa para empanadas fritas"></asp:ListItem>
                            <asp:ListItem Text="Masa para empanadas de horno" Value="Masa para empanadas de horno"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="modificarBtn_Click" ID="modificarBtn" Text="Modificar" />
                    
                </div>
            </div>
        </div>
    </div> 
</asp:Content>

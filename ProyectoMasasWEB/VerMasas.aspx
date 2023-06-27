<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMasas.aspx.cs" Inherits="ProyectoMasasWEB.VerMasas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="row">
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
               <div class="row mt-5">
               <asp:GridView
                   CssClass="table table-hover table-bordered"
                   ID="grillaMasas"
                   AutoGenerateColumns="false"
                   ShowHeaderWhenEmpty="true"
                   EmptyDataText="No hay registros"
                   runat="server"
                   OnRowCommand="grillaMasas_RowCommand">
                   <Columns>
                       <asp:BoundField HeaderText="Código de la masa" DataField="Codigo" />
                       <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                       <asp:TemplateField HeaderText="Acción">
                           <ItemTemplate>
                                <asp:Button CssClass="btn btn-warning" runat="server"
                                    CommandName="modificar" Text="Modificar"
                                    CommandArgument='<%# Eval("Codigo") %>' />
                            </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Acción">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-danger" runat="server"
                                    CommandName="eliminar" Text="Eliminar"
                                    CommandArgument='<%# Eval("Codigo") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                   </Columns>
               </asp:GridView>
               </div>
           </ContentTemplate>
       </asp:UpdatePanel>
   </div>
</asp:Content>

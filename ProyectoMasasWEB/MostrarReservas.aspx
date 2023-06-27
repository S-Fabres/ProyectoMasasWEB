<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarReservas.aspx.cs" Inherits="ProyectoMasasWEB.MostrarReservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="row">
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
               <div class="row mt-5">
               <asp:GridView
                   CssClass="table table-hover table-bordered"
                   ID="grillaReservas"
                   AutoGenerateColumns="false"
                   ShowHeaderWhenEmpty="true"
                   EmptyDataText="No hay registros"
                   runat="server"
                   OnRowCommand="grillaReservas_RowCommand">
                   <Columns>
                       <asp:BoundField HeaderText="Id de la reserva" DataField="IdReserva" />
                       <asp:BoundField HeaderText="Tipo de masa" DataField="TipoMasa" />
                       <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                       <asp:BoundField HeaderText="Fecha de ingreso" DataField="FechaIngreso" />
                       <asp:BoundField HeaderText="Fecha de entrega" DataField="FechaEntrega" />
                       <asp:BoundField HeaderText="Hora de entrega" DataField="HoraEntrega" />
                       <asp:BoundField HeaderText="Tipo de entrega" DataField="TipoEntrega" />
                       <asp:TemplateField HeaderText="Acción">
                           <ItemTemplate>
                                <asp:Button CssClass="btn btn-warning" runat="server"
                                    CommandName="modificar" Text="Modificar"
                                    CommandArgument='<%# Eval("IdReserva") %>' />
                            </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Acción">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-danger" runat="server"
                                    CommandName="eliminar" Text="Eliminar"
                                    CommandArgument='<%# Eval("IdReserva") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                   </Columns>
               </asp:GridView>
               </div>
           </ContentTemplate>
       </asp:UpdatePanel>
   </div>
</asp:Content>

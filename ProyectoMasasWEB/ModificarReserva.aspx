<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ModificarReserva.aspx.cs" Inherits="ProyectoMasasWEB.ModificarReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Modificar reserva</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="idReservaTxt">Id de la reserva</label>
                        <asp:TextBox ID="idReservaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tipoMasaDdl">Tipo de masa</label>
                        <asp:DropDownList ID="tipoMasaDdl" runat="server"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="cantidadTxt">Cantidad</label>
                        <asp:TextBox ID="cantidadTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="cantidadTxt" CssClass="text-danger" runat="server" ErrorMessage="Debe ingresar una cantidad"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" ControlToValidate="cantidadTxt" CssClass="text-danger" Type="Integer" runat="server" ErrorMessage="Debe ingresar una cantidad mínima de 50 unidades" MinimumValue="50"></asp:RangeValidator>
                    </div>
                    <div class="form-group">
                        <label for="CalendarFecha">Fecha de reserva</label>
                        <asp:Calendar ID="CalendarFechaReserva" runat="server"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="CalendarFecha">Fecha de entrega</label>
                        <asp:Calendar ID="CalendarFechaEntrega" runat="server"></asp:Calendar>
                    </div>

                    <div class="form-group">
                        <div class="col-2">
                            <label for="horaTxt">Hora de entrega</label>
                            <asp:TextBox ID="horaEntregaTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RangeValidator ID="RangeValidator4" ControlToValidate="horaEntregaTxt" CssClass="text-danger" Type="String" runat="server" ErrorMessage="Debe ingresar hora en el siguiente formato: HH:MM donde las horas van del 01 al 23 y los minutos del 01 a 59" MinimumValue="01" MaximumValue="59"></asp:RangeValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe llenar el campo" ControlToValidate="horaEntregaTxt" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="tipoEntregaRbl">Tipo de entrega</label>
                        <asp:RadioButtonList ID="tipoEntregaRbl" runat="server">
                            <asp:ListItem Text="Entrega a domicilio, costo: $2500" Selected="True" Value="Entrega a domicilio"></asp:ListItem>
                            <asp:ListItem Text="Retiro en local" Value="Retiro en local"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="modificarBtn_Click" ID="modificarBtn" Text="Modificar" />
                    
                </div>
            </div>
        </div>
    </div> 
</asp:Content>

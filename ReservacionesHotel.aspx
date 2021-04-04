<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservacionesHotel.aspx.cs" Inherits="Actividad_Integradora_7_Problema_5.ReservacionesHotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ---------------Consulta Reservacion------------<br />
            <br />
            Nombre:
            <asp:TextBox ID="txtBuscar" runat="server" Height="44px" Width="308px"></asp:TextBox>
            <br />
            <asp:Button ID="BtnBuscar" runat="server" OnClick="Button1_Click" Text="Buscar" />
            <br />
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblFecha" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblHora" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblDias" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblCosto" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblPersonas" runat="server"></asp:Label>
            <br />
            <br />
            ---------------Agrega Recervacion--------------<br />
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Fecha:
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <br />
            Hora:
            <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
            <br />
            Dias:
            <asp:TextBox ID="txtDias" runat="server"></asp:TextBox>
            <br />
            Costo:
            <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
            <br />
            Persona:
            <asp:TextBox ID="txtPersona" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnAgregar" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
        </div>
    </form>
</body>
</html>

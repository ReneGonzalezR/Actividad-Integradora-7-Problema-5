using System;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_7_Problema_5
{
    public partial class ReservacionesHotel : System.Web.UI.Page
    {
        ServiceReservaciones.WebService1SoapClient miservicio = new ServiceReservaciones.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = string.Empty, fecha = string.Empty, hora = string.Empty, dias = string.Empty, costo = string.Empty, personas = string.Empty;
            miservicio.ConsultarReservacion(txtBuscar.Text, ref nombre, ref fecha, ref hora, ref dias, ref costo, ref personas);
            lblNombre.Text = "Nombre: " + nombre;
            lblFecha.Text = "Fecha: " + fecha;
            lblHora.Text = "Hora: " + hora;
            lblDias.Text = "Dias: " + dias;
            lblCosto.Text = "Costo: $" + costo;
            lblPersonas.Text = "Personas: " + personas;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            miservicio.AgregarReservacion(txtNombre.Text, txtFecha.Text, txtHora.Text, txtDias.Text, txtCosto.Text, txtPersona.Text);
            txtNombre.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtHora.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtPersona.Text = string.Empty;
        }
    }
}
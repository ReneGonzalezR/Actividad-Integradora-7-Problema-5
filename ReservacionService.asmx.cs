using System.Web.Services;
using System.Data.SqlClient;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_7_Problema_5
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public bool ConsultarReservacion(string valor, ref string nombre, ref string fecha, ref string hora, ref string dias, ref string costo, ref string personas )
        {
            bool bandera = true;
            try
            {
                SqlConnection conexion = new SqlConnection("server=RENEGONZALEZ\\SQLEXPRESS ; database=Hotel ; integrated security = true");
                conexion.Open();
                string query = string.Format("select nombre, fecha, hora, dias, costo, personas from Reservacion where nombre = '{0}';", valor);
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    nombre = dr["nombre"].ToString();
                    fecha = dr["fecha"].ToString();
                    hora = dr["hora"].ToString();
                    dias = dr["dias"].ToString();
                    costo = dr["costo"].ToString();
                    personas = dr["personas"].ToString();
                }
                dr.Close();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                bandera = false;
            }
            return bandera;
        }
        [WebMethod]
        public bool AgregarReservacion(string nombre, string fecha, string hora, string dias, string costo, string personas)
        {
            bool bandera = true;
            try
            {
                SqlConnection conexion = new SqlConnection("server=RENEGONZALEZ\\SQLEXPRESS ; database=Hotel ; integrated security = true");
                conexion.Open();
                string query = string.Format("Insert into Reservacion values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", nombre, fecha, hora, dias, costo, personas);
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                bandera = false;
            }

            return bandera;
        }
    }
}

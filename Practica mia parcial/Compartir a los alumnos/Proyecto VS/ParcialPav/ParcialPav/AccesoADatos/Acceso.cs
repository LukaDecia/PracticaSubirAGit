using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPav.AccesoADatos
{
    public class Acceso
    {
        public static int ObtenerUltimoIDEquipo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(Id) FROM Equipos";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerCategorias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Categorias";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerPosiciones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Posiciones";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerJugadorXNro(int IdJugador)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Jugadores WHERE Id = @IdJugador";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdJugador", IdJugador);

                cn.Open();
                cmd.Connection = cn;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AltaNuevoEquipo(string nombreEquipo, DateTime fecha, List<Jugador> listaJugadores, int idNuevoEquipo )
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlTransaction objTransaccion = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sqlEquipo = "INSERT INTO Equipos VALUES(@NombreEquipo,@FechaCreacion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreEquipo", nombreEquipo);
                cmd.Parameters.AddWithValue("@FechaCreacion", fecha);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlEquipo;


                con.Open();
                objTransaccion = con.BeginTransaction("");
                cmd.Transaction = objTransaccion;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                foreach (var jugador in listaJugadores)
                {
                    string sqlJugadores = "INSERT INTO JugadoresPorEquipos VALUES(@IdJugador,@IdEquipo, @FechaAsignacion)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IdJugador", jugador.Id1);
                    cmd.Parameters.AddWithValue("@IdEquipo", idNuevoEquipo);
                    cmd.Parameters.AddWithValue("@FechaAsignacion", fecha);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlJugadores;
                    cmd.ExecuteNonQuery();
                }
                objTransaccion.Commit();
                return true;

            }
            catch (Exception)
            {

                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable ObtenerListadoJugadores()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Jugadores";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerEquipos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Equipos";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerJugadoresXEquipo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM JugadoresPorEquipos";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }






































    }
}

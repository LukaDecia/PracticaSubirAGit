using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloInventadoPractica.AccesoADatos
{
    public class Acceso
    {
        public static int ObtenerUltimoNroPedido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(Id) FROM Pedidos";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                int res = (int)cmd.ExecuteScalar();
                return res;
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
                string consulta = "SELECT * FROM Categoria";
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

        public static DataTable ObtenerTiposMascotas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TipoMascota";
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

        public static DataTable ObtenerMascotaXId(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Mascotas WHERE Id=@IdMascota";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdMascota", id);

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

        public static bool GenerarPedidoAdopcion(string adoptante, DateTime fechaActual, List<Mascota> listaMascotas, int idPedido)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlTransaction objTransaccion = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Pedido VALUES(@FechaCreacion,@Adoptante)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FechaCreacion", fechaActual);
                cmd.Parameters.AddWithValue("@Adoptante", adoptante);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                con.Open();
                objTransaccion = con.BeginTransaction("Transacción Adopción Mascotas");
                cmd.Transaction = objTransaccion;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                foreach (var mascota in listaMascotas)
                {
                    string consulta2 = "INSERT INTO MascotasPorPedido VALUES(@IdPedido,@IdMascota, @FechaAdopcion)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                    cmd.Parameters.AddWithValue("@IdMascota", mascota.Id);
                    cmd.Parameters.AddWithValue("@FechaAdopcion", fechaActual);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta2;
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

        public static DataTable ObtenerListadoMascotas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Mascotas";
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

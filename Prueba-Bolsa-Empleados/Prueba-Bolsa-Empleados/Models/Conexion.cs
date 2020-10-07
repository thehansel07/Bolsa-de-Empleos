using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prueba_Bolsa_Empleados.Models
{
    public class Conexion
    {
        string ConnectionString = "workstation id=DBBolsaEmpleo.mssql.somee.com;packet size=4096;user id=Hansel08_SQLLogin_1;pwd=9ibc3tcouk;data source=DBBolsaEmpleo.mssql.somee.com;persist security info=False;initial catalog=DBBolsaEmpleo";





        public void AgregarPublicacionesDiseñado(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Agregar_Publicacion_Diseñado", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }

        public void AgregarPublicacionesProgramador(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Agregar_Publicacion_Programador", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }
        public void AgregarPublicacionesAdministrativa(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Agregar_Publicacion_Administrativa ", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }



        public void AgregarPublicacionesMantenimiento(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Agregar_Publicacion_Mantenimiento ", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }



        public void Agregar_Empleado(Empleado empleado)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Insertar_Empleado", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("Usuario", empleado.Usuario);
                comando.Parameters.AddWithValue("Contraseña", empleado.Contraseña);
                comando.Parameters.AddWithValue("Dirreccion", empleado.Dirreccion);
                comando.Parameters.AddWithValue("idpais", empleado.idpais);



                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }
        public void Modificar_Empleado(Empleado empleado)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Actualizar_Empleado", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("IDEmpleado", empleado.IDEmpleado);
                comando.Parameters.AddWithValue("Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("Usuario", empleado.Usuario);
                comando.Parameters.AddWithValue("Contraseña", empleado.Contraseña);
                comando.Parameters.AddWithValue("Dirreccion", empleado.Dirreccion);
                comando.Parameters.AddWithValue("idpais", empleado.idpais);



                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }
























        public IEnumerable<Publicacion> TodolasPublicacion()
        {
            List<Publicacion> lista = new List<Publicacion>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Obtener_Todo_Programdor", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Publicacion publicacion = new Publicacion();
                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();


                    lista.Add(publicacion);
                }
                con.Close();
            }
            return lista;



        }


        public IEnumerable<Publicacion> lasPublicacion()
        {
            List<Publicacion> lista = new List<Publicacion>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Obtener_Todo_diseñado", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Publicacion publicacion = new Publicacion();
                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();


                    lista.Add(publicacion);
                }
                con.Close();
            }
            return lista;



        }

        public Publicacion FiltrarDatosProgramador(int? idPublicacion)
        {
            Publicacion publicacion = new Publicacion();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Obtener_Publicacion_Prog", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPublicaciones", idPublicacion);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();



                }
                con.Close();
            }
            return publicacion;




        }

        public Publicacion FiltrarDatosDiseñador(int? idPublicacion)
        {
            Publicacion publicacion = new Publicacion();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Obtener_Diseñado_id", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPublicaciones", idPublicacion);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();



                }
                con.Close();
            }
            return publicacion;




        }





        public Publicacion ObtenerFechaDiseñador(Date? Fecha_Publicacion)
        {
            Publicacion publicacion = new Publicacion();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("obtener_Diseñado_Fecha", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Fecha_Publicacion", Fecha_Publicacion);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();



                }
                con.Close();
            }
            return publicacion;




        }




























        public IEnumerable<Publicacion> TodolasPublicacion_Adminitrativa()
        {
            List<Publicacion> lista = new List<Publicacion>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Obtener_Todo_Administrativa", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Publicacion publicacion = new Publicacion();
                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();


                    lista.Add(publicacion);
                }
                con.Close();
            }
            return lista;



        }

        public Publicacion FiltrarDatosAdministrativa(int? idPublicacion)
        {
            Publicacion publicacion = new Publicacion();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("obtener_id_Administrativa", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPublicaciones", idPublicacion);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();



                }
                con.Close();
            }
            return publicacion;




        }

        public IEnumerable<Publicacion> TodolasPublicacion_Matenimiento()
        {
            List<Publicacion> lista = new List<Publicacion>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Obtener_Todo_Mantenimiento", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Publicacion publicacion = new Publicacion();
                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();


                    lista.Add(publicacion);
                }
                con.Close();
            }
            return lista;



        }

        public void EliminarEmpleado(int? id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Eliminar_Empleado", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDEmpleado", id);


                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }


        }





        public Empleado Obtener_datos_empleado(int? id)
        {
            Empleado empleado = new Empleado();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("obtener_Empleado", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDEmpleado", id);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {


                    empleado.IDEmpleado = Convert.ToInt32(leer["IDEmpleado"].ToString());
                    empleado.Nombre = leer["Nombre"].ToString();
                    empleado.Usuario = leer["Usuario"].ToString();
                    empleado.Contraseña = leer["Contraseña"].ToString();
                    empleado.Dirreccion = leer["Dirreccion"].ToString();
                    empleado.idpais = Convert.ToInt32(leer["idpais"].ToString());



                }
                con.Close();
            }
            return empleado;




        }


        public Publicacion FiltrarDatosMantenimiento(int? idPublicacion)
        {
            Publicacion publicacion = new Publicacion();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("obtener_id_mantenimiento", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPublicaciones", idPublicacion);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();



                }
                con.Close();
            }
            return publicacion;




        }




        public Publicacion Obtener_id_Empleado(int? idPublicacion)
        {
            Publicacion publicacion = new Publicacion();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("obtener_Empleado", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDEmpleado", idPublicacion);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {

                    publicacion.idPublicaciones = Convert.ToInt32(leer["idPublicaciones"].ToString());
                    publicacion.idpais = Convert.ToInt32(leer["idpais"].ToString());
                    publicacion.Categoria = leer["Categoria"].ToString();
                    publicacion.idEmpleado = Convert.ToInt32(leer["idEmpleado"].ToString());
                    publicacion.idAdministrador = Convert.ToInt32(leer["idAdministrador"].ToString());
                    publicacion.Nombre_Compañia = leer["Nombre_Compañia"].ToString();
                    publicacion.Tipo_Horario = leer["Tipo_Horario"].ToString();
                    publicacion.Fecha_Publicacion = Convert.ToDateTime(leer["Fecha_Publicacion"].ToString());
                    publicacion.Correo = leer["Correo"].ToString();
                    publicacion.Logo = leer["Logo"].ToString();
                    publicacion.Url_Pagina = leer["Url_Pagina"].ToString();
                    publicacion.Posicion = leer["Posicion"].ToString();
                    publicacion.Dirreccion = leer["Dirreccion"].ToString();



                }
                con.Close();
            }
            return publicacion;




        }







        public void ActualizarDiseñador(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Actualizar_Diseñador", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idPublicacion", publicacion.idPublicaciones);
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }


        public void EliminarDiseñado (int? id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Eliminar_Diseñado", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPublicaciones", id);


                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }


        }

        public void EliminarProgramador(int? id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Eliminar_Programador", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPublicaciones", id);


                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }


        }

        public void ActualizarProgramador(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Actualizar_Programador", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idPublicacion", publicacion.idPublicaciones);
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }


        public void ActualizarAdministrativa(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Actualizar_Administrativa", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idPublicacion", publicacion.idPublicaciones);
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }

        public void EliminarAdministrativa(int? id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Eliminar_Administrativa", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPublicaciones", id);


                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }


        }

        public void ActualizarMantenimiento(Publicacion publicacion)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Actualizar_Mantenimiento", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idPublicacion", publicacion.idPublicaciones);
                comando.Parameters.AddWithValue("idpais", publicacion.idpais);
                comando.Parameters.AddWithValue("Categoria", publicacion.Categoria);
                comando.Parameters.AddWithValue("idEmpleado", publicacion.idEmpleado);
                comando.Parameters.AddWithValue("idAdministrador", publicacion.idAdministrador);
                comando.Parameters.AddWithValue("Nombre_Compañia", publicacion.Nombre_Compañia);
                comando.Parameters.AddWithValue("Tipo_Horario", publicacion.Tipo_Horario);
                comando.Parameters.AddWithValue("Fecha_Publicacion", publicacion.Fecha_Publicacion);
                comando.Parameters.AddWithValue("Correo", publicacion.Correo);
                comando.Parameters.AddWithValue("Logo", publicacion.Logo);
                comando.Parameters.AddWithValue("Url_Pagina", publicacion.Url_Pagina);
                comando.Parameters.AddWithValue("Posicion", publicacion.Posicion);
                comando.Parameters.AddWithValue("Dirreccion", publicacion.Dirreccion);

                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }
        public void EliminarMantenimiento(int? id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand comando = new SqlCommand("Eliminar_Mantenimiento", con);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPublicacion", id);


                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }


        }



        public IEnumerable<Empleado> TodosLosEmpleados()
        {
            List<Empleado> listado = new List<Empleado>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Ver_Empleados", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.IDEmpleado = Convert.ToInt32(leer["IDEmpleado"].ToString());
                    empleado.Nombre = leer["Nombre"].ToString();
                    empleado.Usuario = leer["Usuario"].ToString();
                    empleado.Contraseña = leer["Contraseña"].ToString();
                    empleado.Dirreccion = leer["Dirreccion"].ToString();
                    empleado.idpais = Convert.ToInt32(leer["idpais"].ToString());

                    listado.Add(empleado);
                }
                con.Close();
            }
            return listado;



        }


        public IEnumerable<Usuario> Ver_Usuario()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("Ver_Postulados", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Cedula = leer["Cedula"].ToString();
                    usuario.Nombre = leer["Nombre"].ToString();
                    usuario.Telefono = leer["Telefono"].ToString();
                    usuario.Interes = leer["Interes"].ToString();
                    usuario.Correo = leer["Correo"].ToString();
                    usuario.idCategoria = Convert.ToInt32(leer["idcategoria"].ToString());
                    usuario.Puesto = leer["Puesto"].ToString();
                    lista.Add(usuario);
                }
                con.Close();
            }
            return lista;



        }


        public void AgregarPostulado(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand comando = new SqlCommand("InsertarPostulados", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("Cedula", usuario.Nombre);
                comando.Parameters.AddWithValue("Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("Telefono", usuario.Telefono);
                comando.Parameters.AddWithValue("idcategoria", usuario.idCategoria);
                comando.Parameters.AddWithValue("Interes", usuario.Interes);
                comando.Parameters.AddWithValue("Puestos", usuario.Puesto);
                comando.Parameters.AddWithValue("Correo ", usuario.Correo);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();



            }
        }



    }
}
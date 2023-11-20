using Libreria.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Datos
{
    public class HelperDB
    {
        private SqlConnection cnn;

        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.ConexionString7);
        }

        public int Login(string usario, string pass)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("pa_login", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usario);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }

        public DataTable EjecutarSP(string nom_sp)
        {
            DataTable dt = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(nom_sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }

        public List<Modelo> ObtenerModelos()
        {
            List<Modelo> lst = new List<Modelo>();

            DataTable t = EjecutarSP("pa_modelos");

            foreach (DataRow dr in t.Rows)
            {
                int codigo = int.Parse(dr["cod_modelo"].ToString());
                string nombre = dr["modelo"].ToString();

                Modelo aux = new Modelo(codigo, nombre);
                lst.Add(aux);
            }

            return lst;
        }

        public List<TipoVehiculo> ObtenerTiposVehiculos()
        {
            List<TipoVehiculo> lst = new List<TipoVehiculo>();

            DataTable t = EjecutarSP("pa_tipos_vehiculos");

            foreach (DataRow dr in t.Rows)
            {
                int codigo = int.Parse(dr["cod_tipo_vehiculo"].ToString());
                string tipo = dr["descripcion"].ToString();

                TipoVehiculo aux = new TipoVehiculo(codigo, tipo);
                lst.Add(aux);
            }

            return lst;
        }

        public List<TipoEmpleado> ObtenerTiposEmpleado()
        {
            List<TipoEmpleado> lst = new List<TipoEmpleado>();

            DataTable t = EjecutarSP("sp_tipos_empleado");

            foreach (DataRow dr in t.Rows)
            {
                int codigo = int.Parse(dr["cod_tipo_empleado"].ToString());
                string tipo = dr["descripcion"].ToString();

                TipoEmpleado aux = new TipoEmpleado(codigo, tipo);
                lst.Add(aux);
            }

            return lst;
        }



        public List<Producto> ObtenerAutopartes()
        {
            List<Producto> lst = new List<Producto>();

            DataTable t = EjecutarSP("pa_autopartes");

            foreach (DataRow dr in t.Rows)
            {
                Producto aux = new Producto();
                aux.CodProducto = int.Parse(dr["cod_producto"].ToString());
                aux.Descripcion = dr["descripcion"].ToString();
                lst.Add(aux);
            }

            return lst;
        }

        public int ObtenerProxFactura()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)pOut.Value;
        }

        public int ObtenerProxProducto()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID_PRODUCTO";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)pOut.Value;
        }

        public List<Autoplan> ObtenerAutoplanes()
        {
            List<Autoplan> lst = new List<Autoplan>();
            DataTable dt = EjecutarSP("pa_autoplanes");

            foreach (DataRow fila in dt.Rows)
            {
                Autoplan aux = new Autoplan();
                aux.CodPlan = int.Parse(fila["cod_plan"].ToString());
                aux.NomPlan = fila["nom_plan"].ToString();
                lst.Add(aux);
            }

            return lst;
        }

        public List<Producto> ObtenerAutomoviles()
        {
            List<Producto> lst = new List<Producto>();
            DataTable dt = EjecutarSP("pa_automoviles");

            foreach (DataRow fila in dt.Rows)
            {
                Producto aux = new Producto();
                aux.CodProducto = int.Parse(fila["cod_producto"].ToString());
                aux.Descripcion = fila["automovil"].ToString();
                lst.Add(aux);
            }
            return lst;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lst = new List<Cliente>();
            DataTable dt = EjecutarSP("pa_clientes");

            foreach (DataRow fila in dt.Rows)
            {
                Cliente aux = new Cliente();
                aux.NroFactura = int.Parse(fila["cod_factura"].ToString());
                aux.Nombre = fila["nom_cliente"].ToString();
                lst.Add(aux);
            }
            return lst;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> lst = new List<Empleado>();
            DataTable dt = EjecutarSP("sp_empleados");

            foreach (DataRow fila in dt.Rows)
            {
                Empleado aux = new Empleado();
                aux.Legajo = int.Parse(fila["legajo"].ToString());
                aux.Nombre = fila["nombre"].ToString();
                aux.Tipo_empleado = int.Parse(fila["cod_tipo_empleado"].ToString());
                lst.Add(aux);
            }
            return lst;
        }

        public bool InsertarEmpleado(Empleado oEmpleado)
        {
            bool aux = false;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdEmpleado = new SqlCommand("SP_INSERTAR_EMPLEADO", cnn, t);
                cmdEmpleado.CommandType = CommandType.StoredProcedure;

               
                cmdEmpleado.Parameters.AddWithValue("@nombre", oEmpleado.Nombre);
                cmdEmpleado.Parameters.AddWithValue("@cod_tipo_empleado", oEmpleado.Tipo_empleado);

                cmdEmpleado.ExecuteNonQuery();

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)
                {
                    t.Rollback();
                }
               
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return aux;
        }



        public bool InsertarMD(Factura oFactura)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                //configuro cmd para insertar Maestro
                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_FACTURA", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                //parametros de entrada
                cmdMaestro.Parameters.AddWithValue("@cod_empleado", oFactura.CodEmpleado);
                cmdMaestro.Parameters.AddWithValue("@nom_cliente", oFactura.NomCliente);
                cmdMaestro.Parameters.AddWithValue("@cuit", oFactura.Cuit);
                cmdMaestro.Parameters.AddWithValue("@cod_plan", oFactura.CodPlan);
                cmdMaestro.Parameters.AddWithValue("@cod_tipo_cliente", oFactura.CodTipoCliente);

                //configuro param de salida para recibir el id del maestro
                SqlParameter paramSalida = new SqlParameter();
                paramSalida.ParameterName = "@cod_factura";
                paramSalida.DbType = DbType.Int32;
                paramSalida.Direction = ParameterDirection.Output;

                cmdMaestro.Parameters.Add(paramSalida);

                //ejecuto cmdMaestro y guardo el identity
                cmdMaestro.ExecuteNonQuery();
                int idMaestro = (int)paramSalida.Value;

                //para ingresar cada detalle del maestro
                SqlCommand cmdDetalle = null;
                foreach (DetalleFactura det in oFactura.Detalles)
                {
                    //configuro cmd para insertar el detalle
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    //parametros de entrada
                    cmdDetalle.Parameters.AddWithValue("@cod_factura", idMaestro);
                    cmdDetalle.Parameters.AddWithValue("@cod_producto",det.CodProducto);
                    //cmdDetalle.Parameters.AddWithValue("@patente", det.Auto.Patente);
                    //cmdDetalle.Parameters.AddWithValue("@nro_serie", det.AutoP.NroSerie);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", det.Precio);
                    cmdDetalle.ExecuteNonQuery();
                }

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)//si "t" no es null es porq hubo en error
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)//si la conex existe y esta abierta
                {
                    cnn.Close();
                }
            }

            return aux;
        }

        public bool EliminarFactura(int codFactura)
        {
            int res = 0;
            SqlCommand cmd = new SqlCommand("pa_eliminar_factura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.AddWithValue("@cod", codFactura);
            res = cmd.ExecuteNonQuery();

            if (res == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Factura ObtenerFactura(int nroFactura)
        {
            Factura oFactura = new Factura();

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("pa_consultar_factura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cod", nroFactura);

            cnn.Open();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow fila in dt.Rows)
            {
                oFactura.CodFactura = int.Parse(fila["cod_factura"].ToString());
                oFactura.CodEmpleado = int.Parse(fila["cod_empleado"].ToString());
                oFactura.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
                oFactura.NomCliente = fila["nom_cliente"].ToString();
                oFactura.CodPlan = int.Parse(fila["cod_plan"].ToString());

                /*
                oFactura.Cuit = int.Parse(fila["cuit"].ToString());
                oFactura.CodTipoCliente = int.Parse(fila["cod_tipo_cliente"].ToString());*/
            }

            DataTable dt2 = new DataTable();
            SqlCommand cmd2 = new SqlCommand("pa_consultar_detalle", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("cod", nroFactura);

            cnn.Open();
            dt2.Load(cmd2.ExecuteReader());
            cnn.Close();

            foreach(DataRow fila in dt2.Rows)
            {
                DetalleFactura oDetalle = new DetalleFactura();
                oDetalle.CodProducto = int.Parse(fila["cod_producto"].ToString());
                oDetalle.Descripcion = fila["descripcion"].ToString();
                oDetalle.Cantidad = int.Parse(fila["cantidad"].ToString());
                oDetalle.Precio = double.Parse(fila["precio"].ToString());

                oFactura.AgregarDetalle(oDetalle);
            }


            return oFactura;
        }

        //ERIC

        public bool InsertarAutoparte(Autoparte oAutoparte)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                //configuro cmd para insertar Maestro
                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_AUTOPARTE", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@descripcion", oAutoparte.Descripcion);
                cmdMaestro.Parameters.AddWithValue("@modelo", oAutoparte.Modelo);
                cmdMaestro.Parameters.AddWithValue("@vehiculo", oAutoparte.TipoVehiculo);
                cmdMaestro.Parameters.AddWithValue("@precio", oAutoparte.Precio);

                cmdMaestro.ExecuteNonQuery();

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return aux;

        }



        public bool ModificarAutoparte(Autoparte oAutoparte)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                //configuro cmd para insertar Maestro
                SqlCommand cmdMaestro = new SqlCommand("SP_MODIFICAR_AUTOPARTE", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@cod", oAutoparte.Codigo);
                cmdMaestro.Parameters.AddWithValue("@descripcion", oAutoparte.Descripcion);
                cmdMaestro.Parameters.AddWithValue("@modelo", oAutoparte.Modelo);
                cmdMaestro.Parameters.AddWithValue("@vehiculo", oAutoparte.TipoVehiculo);
                cmdMaestro.Parameters.AddWithValue("@precio", oAutoparte.Precio);

                cmdMaestro.ExecuteNonQuery();

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)//si la conex existe y esta abierta
                {
                    cnn.Close();
                }
            }

            return aux;

        }



        public bool InsertarAutomovil(Automovil oAutomovil)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_AUTOMOVIL", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@modelo", oAutomovil.Modelo);
                cmdMaestro.Parameters.AddWithValue("@vehiculo", oAutomovil.TipoVehiculo);
                cmdMaestro.Parameters.AddWithValue("@precio", oAutomovil.Precio);

                cmdMaestro.ExecuteNonQuery();

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return aux;

        }

        public bool ModificarAutomovil(Automovil oAutomovil)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_MODIFICAR_AUTOMOVIL", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@cod", oAutomovil.Codigo);
                cmdMaestro.Parameters.AddWithValue("@vehiculo", oAutomovil.TipoVehiculo);
                cmdMaestro.Parameters.AddWithValue("@precio", oAutomovil.Precio);

                cmdMaestro.ExecuteNonQuery();

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return aux;

        }


        public string ConsultarAutoparte(int codAutoparte, string value)
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_CONSULTAR_" + value;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", codAutoparte);
            SqlParameter nombre = new SqlParameter();
            nombre.ParameterName = "@value";
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 50;
            nombre.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(nombre);
            cmd.ExecuteNonQuery();

            cnn.Close();

            if (nombre.Value is System.DBNull)
            {
                return "No se encontro";
            }

            return (string)nombre.Value;
        }

        public string ConsultarAutomovil(int codAutomovil, string value)
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SPA_CONSULTAR_" + value;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", codAutomovil);
            SqlParameter nombre = new SqlParameter();
            nombre.ParameterName = "@value";
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 50;
            nombre.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(nombre);
            cmd.ExecuteNonQuery();
            cnn.Close();

            if (nombre.Value is System.DBNull)
            {
                return "No se encontro";
            }

            return (string)nombre.Value;
        }


    }
}
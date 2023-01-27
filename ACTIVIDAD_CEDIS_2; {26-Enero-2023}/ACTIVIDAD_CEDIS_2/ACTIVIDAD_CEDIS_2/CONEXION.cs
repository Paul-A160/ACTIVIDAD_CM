using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace ACTIVIDAD_CEDIS_2
{
    public class CONEXION
    {
        //Clase donde se crea la conexion con la BD de SQL SERVER
        //Tambièn se encuentran todos los metodos relacionados a cada procedimiento almacenado y hacer posible interactuar con la BD
        //Procedimientos almacenados con funcionalidades como: Insertar, Borrar, Modificar o Buscar todos los registros o registros especificos

        public static string InstanciaSQL = "";

     
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
       





       
        public CONEXION()
        {
            try
            {
              
                char X = Convert.ToChar(92);

                //Asignar a esta variable el nombre de tu instancia de SQL, 
                //y si ya tienes la BD  creada, todo debería de funcionar correctamente.             
                //string TuInstancia = "DESKTOP-L2PMN3L" + X + "SQLEXPRESS";
                string TuInstancia = "DESKTOP-L2PMN3L";

                //Asignar en esta variable el nombre de la BD creada en SQL
                string BD = "ACTIVIDAD_CEDIS";

                InstanciaSQL = "Data Source=" + TuInstancia + "; Initial Catalog =" + BD + "; Integrated Security =True";
                cn = new SqlConnection( "Data Source=192.168.0.18;Initial Catalog= Libreria; Integrated Security = True");


                cn = new SqlConnection(InstanciaSQL);
                cn.Open();
                //MessageBox.Show("Conectado");



            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos: " +
                ex.ToString());
            }
        }
        public DataTable SELECT_ALL_CATALOGO()
        {

            DataTable DT1 = new DataTable();
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.SP_SELECT_ALL_CATALOGO", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                //cmd.Parameters.Clear();

                //Ejecutar la sentencia sql en el servidor

                cmd.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                DT1 = dt;


                //if (dt.Rows.Count>= 1)
                //{
                //    foreach(DataRow item in dt.Rows)
                //    {

                //    }
                //}



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DT1;


        }

        public DataTable SELECT_ALL_PROVEEDORES()
        {

            DataTable DT1 = new DataTable();
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.SP_SELECT_ALL_PROVEEDORES", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                //cmd.Parameters.Clear();

                //Ejecutar la sentencia sql en el servidor

                cmd.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                DT1 = dt;


                //if (dt.Rows.Count>= 1)
                //{
                //    foreach(DataRow item in dt.Rows)
                //    {

                //    }
                //}



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DT1;


        }

        public string SP_Insertar_Producto(string codigo, string descripcion, string proveedor, string activo)
        {
            string salida = "Se insertó Registro";
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.SP_INSERTAR_ARTICULO", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                //cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);               
                cmd.Parameters.AddWithValue("@Proveedor", proveedor);
                cmd.Parameters.AddWithValue("@Activo", activo);
                //Ejecutar la sentencia sql en el servidor

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

        public string UPDATE_ONE_CATALOGO(string codigo, string descripcion, string proveedor, string activo)
        {
            string salida = "Se modificò el registro";
            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.SP_UPDATE_ONE_CATALOGO", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                //cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Proveedor", proveedor);
                cmd.Parameters.AddWithValue("@Activo", activo);
                //Ejecutar la sentencia sql en el servidor

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

        public string DELETE_ONE_CATALOGO(string codigo)
        {
            string _Salida = "Se borrò el registro";

            try
            {
                //Crear un Objeto comando
                SqlCommand cmd = new SqlCommand("dbo.SP_DELETE_ONE_CATALOGO", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                //cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                

                //Ejecutar la sentencia sql en el servidor

                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                _Salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(_Salida);
            }
            return _Salida;

        }



        //public static SqlConnection Obtnerconexion()
        //{
        //    SqlConnection Conn = new SqlConnection(InstanciaSQL);
        //    return Conn;
        //}
    }
}

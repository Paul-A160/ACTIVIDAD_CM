using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_CEDIS_2
{
    public partial class FORM_AGREGAR : Form
    {
        public CONEXION c = new CONEXION();
        public static DataTable Catalogo = new DataTable();
        public static string Accion;
        public static Articulo Producto= new Articulo();


        public class Articulo
        {
            public string _Codigo = "";
            public string _Descripcion = "None";
            public string _Proveedor = "";
            public string _Activo = "";
            
            public Articulo(string codigo, string descripcion, string proveedor, string activo)
            {
                _Codigo = codigo;
                _Descripcion = descripcion;
                _Proveedor = proveedor;
                _Activo = activo;
            }

            public Articulo()
            {
                _Codigo = "";
                _Descripcion = "Pendiente";
                _Proveedor = "";
                _Activo = "";
            }

        }
        public static string Comprobar_Checkbox(bool valor)
        {
            
            //Regresa 0 para desactivo
            //Regresa 1 para activo
            string Check = "0";

            bool _Valor = false;
            _Valor = valor;

            if (_Valor == true)
            {
                Check = "1";
            }
            return Check;
        }
        public static bool Comprobar_Datos(Articulo articulo)
        {   
            string _Salida = "La informacion proporcionada es valida";
            int _Cont = 0;
            bool _Valor = true;
            bool _Numero = true;
            bool _CodigoValidar = true;
            try
            {
                if (Accion == "AGREGAR") 
                {
                    if ((_CodigoValidar = Comprobar_Codigo_Unico(Catalogo, articulo)) == false)
                    {
                        _Salida = "-El Codigo ya existe. Favor de introducir un codigo valido. \n";
                        MessageBox.Show(_Salida);
                        _Cont++;
                    }
                }
                if (articulo._Codigo == "")
                {

                    _Salida = "-(Obligatorio): Falta llenar el apartado: Codigo \n";
                    MessageBox.Show(_Salida);
                    _Cont++;
                }
                if ((_Numero = Comprobar_Entero(articulo._Codigo))==false) 
                {
                    _Salida = "-Solamente se adimten numeros en apartado: Codigo \n";
                    MessageBox.Show(_Salida);
                    _Cont++;
                }
                if ((_Numero = Comprobar_Entero(articulo._Proveedor)) == false)
                {
                    _Salida = "-Solamente se adimten numeros en apartado: Proveedor \n";
                    MessageBox.Show(_Salida);
                    _Cont++;
                }
                if (articulo._Proveedor=="")
                {
                    _Salida = "-(Obligatorio): Falta llenar el apartado: Proveedor \n";
                    MessageBox.Show(_Salida);
                    _Cont++;
                }

                if (_Cont > 0)
                {
                    _Valor = false;
                }
                else
                {
                    MessageBox.Show(_Salida);
                }



            }
            catch (Exception ex)
            {
                _Salida = "Error al comprobar los datos:  " + ex.ToString();
                MessageBox.Show(_Salida);

            }
            return _Valor;
        }

        public static bool Comprobar_Entero(string Cadena) 
        {
            bool _Valor = true;
           
            char C ='M';
            
            int N = 0;
            for (int i = 0; i < Cadena.Length; i++) 
            {
                C = Convert.ToChar(Cadena.Substring(i,1));
                N = Convert.ToInt32(C);
                if (N < 48 || N > 57) 
                {
                    _Valor = false;
                    break;
                
                }
            }

            return _Valor;
        }

        public static bool Comprobar_Codigo_Unico(DataTable dt, Articulo producto) 
        {
            bool _Valor=true;
            foreach (DataRow row in dt.Rows) 
            {
                if (producto._Codigo == row["Codigo"].ToString()) 
                {
                    _Valor = false;
                    break;
                }
            }
            return _Valor;
        }


        public FORM_AGREGAR(Articulo producto,string accion)
        {
            InitializeComponent();
            Accion = "";
            Accion= accion;
            Catalogo = c.SELECT_ALL_CATALOGO();
            //MessageBox.Show(Accion);

            if (Accion == "EDITAR") 
            {
                Producto = producto;
                TXT_CODIGO.Text = Producto._Codigo;
                TXT_CODIGO.ReadOnly= true;
                TXT_DESCRIPCION.Text =Producto._Descripcion;
                TXT_PROVEEDOR.Text= Producto._Proveedor;
                if (Producto._Activo == "1") 
                {
                    CHBX_ACTIVO.Checked= true;
                }
            }
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            Catalogo = c.SELECT_ALL_CATALOGO();

            //Se asigna un 0 o 1 para saber si està marcado o no el Checkbox de la opciòn "Activo" del formulario.
            string Activo = Comprobar_Checkbox(CHBX_ACTIVO.Checked);

            //Se crea un objeto el cual posee todos los datos introducidos en el formulario. 
            //Esto facilitarà algunos procesos a la hora de transportar la informaciòn a otras partes del programa.
            Articulo Producto = new Articulo(TXT_CODIGO.Text, TXT_DESCRIPCION.Text, TXT_PROVEEDOR.Text, Activo);

            //Metodo para comprobar que cada dato introducido en el formulario es valido antes de registrarlo en la BD
            //(espacios vacios, Caracteres en lugar de numeros, y codigos repetidos)
            bool Validar = Comprobar_Datos(Producto);

            if (Validar == true)
            {


                if (Accion == "AGREGAR") 
                {
                    c.SP_Insertar_Producto(Producto._Codigo, Producto._Descripcion, Producto._Proveedor, Producto._Activo);

                    DialogResult dialogResult = MessageBox.Show("Desea agregar otro articulo?", "Continuar?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TXT_CODIGO.Text = "";
                        TXT_DESCRIPCION.Text = "";
                        TXT_PROVEEDOR.Text = "";
                        CHBX_ACTIVO.Checked = false;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                if (Accion == "EDITAR") 
                {
                    string salida = "";
                    salida= c.UPDATE_ONE_CATALOGO(Producto._Codigo, Producto._Descripcion, Producto._Proveedor, Producto._Activo);
                    MessageBox.Show(salida);
                    this.Close();
                }
 

            }

        }
    }
}

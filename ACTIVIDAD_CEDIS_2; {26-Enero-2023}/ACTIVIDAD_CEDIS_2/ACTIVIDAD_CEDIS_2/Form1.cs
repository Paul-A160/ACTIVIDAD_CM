using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ACTIVIDAD_CEDIS_2.FORM_AGREGAR;

namespace ACTIVIDAD_CEDIS_2
{
    public partial class Form1 : Form
    {
        public static FORM_AGREGAR AGREGAR;
        public static DataTable Catalogo = new DataTable();
        CONEXION c = new CONEXION();
        public static FORM_AGREGAR.Articulo Producto_Seleccionado = new FORM_AGREGAR.Articulo();
        public static bool Seleccionado=false;
        public static string Accion;


        public static bool Comprobar_Seleccion(DataGridView Catalogo) 
        {
            //Consultamos de nuevo la BD para asegurar que el Catalogo estè actualizado.
            //DGV_CATALOGO.DataSource = c.SELECT_ALL_CATALOGO();

            string _Salida = "Se ha seleccionado el registro";
            
            bool _Valor = true;
            //int _Row_Cont = 0;
            
            try
            {
                if ((Catalogo.SelectedRows.Count) != 1)
                {

                    _Salida = "-(): Se debe seleccionar solo un registro \n";
                    Catalogo.ClearSelection();
                    _Valor = false;
                    //BTN_DELETE.Enabled = false;
                    MessageBox.Show(_Salida);
                    
                }
                if ((Catalogo.SelectedRows.Count) == 1)
                {
                    Producto_Seleccionado = new FORM_AGREGAR.Articulo(
                       Catalogo.CurrentRow.Cells[0].Value.ToString(),
                       Catalogo.CurrentRow.Cells[1].Value.ToString(),
                       Catalogo.CurrentRow.Cells[2].Value.ToString(),
                       Catalogo.CurrentRow.Cells[3].Value.ToString());
                    MessageBox.Show("Seleccionado: Codigo " + Producto_Seleccionado._Codigo);
                    _Valor = true;
                    //BTN_DELETE.Enabled = true;
                }
                else
                {
                    MessageBox.Show(_Salida);
                }



            }
            catch (Exception ex)
            {
                _Salida = "Error al seleccionar un registro:  " + ex.ToString();
                MessageBox.Show(_Salida);

            }
            return _Valor;
        }
        public Form1()
        {
            InitializeComponent();
            Accion = "";
            DGV_CATALOGO.DataSource = c.SELECT_ALL_CATALOGO();
            //DGV_CATALOGO.ClearSelection();
            AGREGAR = new FORM_AGREGAR(Producto_Seleccionado, Accion);
            Producto_Seleccionado = new FORM_AGREGAR.Articulo();
            
            Catalogo = c.SELECT_ALL_CATALOGO();
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            Accion = "AGREGAR";
            AGREGAR = new FORM_AGREGAR(Producto_Seleccionado,Accion);
            AGREGAR.Show(this);
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            DGV_CATALOGO.DataSource = c.SELECT_ALL_CATALOGO();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (Seleccionado == true) 
            {
                DialogResult dialogResult = MessageBox.Show("Estàs seguro de borrar este registro? \n Codigo: "+Producto_Seleccionado._Codigo, "Continuar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    c.DELETE_ONE_CATALOGO(Producto_Seleccionado._Codigo);
                    Seleccionado = false;
                    BTN_DELETE.Enabled = false;
                    DGV_CATALOGO.DataSource = c.SELECT_ALL_CATALOGO();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //this.Close();
                }
            }
 
        }

        private void DGV_CATALOGO_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Se corrobora que se haya seleccionado un registro
            Seleccionado= Comprobar_Seleccion(DGV_CATALOGO);

            if(Seleccionado == true) 
            {
                BTN_DELETE.Enabled = true;
            }

        }

        private void DGV_CATALOGO_SelectionChanged(object sender, EventArgs e)
        {
            ////Consultamos de nuevo la BD para asegurar que el Catalogo estè actualizado.
            //DGV_CATALOGO.DataSource = c.SELECT_ALL_CATALOGO();

            //string _Salida = "Se ha seleccionado el registro";
            //int _Cont = 0;
            //bool _Valor = true;
            //int _Row_Cont = 0;
            //bool _CodigoValidar = true;
            //try
            //{
            //    if ((_Row_Cont = DGV_CATALOGO.SelectedRows.Count) != 1)
            //    {

            //        _Salida = "-(): Se debe seleccionar solo un registro \n";
            //        //DGV_CATALOGO.ClearSelection();
            //        MessageBox.Show(_Salida);
            //        _Cont++;
            //    }
            //    if ((_Row_Cont = DGV_CATALOGO.SelectedRows.Count) == 1)
            //    {
            //        Producto_Seleccionado = new FORM_AGREGAR.Articulo(
            //           DGV_CATALOGO.SelectedRows[0].Cells[0].Value.ToString(),
            //           DGV_CATALOGO.SelectedRows[0].Cells[1].Value.ToString(),
            //           DGV_CATALOGO.SelectedRows[0].Cells[1].Value.ToString(),
            //           DGV_CATALOGO.SelectedRows[0].Cells[1].Value.ToString());
            //        MessageBox.Show(Producto_Seleccionado._Codigo);
            //    }
            //    else
            //    {
            //        MessageBox.Show(_Salida);
            //    }



            //}
            //catch (Exception ex)
            //{
            //    _Salida = "Error al seleccionar un registro:  " + ex.ToString();
            //    MessageBox.Show(_Salida);

            //}
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            Accion = "EDITAR";
            AGREGAR = new FORM_AGREGAR(Producto_Seleccionado,Accion);
            AGREGAR.Show(this);
        }
    }
}

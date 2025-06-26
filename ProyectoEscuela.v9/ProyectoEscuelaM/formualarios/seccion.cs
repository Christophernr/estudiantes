using negocios;
using negocios.procedimientos.estudiantes;
using negocios.procedimientos.secciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace formualarios
{
    public partial class seccion : Form
    {
        public seccion()
        {
            InitializeComponent();
            llenarGridSeccion();
            label_id.Visible = false;
        }

        private void GuardarSeccion()
        {

            string seccion = txtSeccion.Text;


            serviciosSecciones secciones = new serviciosSecciones();
            var clase_seccion = new claseSecciones(0, seccion);
            if (!string.IsNullOrEmpty(seccion))
            {
                if (secciones.ExisteSeccion(clase_seccion))
                {
                    MessageBox.Show("Ya existe la seccion");

                }
                else
                {
                    var sirve = secciones.InsertarSeccion(clase_seccion);
                    if (sirve)
                    {
                        MessageBox.Show("Seccion registrada");
                        llenarGridSeccion();
                    }
                    else
                    {
                        MessageBox.Show("Intente de nuevo, algo fue mal");
                    }

                }

            }
            else
            {
                MessageBox.Show("Digite seccion correctamente");
            }

        }
        private void limpiar()
        {
            txtSeccion.Text = string.Empty;
            label_id.Visible=false;
            label_id.Text = "";
        }




        private void Eliminar()
        {

            int seccion = int.Parse(label_id.Text);
            string seccion1 = txtSeccion.Text;
            var secciones = new claseSecciones(seccion, seccion1);
            var enviar = new serviciosSecciones();
            if (enviar.EliminarSeccion(secciones))
            {

                llenarGridSeccion();
                limpiar();
            }
            else
                MessageBox.Show("No se puede borrar esta seccion, contiene estudiantes");
            return;

        }
        private void modificar()
        {
            var seccion = txtSeccion.Text.Trim();
            int seccionid = int.Parse(label_id.Text);
            var secciones = new claseSecciones(seccionid, seccion);
            var enviar = new serviciosSecciones();
            enviar.EditarSeccion(secciones);
            llenarGridSeccion();
            limpiar();

        }
        private void llenarGridSeccion()
        {
            var listaSeccion = new serviciosSecciones();

            dataListadoSeccion.DataSource = listaSeccion.CargarSeccion();

            dataListadoSeccion.Columns[0].Width = 300;
            dataListadoSeccion.Columns[1].Width = 300;

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarSeccion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void seccion_Load(object sender, EventArgs e)
        {

        }

        private void dataListadoSeccion_DoubleClick(object sender, EventArgs e)
        {
            txtSeccion.Text = Convert.ToString(dataListadoSeccion.CurrentRow.Cells["seccion"].Value);
            label_id.Text = Convert.ToString(dataListadoSeccion.CurrentRow.Cells["idSeccion"].Value);
            label_id.Visible = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void dataListadoSeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

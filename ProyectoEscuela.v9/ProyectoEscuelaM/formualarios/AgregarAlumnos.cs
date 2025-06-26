using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;
using negocios.procedimientos.asistencia;
using negocios.procedimientos.estudiantes;
using negocios.procedimientos.secciones;
namespace formualarios
{
    public partial class AgregarAlumnos : Form
    {
        private int filtroSeccion;
        public AgregarAlumnos(int seccion)
        {
            InitializeComponent();
            txt_id.Visible = false;
            filtroSeccion = seccion;
            llenarComboBoxsecciones();
            LLenardataListadoAsistencia();
        }

        //agregar estudiante

        private void GuardarEstudiante()
        {

            //agarramos los datos
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            int seccion = Convert.ToInt32(cbSeccion.SelectedValue);  //esto agarra el id de la seccion, no un "1-1" por ejemplo, porque si agarra el "1-1" no esta enviando ninguna llave foranea

            //validamos que no exista

            serviciosEstudiantes servicios = new serviciosEstudiantes();
            claseEstudiantes clase = new claseEstudiantes(0, cedula, nombre, apellidos, seccion);

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Digite cedula");
            }
            else if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Digite nombre");
            }
            else if (string.IsNullOrEmpty(apellidos))
            {
                MessageBox.Show("Digite apellidos");
            }
            else
            {
                //MessageBox.Show("Verificando existencia de cédula: " + clase.IdCedula1);
                MessageBox.Show("Id" + seccion);

                if (servicios.ExisteEstudiante(clase))
                {
                    MessageBox.Show("Ya existe estudiabte");
                }
                else
                {
                    if (servicios.InsertarEstudiante(clase))
                    {
                        MessageBox.Show("Estudiante registrado");
                    }
                    else
                    {
                        MessageBox.Show("Algo salió mal");
                    }


                }

            }
        }
        private void llenarComboBoxsecciones()
        {
            var cargarSecciones = new serviciosSecciones().CargarSeccion();
            cbSeccion.DataSource = cargarSecciones;
            cbSeccion.ValueMember = "idSeccion";
            cbSeccion.DisplayMember = "seccion";
            cbSeccion.Text = Convert.ToString(cbSeccion.SelectedValue);
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            cbSeccion.SelectedIndex = 0;
        }





        private void Eliminar()
        {
            int id = int.Parse(txt_id.Text);
            var nombre = txtNombre.Text.Trim();
            var apellidos = txtApellidos.Text.Trim();
            var cedula = txtCedula.Text.Trim();
            int seccion = Convert.ToInt32(cbSeccion.SelectedValue);
            var Alumnos = new claseEstudiantes(id, cedula, nombre, apellidos, seccion); //Instanciar: crear un objeto
            var enviar = new serviciosEstudiantes();
            enviar.EliminarEstudiante(Alumnos);
            //buscar();
            LLenardataListadoAsistencia();

            limpiar();

        }

        private void LLenardataListadoAsistencia()
        {
            serviciosEstudiantes lista = new serviciosEstudiantes();
            lista.idEnviar = filtroSeccion;
            dataListadoAsistencia.DataSource = lista.CargarAlumno();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEstudiante();
            LLenardataListadoAsistencia();
        }

        private void dataListadoAsistencia_DoubleClick(object sender, EventArgs e)
        {


            txtCedula.Text = Convert.ToString(dataListadoAsistencia.CurrentRow.Cells["idCedula"].Value);
            txtNombre.Text = Convert.ToString(dataListadoAsistencia.CurrentRow.Cells["Nombre"].Value);
            txtApellidos.Text = Convert.ToString(dataListadoAsistencia.CurrentRow.Cells["Apellidos"].Value);
            //txt_id.Visible = true;
            txt_id.Text = Convert.ToString(dataListadoAsistencia.CurrentRow.Cells["idEstudiante"].Value);
            cbSeccion.Text = Convert.ToString(dataListadoAsistencia.CurrentRow.Cells["seccion"].Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            int seccion = Convert.ToInt32(cbSeccion.SelectedValue);

            serviciosEstudiantes traerModificar = new serviciosEstudiantes();
            var TraerClase = new claseEstudiantes(id, cedula, nombre, apellidos, seccion);

            DialogResult resultado = MessageBox.Show(
                "Realmente desea guardar los cambios?",
                "confirmacion",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cedula))
                {
                    MessageBox.Show("Digite cedula para poder modificar");
                }
                else if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Digite nombre para poder modificar");
                }
                else if (string.IsNullOrEmpty(apellidos))
                {
                    MessageBox.Show("Digite apellidos para poder modificar");
                }
                else
                {
                    if (traerModificar.EditarEstudiantes(TraerClase))
                    {
                        MessageBox.Show("Estudiante exitosamente modificado");
                        LLenardataListadoAsistencia();
                    }
                    else
                        MessageBox.Show("Algo salió mal");

                }


            }
        }

        private void AgregarAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeccion.SelectedValue != null && int.TryParse(cbSeccion.SelectedValue.ToString(), out int id))
            {
                filtroSeccion = id;
                LLenardataListadoAsistencia();

            }
        }
    }
}

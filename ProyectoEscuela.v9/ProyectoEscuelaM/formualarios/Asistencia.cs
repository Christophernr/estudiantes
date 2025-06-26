using negocios.procedimientos.asistencia;
using negocios.procedimientos.estudiantes;
using negocios.procedimientos.secciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formualarios
{
    public partial class Asistencia : Form
    {
        private int idseccion;
        public Asistencia(int seccion)
        {
            InitializeComponent();
            idseccion = seccion;
            llenarGrid();
            //MessageBox.Show("el id es" + idseccion);
        }

        private void GuardarAsistencia()
        {


            DateTime fecha = DateTime.Now;

            serviciosAsistencia TraerServicioAsistencia = new serviciosAsistencia();

            bool errores = false;

            foreach (DataGridViewRow row in AlumnosGridView.Rows)
            {
                int idEstudiante = Convert.ToInt32(row.Cells["idEstudiante"].Value);

                string asistencia = Convert.ToString(row.Cells["Estado"].Value?.ToString());
                string estado = "";
                switch (asistencia)
                {
                    case "P":
                        estado = "P";
                        break;
                    case "A":
                        estado = "A";
                        break;
                    case "T":
                        estado = "T";
                        break;
                    default:
                        estado = "A"; //por si uno no seleccionada nada ponerlo ausente
                        break;
                }



                claseAsistencia asistencias = new claseAsistencia(0, idEstudiante, fecha, estado);

                if (TraerServicioAsistencia.InsertarAsistencia(asistencias))
                {
                    errores = false;

                }
                else
                    errores = true;
            }

            if (errores == true)
            {
                MessageBox.Show("Algo salió mal");
            }
            else
                MessageBox.Show("Resgistro de asistencia con exito");
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAsistencia();
        }
        private void llenarGrid()
        {
            //var listaEstudiantes = new serviciosEstudiantes();
            //listaEstudiantes.Enviar = IDSeccion;
            //var datos= listaEstudiantes.CargarAlumno().
            //    Select( e=> new {
            //        e.idEstudiante,
            //        e.nombre,
            //        e.apellidos

            //    }).ToList();

            //estudianteGridView.DataSource = datos;
            //queria usar linq pero es datatable no una lista enonces no funciona xd

            var TableEstudiantes = new serviciosEstudiantes();
            TableEstudiantes.idEnviar = idseccion;

            AlumnosGridView.DataSource = TableEstudiantes.CargarAlumno();

            //oculto las que no quiero
            AlumnosGridView.Columns["idEstudiante"].Visible = false;
            AlumnosGridView.Columns["IdCedula"].Visible = false;

            AlumnosGridView.Columns["seccion"].Visible = false;
            DataGridViewComboBoxColumn columnaCheck = new DataGridViewComboBoxColumn();

            //agrego la columa del chekcbox
            columnaCheck.Name = "Estado";
            columnaCheck.HeaderText = "Estado";
            columnaCheck.Items.AddRange("P", "A", "T");
            AlumnosGridView.Columns.Add(columnaCheck);


            AlumnosGridView.Columns["Estado"].Width = 123;
            AlumnosGridView.Columns["apellidos"].Width = 116;

        }


        private void Asistencia_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            var alumnos = new Alumnos(idseccion);
            alumnos.Show();
            this.Close();
        }
    }
}

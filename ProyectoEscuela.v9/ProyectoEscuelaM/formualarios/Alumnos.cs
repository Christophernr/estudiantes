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
using negocios.procedimientos.estudiantes;
namespace formualarios
{
    public partial class Alumnos : Form
    {
        private int IDSeccion;
        public Alumnos(int pasarId)
        {
            InitializeComponent();

            IDSeccion = pasarId;
            llenarGrid();
            //MessageBox.Show("el id es" + IDSeccion);
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
            TableEstudiantes.idEnviar = IDSeccion;



            estudianteGridView.DataSource = TableEstudiantes.FiltrarAsistenciaConteo();
            estudianteGridView.Columns[0].Visible = false;
            estudianteGridView.Columns[2].Visible = false;
            estudianteGridView.ColumnHeadersVisible = false;

        }
        private void estudianteGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TomarAsistencia_Click(object sender, EventArgs e)
        {
            var TomarAsistencia = new Asistencia(IDSeccion);
            TomarAsistencia.Show();
            this.Close();
        }

        private void btn_justificar_Click(object sender, EventArgs e)
        {
            var justificar = new justificacion(IDSeccion);
            justificar.Show();
            this.Close();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

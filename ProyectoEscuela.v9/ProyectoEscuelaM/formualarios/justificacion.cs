using negocios.procedimientos.justificacion;
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
namespace formualarios
{
    public partial class justificacion : Form
    {

        private int AlmacenSeccion;
        private DateTime FechaCalendario; /*Dia,mes y año*/
        public justificacion(int seccion)
        {
            InitializeComponent();
            AlmacenSeccion = seccion;
            LlenarelGridJustificar();
            lbl_fecha.Visible = false;
            lbl_id_asistencia.Visible = false;
            lbl_id_estudiante.Visible = false;
            llenarcombobox();
        }

        private void llenarcombobox()
        {
            cb_justificar.Items.Add("J");


        }

        private void LlenarelGridJustificar()
        {


            var tablaFiltro = new serviciosJustificacion();
            tablaFiltro.Enviar = AlmacenSeccion;

            tablaNOjustificados.DataSource = tablaFiltro.CargarAlumnoSinJustificar();



        }

        private void JustificarEstudiante()
        {
            int idAsistencia = int.Parse(lbl_id_asistencia.Text);
            string motivo = textoMotivo.Text;
            DateTime fecha = DateTime.Now; //solo la justificar
            DateTime fechaAsistencia = DateTime.Parse(lbl_fecha.Text);
            string estado = cb_justificar.Text;
            int idEstudiante = int.Parse(lbl_id_estudiante.Text);





            //agregar la justificacion
            serviciosJustificacion serviciosJustificacion = new serviciosJustificacion();
            claseJustificacion claseJustificacion = new claseJustificacion(0, idAsistencia, motivo, fecha);

            serviciosAsistencia servicios = new serviciosAsistencia();
            claseAsistencia claseAsistencia = new claseAsistencia(idAsistencia, idEstudiante, fechaAsistencia, estado);

            if (serviciosJustificacion.InsertarJustificacion(claseJustificacion) && estado == "J" && servicios.EditarAsistencia(claseAsistencia)) //para asegurarnos de que envia una J )
            {
                MessageBox.Show("Estudiante justificado con exito");
                LlenarelGridJustificar();

            }
            else
                MessageBox.Show("Algo salió mal, revisar bien!");


            //modificar la tabla asistencia y quitarle su T o su A y ponerle un J de justificado, asi se justifica y evitamos que salga de la tabla donde solo estudiantes no justificados



        }

        private void tablaNOjustificados_DoubleClick(object sender, EventArgs e)
        {
            txt_nombre.Text = Convert.ToString(tablaNOjustificados.CurrentRow.Cells["nombre"].Value);
            txt_apellidos.Text = Convert.ToString(tablaNOjustificados.CurrentRow.Cells["apellidos"].Value);
            cb_justificar.Text = Convert.ToString(tablaNOjustificados.CurrentRow.Cells["estado"].Value);
            lbl_id_asistencia.Text = Convert.ToString(tablaNOjustificados.CurrentRow.Cells["idAsistencia"].Value);
            lbl_fecha.Text = Convert.ToString(tablaNOjustificados.CurrentRow.Cells["fecha"].Value);
            lbl_id_estudiante.Text = Convert.ToString(tablaNOjustificados.CurrentRow.Cells["idEstudiante"].Value);
        }

        private void btn_justificar_Click(object sender, EventArgs e)
        {
            JustificarEstudiante();
        }



        private void calendario_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            FechaCalendario = e.Start.Date; //guarda la fecha

            serviciosJustificacion servicios = new serviciosJustificacion();
            servicios.Enviar = AlmacenSeccion;

            tablaNOjustificados.DataSource = servicios.BuscarJustificacion(FechaCalendario);
            //lbl_fecha.Text = FechaCalendario.ToString();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            var alumnos = new Alumnos(AlmacenSeccion);
            alumnos.Show();
            this.Close();
        }







        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}

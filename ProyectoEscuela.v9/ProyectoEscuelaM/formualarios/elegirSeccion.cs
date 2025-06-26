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
using negocios.procedimientos.secciones;
namespace formualarios
{
    public partial class elegirSeccion : Form
    {
        private int idSeccion;
        public elegirSeccion()
        {
            InitializeComponent();
            llenarComboBoxsecciones();

        }


        private void combo_eleccion_seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_eleccion_seccion.SelectedValue != null && int.TryParse(combo_eleccion_seccion.SelectedValue.ToString(), out int id))
            {
                idSeccion = id;
                
            }
        }


        private void llenarComboBoxsecciones()
        {
            var cargarSecciones = new serviciosSecciones().CargarSeccion();

            
            combo_eleccion_seccion.DisplayMember = "seccion";
            combo_eleccion_seccion.ValueMember = "idSeccion";
            combo_eleccion_seccion.DataSource = cargarSecciones;
            //var seccion = Convert.ToInt32(combo_eleccion_seccion.SelectedValue);
            //label1.Text = seccion.ToString();
            //idSeccion = int.Parse(label1.Text);
            //combo_eleccion_seccion.Text = Convert.ToString(combo_eleccion_seccion.SelectedValue);
        }

        private void seleccion_seccion_Click(object sender, EventArgs e)
        {

            //var seccion = Convert.ToInt32(combo_eleccion_seccion.SelectedValue);
            if (combo_eleccion_seccion.SelectedIndex == -1)
            {
                MessageBox.Show("No ha elegido la seccion");
                //return;
            }
            else
            {

                
                    var asistencia = new Asistencia(idSeccion);

                    var abrir = new Alumnos(idSeccion);
                    var justificar = new justificacion(idSeccion);
                    abrir.Show();
                    //this.Close();
                   


            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int seccion = Convert.ToInt32(combo_eleccion_seccion.SelectedValue);
            var objetoformularioCategoria = new AgregarAlumnos(seccion);
            objetoformularioCategoria.ShowDialog();
        }

        private void agregarSeccion_Click(object sender, EventArgs e)
        {
            seccion objetoformularioCategoria = new seccion();
            objetoformularioCategoria.Show();

        }

        private void elegirSeccion_Load(object sender, EventArgs e)
        {

        }


    }
}

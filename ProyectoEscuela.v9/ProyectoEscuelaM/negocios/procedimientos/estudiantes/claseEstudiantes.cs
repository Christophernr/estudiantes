using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace negocios.procedimientos.estudiantes
{
    public class claseEstudiantes
    {

        private int idEstudiante;
        private string IdCedula;
        private string nombre;
        private string apellidos;
        private int idSeccionFO; //foranea

        public claseEstudiantes(int idEstudiante, string idCedula, string nombre, string apellidos, int idSeccionFO)
        {
            this.IdEstudiante = idEstudiante;
            IdCedula1 = idCedula;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.IdSeccionFO = idSeccionFO;
        }

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string IdCedula1 { get => IdCedula; set => IdCedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int IdSeccionFO { get => idSeccionFO; set => idSeccionFO = value; }
    }
}

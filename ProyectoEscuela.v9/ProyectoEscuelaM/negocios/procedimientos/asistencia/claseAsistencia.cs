using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace negocios.procedimientos.asistencia
{
    public class claseAsistencia
    {
        private int idAsistencia;
        private int idEstudianteFO; //foreing
        private DateTime fecha;
        private string estado;

        public claseAsistencia(int idAsistencia, int idEstudianteFO, DateTime fecha, string estado)
        {
            this.IdAsistencia = idAsistencia;
            this.IdEstudianteFO = idEstudianteFO;
            this.Fecha = fecha;
            this.Estado = estado;
        }

        public int IdAsistencia { get => idAsistencia; set => idAsistencia = value; }
        public int IdEstudianteFO { get => idEstudianteFO; set => idEstudianteFO = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}

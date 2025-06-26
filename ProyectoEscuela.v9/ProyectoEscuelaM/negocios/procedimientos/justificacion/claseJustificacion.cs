using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace negocios.procedimientos.justificacion
{
    public class claseJustificacion
    {
        private int idJustificacion;
        private int idAsistenciaFO;
        private string motivo;
        private DateTime fechaJustificacion;

        public claseJustificacion(int idJustificacion, int idAsistenciaFO, string motivo, DateTime fechaJustificacion)
        {
            this.IdJustificacion = idJustificacion;
            this.IdAsistenciaFO = idAsistenciaFO;
            this.Motivo = motivo;
            this.FechaJustificacion = fechaJustificacion;
        }

        public int IdJustificacion { get => idJustificacion; set => idJustificacion = value; }
        public int IdAsistenciaFO { get => idAsistenciaFO; set => idAsistenciaFO = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public DateTime FechaJustificacion { get => fechaJustificacion; set => fechaJustificacion = value; }
    }
}

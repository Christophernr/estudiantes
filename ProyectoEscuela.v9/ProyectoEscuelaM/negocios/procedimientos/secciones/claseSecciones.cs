using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace negocios.procedimientos.secciones
{
    public class claseSecciones
    {
        private int idSeccion;
        private string seccion;

        public claseSecciones(int idSeccion, string seccion)
        {
            this.IdSeccion = idSeccion;
            this.Seccion = seccion;
        }

        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string Seccion { get => seccion; set => seccion = value; }
    }
}

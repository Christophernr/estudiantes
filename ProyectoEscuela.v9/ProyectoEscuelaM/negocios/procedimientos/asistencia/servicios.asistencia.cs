using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace negocios.procedimientos.asistencia
{
    public class serviciosAsistencia
    {


        private conexionBD conexiones;

        public serviciosAsistencia()
        { 
            conexiones = new conexionBD();
        }



        //registrar asistencia

        public bool InsertarAsistencia(claseAsistencia asistencia)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if(entrar)
                {
                    conexiones.Sentencia = "spInsertarAsistencia";

                    conexiones.addIntParameter("@idEstudianteFO", asistencia.IdEstudianteFO);
                    conexiones.addStringParameter("@estado", asistencia.Estado);

                    conexiones.EjecutaStoreProcedure();
                }
                else
                {
                    return false;                    
                }

                conexiones.CerrarConeccion();
                return true;




            }
            catch (Exception ex) { throw ex; }
        }

        //modificar asistecia

        public bool EditarAsistencia(claseAsistencia asistencia)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spEditarModificarAsistencia";

                    conexiones.addIntParameter("@idAsistencia", asistencia.IdAsistencia);
                    conexiones.addDateParameter("@fecha", asistencia.Fecha);
                    conexiones.addStringParameter("@estado", asistencia.Estado);

                    conexiones.EjecutaStoreProcedure();
                }
                else
                {
                    return false;
                }

                conexiones.CerrarConeccion();
                return true;




            }
            catch (Exception ex) { throw ex; }
        }


        public DataTable BuscarAsistencia(DateTime texto)
        {
            try
            {
                DataTable DtResultado = new DataTable("asistencia");
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spBuscarAsistencia";
                    conexiones.addDateParameter("@textobuscar", texto);

                    var encontro = conexiones.GetStoreProcedure();

                    if (encontro)
                    {
                        var buscar = conexiones.GetSQL_RS();
                        DtResultado.Load(buscar);
                    }
                }

                conexiones.CerrarConeccion();
                return DtResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

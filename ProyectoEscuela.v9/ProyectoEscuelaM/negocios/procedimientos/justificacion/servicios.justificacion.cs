using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace negocios.procedimientos.justificacion
{
    public class serviciosJustificacion
    {
        private conexionBD conexiones;

        public serviciosJustificacion()
        {
            conexiones = new conexionBD();

        }

        public int Enviar {get; set;}

        //registrar una justificacion

        public bool InsertarJustificacion(claseJustificacion justificar)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spInsertarJustificacion";

                    conexiones.addIntParameter("@idAsistenciaFO", justificar.IdAsistenciaFO);
                    conexiones.addStringParameter("@motivo", justificar.Motivo);

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

        //editar la justificacion

        public bool editarJustificacion(claseJustificacion justificar)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spEditarJustificacion";

                    conexiones.addIntParameter("@idAsistenciaFO", justificar.IdAsistenciaFO);
                    conexiones.addStringParameter("@motivo", justificar.Motivo);

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

        public DataTable CargarAlumnoSinJustificar()
        {
            try
            {
                DataTable DtResultado = new DataTable();
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spFiltrarJustificacionPorSeccion";
                    conexiones.addIntParameter("@idseccion", Enviar);
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

        public DataTable BuscarJustificacion(DateTime fecha)
        {
            try
            {
                DataTable DtResultado = new DataTable();
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spBuscarJustificacionPorSeccionPorFecha";
                    conexiones.addDateParameter("@fecha", fecha);
                    conexiones.addIntParameter("@idSeccion", Enviar);
                    var encuentro = conexiones.GetStoreProcedure();

                    if (encuentro)
                    { 
                        var buscar= conexiones.GetSQL_RS();
                        DtResultado.Load(buscar);
                    }
                    

                    
                }
                conexiones.CerrarConeccion();
                return DtResultado;

            }
            catch (Exception ex) { throw ex; }
            
        }

    }
}

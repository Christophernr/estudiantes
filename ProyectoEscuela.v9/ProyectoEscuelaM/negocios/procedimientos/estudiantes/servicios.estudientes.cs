using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Microsoft.Identity.Client;
namespace negocios.procedimientos.estudiantes
{
    public class serviciosEstudiantes
    {
        private conexionBD conexiones;

        public serviciosEstudiantes()
        {
            conexiones = new conexionBD();

           
        }
        public int idEnviar { get; set; }

        //sp de insertar al estudiante

        public bool InsertarEstudiante(claseEstudiantes estudiantes)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spInsertarEstudiantes";
                    conexiones.addStringParameter("@IdCedula", estudiantes.IdCedula1);
                    conexiones.addStringParameter("@nombre", estudiantes.Nombre);
                    conexiones.addStringParameter("@apellidos", estudiantes.Apellidos);
                    conexiones.addIntParameter("@seccion", estudiantes.IdSeccionFO); //foranea

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

        //sp editar estudiabte

        public bool EditarEstudiantes(claseEstudiantes estudiantes)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spEditarEstudiantes";
                    conexiones.addIntParameter("@idEstudiante", estudiantes.IdEstudiante);
                    conexiones.addStringParameter("@Cedula", estudiantes.IdCedula1);
                    conexiones.addStringParameter("@nombre", estudiantes.Nombre);
                    conexiones.addStringParameter("@apellidos", estudiantes.Apellidos);
                    conexiones.addIntParameter("@seccion", estudiantes.IdSeccionFO); //foranea

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

        //sp de buscar

        public DataTable BuscarEstudiante(string texto)
        {
            try
            {
                DataTable DtResultado = new DataTable("estudiantes");
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spBuscarEstudiantes";
                    conexiones.addStringParameter("@textobuscar", texto);

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

        //sp de existe estudiante
        public bool ExisteEstudiante(claseEstudiantes estudiantes)
        {
            try
            {
                var entra = conexiones.AbrirConeccion();
                var encontro = false;
                if (entra)
                {
                    conexiones.Sentencia = "spExisteEstudiantes";
                    conexiones.addStringParameter("@IdCedula", estudiantes.IdCedula1);

                    encontro = conexiones.GetuniqueStoreProcedure();

                }
                conexiones.CerrarConeccion();
                return encontro;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //
        }
        public bool EliminarEstudiante(claseEstudiantes estudiantes)
        {
            try
            {
                var entra = conexiones.AbrirConeccion();
                if (entra)
                {
                    conexiones.Sentencia = "spEliminarEstudiante";
                    conexiones.addIntParameter("@idEstudiante", estudiantes.IdEstudiante);
                    
                    conexiones.EjecutaStoreProcedure();

                }
                else
                {
                    return false;
                }
                conexiones.CerrarConeccion();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //filtrar los alumnos por secciones
        public DataTable CargarAlumno()
        {
            try
            {
                DataTable DtResultado = new DataTable("estudiantes");
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spFiltrarEstudiantePorSuSeccion";
                    conexiones.addIntParameter("@idseccion", idEnviar);
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

        //el conteo de asistencias

        public DataTable FiltrarAsistenciaConteo()
        {
            try
            {
                DataTable DtResultado = new DataTable("estudiantes");
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spFiltrarAsistenciasConteo";
                    conexiones.addIntParameter("@idseccion", idEnviar);
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

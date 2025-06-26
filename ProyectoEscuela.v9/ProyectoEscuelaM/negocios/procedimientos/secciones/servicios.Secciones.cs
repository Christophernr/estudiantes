using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using negocios.procedimientos.estudiantes;

namespace negocios.procedimientos.secciones
{
    public class serviciosSecciones
    {
        private conexionBD conexiones;

        public serviciosSecciones()
        {
            conexiones = new conexionBD();

        }


        //registrar una justificaciones


        public bool InsertarSeccion(claseSecciones secciones)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spInsertarSeccion";

                    conexiones.addStringParameter("@seccion", secciones.Seccion);
                    conexiones.EjecutaStoreProcedure();




                } else { return false; }

                conexiones.CerrarConeccion();
                return true;




            }
            catch (Exception ex) { throw ex; }

        }
        public bool EliminarSeccion(claseSecciones secciones)
        {
            try
            {
                var entra = conexiones.AbrirConeccion();
                if (entra)
                {
                    conexiones.Sentencia = "spEliminarSeccion";
                    conexiones.addIntParameter("@idSeccion", secciones.IdSeccion);


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

                return false;
            }
        }

        public bool EditarSeccion(claseSecciones secciones)
        {
            try
            {
                var entrar = conexiones.AbrirConeccion();

                if (entrar)
                {
                    conexiones.Sentencia = "spEditarSeccion";

                    conexiones.addIntParameter("@idSeccion", secciones.IdSeccion);
                    conexiones.addStringParameter("@seccion", secciones.Seccion);
                    conexiones.EjecutaStoreProcedure();




                }
                else { return false; }

                conexiones.CerrarConeccion();
                return true;




            }
            catch (Exception ex) { throw ex; }

        }


        public DataTable BuscarSecciones(string texto)
        {
            try
            {
                DataTable DtResultado = new DataTable("seccion");
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spBuscarSeccion";
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

        public bool ExisteSeccion(claseSecciones secciones)
        {
            try
            {
                var entra = conexiones.AbrirConeccion();
                var encontro = false;
                if (entra)
                {
                    conexiones.Sentencia = "spExisteSeccion";
                    conexiones.addStringParameter("@Seccion", secciones.Seccion);

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

        //para mostrar en el combobox de estudiantes
        public DataTable CargarSeccion()
        {
            try
            {
                DataTable DtResultado = new DataTable("seccion");
                var entra = conexiones.AbrirConeccion();

                if (entra)
                {
                    conexiones.Sentencia = "spCargarSecciones";

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

using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class PersonaCommand
    {
        public Personas consultarPersona(Personas persona)
        {
            var respuesta = new Personas();
            try
            {
                var objUser = new Personas();
                var conBD = new ConexionBD();

                if (persona._identificacion != "")
                {
                    objUser = conBD.consultarPersona(persona._identificacion);
                }

                respuesta = objUser;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }
        public bool eliminarPersona(Personas persona)
        {
            bool respuesta = false;
            try
            {
                var objUser = new Personas();
                var conBD = new ConexionBD();
                respuesta = conBD.eliminarPersona(persona._identificacion);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar. " + ex);
            }
            return respuesta;

        }
        public bool modificarPersona(Personas persona)
        {
            var respuesta = false;
            try
            {
                var conBD = new ConexionBD(); 
                respuesta = conBD.modificarPersona(persona);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la modificacion. " + ex);
            }
            return respuesta;
        }

    }
}
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class PersonaCommand
    {
        // colocar las operaciones de validaciones necesarias o
        // cualquier otra operacion(Logica)

        // consultar en la base de datos y se coloca la logica

        /// <summary>
        /// Consulta a las personas por cedula
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Personas consultarPersona(Personas person)
        {
            var respuesta = new Personas();
            try
            {
                var objUser = new Personas();
                var conBD = new ConexionBD();

                if (person._numeroCedulaRif != 0)
                {
                    objUser = conBD.consultarPersonaCedula(person._cedulaRif, person._numeroCedulaRif);
                }

                respuesta = objUser;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }

        /// <summary>
        /// Se realiza la consulta de usuarios 
        /// desde la bdd, admin y users
        /// </summary>
        /// <returns></returns>
        public List<Personas> consultarPersona()
        {
            var respuesta = new List<Personas>();
            try
            {
                List<Personas> objUser = new List<Personas>();
                var conBD = new ConexionBD();
                objUser = conBD.consultarPersona();

                respuesta = objUser;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }

        public bool agregarPersona(Personas person)
        {
            var respuesta = false;
            try
            {
                var objUser = new Personas();
                var conBD = new ConexionBD();

                if (person._nombre != "")
                {
                    respuesta = conBD.registrarPersona(person);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar. " + ex);
            }
            return respuesta;
        }

    }
}
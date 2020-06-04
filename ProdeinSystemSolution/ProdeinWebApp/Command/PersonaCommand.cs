using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class PersonaCommand
    {
<<<<<<< HEAD
        public Personas consultarPersona(Personas persona)
=======
        // colocar las operaciones de validaciones necesarias o
        // cualquier otra operacion(Logica)

        // consultar en la base de datos y se coloca la logica

        /// <summary>
        /// Consulta a las personas por cedula
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Personas consultarPersona(Personas person)
>>>>>>> master
        {
            var respuesta = new Personas();
            try
            {
                var objUser = new Personas();
                var conBD = new ConexionBD();

<<<<<<< HEAD
                if (persona._identificacion != "")
                {
                    objUser = conBD.consultarPersona(persona._identificacion);
=======
                if (person._numeroCedulaRif != 0)
                {
                    objUser = conBD.consultarPersonaCedula(person._cedulaRif, person._numeroCedulaRif);
>>>>>>> master
                }

                respuesta = objUser;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }
<<<<<<< HEAD
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
=======

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
>>>>>>> master
        {
            var respuesta = false;
            try
            {
<<<<<<< HEAD
                var conBD = new ConexionBD(); 
                respuesta = conBD.modificarPersona(persona);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la modificacion. " + ex);
=======
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
>>>>>>> master
            }
            return respuesta;
        }

    }
}
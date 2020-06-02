using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class UsuarioCommand
    {        
        // colocar las operaciones de validaciones necesarias o
        // cualquier otra operacion(Logica)

        // consultar en la base de datos y se coloca la logica

        /// <summary>
        /// Consulta a los usuarios por nombre
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Usuario consultarUsuario(Usuario user)
        {            
            var respuesta = new Usuario();
            try
            {
                var objUser = new Usuario();
                var conBD = new ConexionBD();

                if (user._nombre!="")
                {
                    objUser = conBD.consultarUsuarioNombre(user._nombre);
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
        public List <Usuario> consultarUsuarios()
        {
            var respuesta = new List <Usuario>();
            try
            {
                List<Usuario> objUser = new List <Usuario>();
                var conBD = new ConexionBD();
                objUser = conBD.consultarUsuarios();
                
                respuesta = objUser;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }

        /// <summary>
        /// registrar usuario, se puede validar aca los campos 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool agregarUsuario(Usuario user)
        {
            var respuesta = false;
            try
            {
                var objUser = new Usuario();
                var conBD = new ConexionBD();

                if (user._nombre != "")
                {
                    respuesta = conBD.registrarUsuario(user);
                }         
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }
        
        /// eliminar usuario
        /// modificar usuario
    }
}
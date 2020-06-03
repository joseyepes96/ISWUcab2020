using ProdeinWebApp.Command;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Controllers
{
    public class UsuarioController
    {
        /// <summary>
        /// Se pasa el objeto con el contenido del usuario a registrar
        /// ****** Validar campos vacios ****
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool agregarUsuario(Usuario user)
        {
            var respuesta = false;            
            UsuarioCommand uc = new UsuarioCommand();
            respuesta = uc.agregarUsuario(user);

            return respuesta;
        }

        public List<Usuario> consultarUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            UsuarioCommand uc = new UsuarioCommand();
            listaUsuarios = uc.consultarUsuarios();

            return listaUsuarios;
        }
        public Usuario verificarUsuario(String nombre)
        {
            var userLogin = new Usuario();
            userLogin._nombre = nombre;
            UsuarioCommand uc = new UsuarioCommand();
            Usuario usuario = uc.consultarUsuario(userLogin);

            return usuario;
        }
        public bool eliminarUsuario(Usuario user)
        {
            var respuesta = false;
            UsuarioCommand uc = new UsuarioCommand();
            respuesta = uc.eliminarUsuario(user);
            return respuesta;
        }
        public bool modificarUsuario(Usuario user)
        {
            bool respuesta = false;
            UsuarioCommand uc = new UsuarioCommand();
            respuesta = uc.modificarUsuario(user);
            return false;
        }
    }
    
}
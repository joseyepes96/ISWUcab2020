using ProdeinWebApp.Command;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Controllers
{
    public class LoginController
    {
        // es el puente para realizar las operaciones referente al login 
        // hacia el comando y de ahi a la bd

        /// <summary>
        /// Consulta si el usuario existe primero buscando por nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="password"></param>
        /// <returns>El objeto usuario logueado</returns>
        public Usuario verificarUsuario (string nombre, string password)
        {
            var userLogin = new Usuario();
            userLogin._nombre = nombre;
            userLogin._password = password;
            UsuarioCommand uc = new UsuarioCommand();
            Usuario usuario =  uc.consultarUsuario(userLogin);

            return usuario;
        }
    }
}
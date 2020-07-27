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

        public Boolean validarCampoUsuario(string usuario)
        {
            int j = 0;                               //indicará si cumple con el formato NombreApellido
            char letra;
            if (!string.IsNullOrEmpty(usuario))                   //si el campo no está vacío
            {
                for (int i = 0; i < usuario.Length; i++)
                {
                    letra = usuario[i];
                    if (letra >= 'A' && letra <= 'Z')
                        j++;
                }
                if (j == 2 && (usuario[0] >= 'A' && usuario[0] <= 'Z'))
                     return true;
            }

            return false;
        }

    }
}
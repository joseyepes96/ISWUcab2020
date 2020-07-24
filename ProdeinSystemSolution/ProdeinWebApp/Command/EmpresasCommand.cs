using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class EmpresasCommand
    {
        public Empresas consultarEmpre(Empresas empresa)
        {
            var respuesta = new Empresas();
            try
            {
                var objEmpre = new Empresas();
                var conBD = new ConexionBD();

                if (empresa._numeroRif != 0)
                {
                    objEmpre = conBD.consultarEmpresa(empresa._numeroRif);
                }

                respuesta = objEmpre;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }
        public bool eliminarEmpresa(Empresas empresa)
        {
            bool respuesta = false;
            try
            {
                var objEmpre = new Empresas();
                var conBD = new ConexionBD();
                respuesta = conBD.eliminarEmpresa(empresa._numeroRif);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar. " + ex);
            }
            return respuesta;

        }
        public bool modificarEmpresa(Empresas empresa)
        {
            var respuesta = false;
            try
            {
                var conBD = new ConexionBD();
                respuesta = conBD.modificarEmpresa(empresa);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la modificacion. " + ex);
            }
            return respuesta;
        }
        public Empresas consultarEmpresa(Empresas empresa)
        {
            var respuesta = new Empresas();
            try
            {
                var objEmpre = new Empresas();
                var conBD = new ConexionBD();

                if (empresa._numeroRif != 0)
                {
                    objEmpre = conBD.consultarEmpresaRif(empresa._rif, empresa._numeroRif);
                }

                respuesta = objEmpre;
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
        public List<Empresas> consultarEmpresa()
        {
            var respuesta = new List<Empresas>();
            try
            {
                List<Empresas> objEmpre = new List<Empresas>();
                var conBD = new ConexionBD();
                objEmpre = conBD.consultarEmpresa();

                respuesta = objEmpre;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }

        public bool agregarEmpresa(Empresas empresa)
        {
            var respuesta = false;
            try
            {
                var objEmpre = new Empresas();
                var conBD = new ConexionBD();

                if (empresa._nombre != "")
                {
                    respuesta = conBD.registrarEmpresa(empresa);
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
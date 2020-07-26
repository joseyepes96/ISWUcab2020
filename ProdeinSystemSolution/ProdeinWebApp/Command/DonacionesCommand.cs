using System;
using ProdeinWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Command
{
    public class DonacionesCommand
    {
        public bool agregarDonaciones(Donacion donacion)
        {
            var respuesta = false;
            try
            {
                var objDonacion = new Donacion();
                var conBD = new ConexionBD();

                if (donacion._nombre != "")
                {
                    respuesta = conBD.registrarDonaciones(donacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar. " + ex);
            }
            return respuesta;
        }
        public Donacion consultarDonacion(Donacion donacion)
        {
            var respuesta = new Donacion();
            try
            {
                var objDona = new Donacion();
                var conBD = new ConexionBD();

                if (donacion._id != 0)
                {
                    objDona = conBD.consultarDonacion(donacion._id);
                }

                respuesta = objDona;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }
        public bool eliminarDonacion(Donacion dona)
        {
            bool respuesta = false;
            try
            {
                var objDona = new Donacion();
                var conBD = new ConexionBD();
                respuesta = conBD.eliminarDonacion(dona._id);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar. " + ex);
            }
            return respuesta;

        }
        public bool modificarDonaciones(Donacion donacion)
        {
            var respuesta = false;
            try
            {
                var conBD = new ConexionBD();
                respuesta = conBD.modificarDonacion(donacion);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la modificacion. " + ex);
            }
            return respuesta;
        }
        public List<Donacion> consultarDonacion()
        {
            var respuesta = new List<Donacion>();
            try
            {
                List<Donacion> objdonacion = new List<Donacion>();
                var conBD = new ConexionBD();
                objdonacion = conBD.consultarDonacion();

                respuesta = objdonacion;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la busqueda. " + ex);
            }
            return respuesta;
        }

    }
}
using System;
using ProdeinWebApp.Models;
using ProdeinWebApp.Command;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Controllers
{
    public class DonacionesController
    {
        public bool agregarDonaciones(Donacion donacion)
        {
            var respuesta = false;
            DonacionesCommand ec = new DonacionesCommand();
            respuesta = ec.agregarDonaciones(donacion);

            return respuesta;
        }
        public Donacion verificarDonacion(int id)
        {
            var userDonacion = new Donacion();
            userDonacion._id = id;
            DonacionesCommand dc = new DonacionesCommand();
            Donacion donacion = dc.consultarDonacion(userDonacion);
            return donacion;
        }
        public bool eliminarDonacion(Donacion donacion)
        {
            var respuesta = false;
            DonacionesCommand dc = new DonacionesCommand();
            respuesta = dc.eliminarDonacion(donacion);
            return respuesta;
        }
        public bool modificarDonacion(Donacion donacion)
        {
            bool respuesta = false;
            DonacionesCommand dc = new DonacionesCommand();
            respuesta = dc.modificarDonaciones(donacion);
            return respuesta;
        }
        public List<Donacion> consultarDonacion()
        {
            List<Donacion> listaDonaciones = new List<Donacion>();
            DonacionesCommand ec = new DonacionesCommand();
            listaDonaciones = ec.consultarDonacion();

            return listaDonaciones;
        }
    }
}
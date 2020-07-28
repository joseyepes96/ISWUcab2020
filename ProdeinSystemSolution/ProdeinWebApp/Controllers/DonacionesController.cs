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

        public Boolean validarCampoNumerico(string numero)
        {
            char letra = ' ';
            int flag = 0;

            if (!string.IsNullOrEmpty(numero))                   //si el campo no está vacío
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    letra = numero[i];
                    if (!(letra >= '0' && letra <= '9'))    //si tiene un caracter que no es numero
                        flag = 1;
                }
            }
            if (flag == 1)
                return false;

            return true;
        }

        public Boolean validarCampoNumericoDecimal(string numero)
        {
            char letra = ' ';
            int flag = 0, j=0;

            if (!string.IsNullOrEmpty(numero))                   //si el campo no está vacío
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    letra = numero[i];
                    if (!(letra >= '0' && letra <= '9'))        //si tiene un caracter que no es numero y un punto para el decimal
                    {
                        if (letra == ',' && numero[i-1] !=' ' && numero[i + 1] != ' ')       //solo debe llevar un punto como decimal
                            j++;
                        else
                            flag = 1;
                    }
                }
            }
            if ( flag == 1 || j >= 2)
                return false;

            return true;
        }

        public Boolean validarTexto(string texto)
        {
            char letra = ' ';
            int flag = 0;

            if (!string.IsNullOrEmpty(texto))                   //si el campo no está vacío
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    letra = texto[i];
                    if (!(letra >= 'A' && letra <= 'Z') && !(letra >= 'a' && letra <= 'z') && !(letra >= ',' && letra <= '/') && !(letra >= ' '))   //si tiene un caracter especial o numero.
                        flag = 1;
                }
            }
            if (flag == 1)
                return false;

            return true;
        }

    }
}
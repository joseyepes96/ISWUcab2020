using ProdeinWebApp.Command;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Controllers
{
    public class PersonaController
    {
        public Personas verificarPersona(int identificacion)
        {
            var persona = new Personas();
            persona._numeroCedulaRif = identificacion;
            PersonaCommand uc = new PersonaCommand();
            Personas persona1 = uc.consultarPerson(persona);
            return persona1;
        }
        public bool eliminarPersona(Personas persona)
        {
            var respuesta = false;
            PersonaCommand uc = new PersonaCommand();
            respuesta = uc.eliminarPersona(persona);
            return respuesta;
        }
        public bool modificarPersona(Personas persona)
        {
            bool respuesta = false;
            PersonaCommand pc = new PersonaCommand();
            respuesta = pc.modificarPersona(persona);
            return respuesta;
        }

        public Personas verificarPersona(string tipoDoc, string cedula)
        {
            var userPersona = new Personas();
            userPersona._numeroCedulaRif = int.Parse(cedula);
            userPersona._cedulaRif = tipoDoc;
            PersonaCommand uc = new PersonaCommand();
            Personas persona = uc.consultarPersona(userPersona);

            return persona;
        }

        public bool agregarPersona(Personas person)
        {
            var respuesta = false;
            PersonaCommand uc = new PersonaCommand();
            respuesta = uc.agregarPersona(person);

            return respuesta;
        }

        public List<Personas> consultarPersona()
        {
            List<Personas> listaPersonas = new List<Personas>();
            PersonaCommand uc = new PersonaCommand();
            listaPersonas = uc.consultarPersona();

            return listaPersonas;
        }
      
        public Boolean validarTexto(string texto) {               
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

        public Boolean validarCampoCorreo(string correo)
        {
            if (!string.IsNullOrEmpty(correo) && (correo.Contains("@gmail.com") || correo.Contains("@hotmail.com")))
                return true;
            else
                return false;
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
                    if (!(letra >= '0' && letra <= '9') )    //si tiene un caracter que no es numero
                        flag = 1;
                }
            }
            if (flag == 1)
                return false;

            return true;
        }


    }
}
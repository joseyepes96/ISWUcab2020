using ProdeinWebApp.Command;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Controllers
{
    public class PersonaController
    {

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

    }
}
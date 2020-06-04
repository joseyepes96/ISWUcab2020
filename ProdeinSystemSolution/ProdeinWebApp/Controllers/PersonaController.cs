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

    }
}